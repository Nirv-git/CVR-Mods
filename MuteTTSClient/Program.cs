using System;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Collections;

namespace MuteTTSClient
{
    class MuteTTSClient
    {
        static SpeechSynthesizer synth = new SpeechSynthesizer();
        static void Main(string[] args)
        {
            try
            {
                synth.InjectOneCoreVoices();
            }
            catch { }

            if (args.Length >= 1)
            {
                switch (args[0])
                {
                    case "ListVoices":
                        var voices = synth.GetInstalledVoices();
                        for (int i = 0; i < voices.Count; i++)
                        {
                            Console.WriteLine($"{i} {voices[i].VoiceInfo.Description}");
                        }
                        Environment.Exit(1);
                        break;
                    case "PlayVoice":
                        if (args.Length < 6)
                            Environment.Exit(2);
                        string message = args[1];
                        int voice = Convert.ToInt32(args[2], CultureInfo.InvariantCulture);
                        float speed = Convert.ToSingle(args[3], CultureInfo.InvariantCulture);
                        float volume = Convert.ToSingle(args[4], CultureInfo.InvariantCulture);
                        int samplesRepeat = Convert.ToInt32(args[5], CultureInfo.InvariantCulture);
                        CreateVoice(message, voice, speed, volume, samplesRepeat);
                        break;
                    default:
                        Environment.Exit(3);
                        break;
                }
            }
            else
            {
                Environment.Exit(-1);
            }
        }

        private static void CreateVoice(string text, int voice = -1, float speed = 1, float volume = 1, int samplesRepeat = 0)
        {
            var s = new MemoryStream();

            if (voice != -1 && voice < synth.GetInstalledVoices().Count)
                synth.SelectVoice(synth.GetInstalledVoices()[voice].VoiceInfo.Name);

            if (speed < 0.1) speed = 0.1f;
            synth.SetOutputToAudioStream(s, new SpeechAudioFormatInfo((int)(48000 / speed), AudioBitsPerSample.Eight, AudioChannel.Mono));
            //synth.SetOutputToDefaultAudioDevice();
            synth.Speak(text);

            if (volume > 1) volume = 1;
            if (volume < 0) volume = 0;

            if (samplesRepeat > 24) samplesRepeat = 24;
            if (samplesRepeat < 0) samplesRepeat = 0;
            bool crunch = samplesRepeat != 0;
            float crunchSum = 0f;
            int crunchCount = 0;

            byte[] result = s.ToArray();
            float temp;
            for (int i = 0; i < result.Length; i++)
            {
                temp = result[i] - 128;
                temp *= volume;
                temp += 128;

                if (crunch)
                {
                    if ((i != 0 && i % samplesRepeat == 0) || i == result.Length - 1)
                    {
                        var sample = (byte)(crunchSum / crunchCount);
                        for (int r = 0; r < crunchCount; r++) //samplesRepeat
                        {
                            result[i - r] = sample;
                        }
                        crunchSum = temp;
                        crunchCount = 1;
                    }
                    else
                    {
                        crunchSum += temp;
                        crunchCount++;
                    }
                    
                }
                else
                    result[i] = (byte)(temp);
            }  

            Console.Write(Convert.ToBase64String(result));
        }
    }

    public static class SpeechApiReflectionHelper
    { //https://stackoverflow.com/a/71198211
        private const string PROP_VOICE_SYNTHESIZER = "VoiceSynthesizer";
        private const string FIELD_INSTALLED_VOICES = "_installedVoices";

        private const string ONE_CORE_VOICES_REGISTRY = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech_OneCore\Voices";

        private static readonly Type ObjectTokenCategoryType = typeof(SpeechSynthesizer).Assembly
            .GetType("System.Speech.Internal.ObjectTokens.ObjectTokenCategory")!;

        private static readonly Type VoiceInfoType = typeof(SpeechSynthesizer).Assembly
            .GetType("System.Speech.Synthesis.VoiceInfo")!;

        private static readonly Type InstalledVoiceType = typeof(SpeechSynthesizer).Assembly
            .GetType("System.Speech.Synthesis.InstalledVoice")!;


        public static void InjectOneCoreVoices(this SpeechSynthesizer synthesizer)
        {
            var voiceSynthesizer = GetProperty(synthesizer, PROP_VOICE_SYNTHESIZER);
            if (voiceSynthesizer == null) throw new NotSupportedException($"Property not found: {PROP_VOICE_SYNTHESIZER}");

            var installedVoices = GetField(voiceSynthesizer, FIELD_INSTALLED_VOICES) as IList;
            if (installedVoices == null)
                throw new NotSupportedException($"Field not found or null: {FIELD_INSTALLED_VOICES}");

            if (ObjectTokenCategoryType
                    .GetMethod("Create", BindingFlags.Static | BindingFlags.NonPublic)?
                    .Invoke(null, new object?[] { ONE_CORE_VOICES_REGISTRY }) is not IDisposable otc)
                throw new NotSupportedException($"Failed to call Create on {ObjectTokenCategoryType} instance");

            using (otc)
            {
                if (ObjectTokenCategoryType
                        .GetMethod("FindMatchingTokens", BindingFlags.Instance | BindingFlags.NonPublic)?
                        .Invoke(otc, new object?[] { null, null }) is not IList tokens)
                    throw new NotSupportedException($"Failed to list matching tokens");

                foreach (var token in tokens)
                {
                    if (token == null || GetProperty(token, "Attributes") == null) continue;

                    var voiceInfo =
                        typeof(SpeechSynthesizer).Assembly
                            .CreateInstance(VoiceInfoType.FullName!, true,
                                BindingFlags.Instance | BindingFlags.NonPublic, null,
                                new object[] { token }, null, null);

                    if (voiceInfo == null)
                        throw new NotSupportedException($"Failed to instantiate {VoiceInfoType}");

                    var installedVoice =
                        typeof(SpeechSynthesizer).Assembly
                            .CreateInstance(InstalledVoiceType.FullName!, true,
                                BindingFlags.Instance | BindingFlags.NonPublic, null,
                                new object[] { voiceSynthesizer, voiceInfo }, null, null);

                    if (installedVoice == null)
                        throw new NotSupportedException($"Failed to instantiate {InstalledVoiceType}");

                    installedVoices.Add(installedVoice);
                }
            }
        }

        private static object? GetProperty(object target, string propName)
        {
            return target.GetType().GetProperty(propName, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(target);
        }

        private static object? GetField(object target, string propName)
        {
            return target.GetType().GetField(propName, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(target);
        }
    }
}
