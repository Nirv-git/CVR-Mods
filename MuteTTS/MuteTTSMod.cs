using ABI_RC.Core.InteractionSystem;
using Dissonance.Audio.Capture;
using HarmonyLib;
using MelonLoader;
using MuteTTS;
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections.Generic;
using ABI_RC.Core.Player;
using ABI_RC.Core.Base;
using ABI_RC.Core;
using ABI_RC.Core.UI;

[assembly: MelonInfo(typeof(MuteTTSMod), "MuteTTS", MuteTTSMod.versionStr, "Nirvash, Eric van Fandenfart")] //Put Nirvash first so people know who to complain to if something breaks
[assembly: MelonGame]
[assembly: MelonOptionalDependencies("BTKUILib")]

namespace MuteTTS
{
    public class MuteTTSMod : MelonMod
    {
        public const string versionStr = "1.2.2";

        public static MuteTTSMod Instance;
        private Thread _mainThread;
        public Queue<Action> MainThreadQueue = new Queue<Action>();

        public static Action<string> OnKeyboardSubmitted;
        private static MemoryStream stream = new MemoryStream();
        private static AudioSource audiosource = null;
        private static bool playing = false;
        private static bool playingTone = false;
        private static bool lastMuteValue;
        public static bool unMuteRunning = false;
        private string lastLineRead;
        private string exeLocation;

        public static MelonPreferences_Category cat;
        private static MelonPreferences_Entry<bool> BTKUILib_en;
        public static MelonPreferences_Entry<bool> useMiscPage;
        public static MelonPreferences_Entry<bool> msgHistory;
        public static MelonPreferences_Entry<bool> loadCannedLists;
        public static MelonPreferences_Entry<int> enabledCannedLists;
        public static MelonPreferences_Entry<bool> loadCustomLists;
        public static MelonPreferences_Entry<bool> mergeCustomAndCannedLists;
        public static MelonPreferences_Entry<bool> disableCatNames;
        public static MelonPreferences_Entry<bool> disableButtonPressTimeout;

        public static MelonPreferences_Entry<int> useVoiceSetting;
        public static MelonPreferences_Entry<bool> blockMic;
        public static MelonPreferences_Entry<bool> blockMicAlert;
        public static MelonPreferences_Entry<bool> unMuteWhileSpeaking;
        public static MelonPreferences_Entry<float> TTSSpeed;
        public static MelonPreferences_Entry<float> TTSVolume;
        public static MelonPreferences_Entry<int> TTSCrunch;
        public static MelonPreferences_Entry<bool> useHotkey;
        public static MelonPreferences_Entry<string> hotkey;
        public static MelonPreferences_Entry<bool> parmDriving;
        public static MelonPreferences_Entry<int> parmkeyboardValue;
        public static KeyCode hotkeyCode;

        public static MelonPreferences_Entry<bool> processingTone_en;
        public static MelonPreferences_Entry<bool> processingTone_complete;
        public static MelonPreferences_Entry<float> processingTone_Volume;
        public static MelonPreferences_Entry<int> processingTone_Crunch;

        public static string processingTone = "";
        private static bool processingAudioClip = false;

        public static Dictionary<int, string> voicesDict = new Dictionary<int, string>();
        public static List<string> pastMessages = new List<string>();
        public static Dictionary<string, int> mostUsedmsg = new Dictionary<string, int>();
        private static object keyboardParamCoroutine;
        private static float lastBlockMicNotif = 0f;

        private static bool btkUI_init = false;
        
        public override void OnApplicationStart()
        {
            Instance = this;
            _mainThread = Thread.CurrentThread;
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                MelonLogger.Msg("MuteTTS is only available for Windows");
                return;
            }

            MelonPreferences_Category category = MelonPreferences.CreateCategory("MuteTTS");
            cat = category;
            useVoiceSetting = category.CreateEntry("UseVoice", -1, "Text to speech voice to use, see log at game start for list");
            blockMic = category.CreateEntry("BlockMic", false, "CVR will no longer be able to send your Voice. Only TTS is available");
            blockMicAlert = category.CreateEntry("blockMicAlert", true, "Alert if speaking with blocked mic");
            unMuteWhileSpeaking = category.CreateEntry("unMuteWhileSpeaking", true, "Unmute mic when trying to use TTS");
            TTSVolume = category.CreateEntry("TTS Volume", 1f, description: "Value between 0 and 1");
            TTSSpeed = category.CreateEntry("TTS Speed", 1f);
            
            useHotkey = category.CreateEntry("useHotkey", true, "Pressing the hotkey will open the keyboard.");
            hotkey = category.CreateEntry("hotkey", "RightControl", "Keybind key", description: "See here for a list of keycodes https://docs.unity3d.com/ScriptReference/KeyCode.html");
            hotkeyCode = Utils.ParseKeycode(hotkey.Value, KeyCode.RightControl);
            hotkey.OnEntryValueChanged.Subscribe((oldValue, newValue) => {
                hotkeyCode = Utils.ParseKeycode(newValue, KeyCode.RightControl);
            });

            parmDriving = category.CreateEntry("parmDriving", true, "Enable driving of MuteTTS parameters on avatars. (MuteTTSkeyboard, MuteTTSprocessing, MuteTTSplaying)");
            parmkeyboardValue = category.CreateEntry("parmkeyboardValue", 15, "Timeout for MuteTTSkeyboard param after opening keyboard");

            TTSCrunch = category.CreateEntry("TTS Crunch", 0, "TTS Crunch 0-24 (0 is off)");

            processingTone_en = category.CreateEntry("processingTone_en", false, "Play processing tone");
            processingTone_complete = category.CreateEntry("processingTone_complete", false, "Wait for tone to complete before paying voice");
            processingTone_Volume = category.CreateEntry("Processing tone Volume", .5f, description: "Value between 0 and 1.5");
            processingTone_Crunch = category.CreateEntry("processingTone_Crunch", 0, "Crunch Tone 0-24 (0 is off)");

            BTKUILib_en = category.CreateEntry("BTKUILib_en", true, "BTKUILib Support (Requires Restart)");

            MelonCoroutines.Start(WaitForMainMenuView());

            ExtractExecutable();

            LogAvailableVoices();

            HarmonyInstance.Patch(typeof(BasicMicrophoneCapture).GetMethod("ConsumeSamples", BindingFlags.Instance | BindingFlags.NonPublic), prefix: new HarmonyMethod(typeof(MuteTTSMod).GetMethod("ConsumeSamples", BindingFlags.Static | BindingFlags.Public)));

            if (MelonHandler.Mods.Any(m => m.Info.Name == "BTKUILib") && BTKUILib_en.Value)
            {
                useMiscPage = category.CreateEntry("useMiscPage", false, "BTKUI - Use 'Misc' page instead of custom page. (Restart req)");
                msgHistory = category.CreateEntry("msgHistory", true, "Keep message history for current session - Shows in BTKUI");
                loadCannedLists = category.CreateEntry("loadCannedLists", true, "Create normal canned messages buttons");
                enabledCannedLists = (MelonPreferences_Entry<int>)category.CreateEntry<int>("enabledCannedLists", -1, "Mask for what Canned Categories are Enabled", true);
                loadCustomLists = category.CreateEntry("loadCustomLists", true, "Attempt to load any custom lists from the folder Advanced/CustomLists");
                mergeCustomAndCannedLists = category.CreateEntry("mergeCustomAndCannedLists", false, "Merge Custom Lists into Canned Category");
                disableCatNames = category.CreateEntry("disableCatNames", false, "Disable Category names for QuickMsg, Canned, CustomLists");
                disableButtonPressTimeout = category.CreateEntry("disableButtonPressTimeout", false, "Disables the 1 second timeout between sending messages. This can cause issues if you spam them.");
                SaveLoad.InitFileListOrLoad();
                BTKUI_Cust.SetupUI();
                btkUI_init = true;

                loadCannedLists.OnValueChanged += BTKUI_Cust.UpdateUI;
                enabledCannedLists.OnValueChanged += BTKUI_Cust.UpdateUI;
                loadCustomLists.OnValueChanged += BTKUI_Cust.UpdateUI;
                mergeCustomAndCannedLists.OnValueChanged += BTKUI_Cust.UpdateUI;
                disableCatNames.OnValueChanged += BTKUI_Cust.UpdateUI;
            }
            else MelonLogger.Msg("BTKUILib is missing, or setting is toggled off in Mod Settings - Not adding controls to BTKUILib");
        }
        
        public override void OnUpdate()
        {
            if (useHotkey.Value)
            {
                if (Input.GetKeyDown(hotkeyCode))
                {
                    OpenTTSInput();
                }
            }
            if (MainThreadQueue.Count > 0)
                MainThreadQueue.Dequeue().Invoke();
        }
        public bool IsOnMainThread(Thread thread)
        {
            return thread.Equals(_mainThread);
        }
        public static void EnqueueIfNotMainThread(Action action)
        {
            if (!Instance.IsOnMainThread(Thread.CurrentThread))
            {
                Instance.MainThreadQueue.Enqueue(() =>
                {
                    action?.Invoke();
                });
            }
            else
            {
                action?.Invoke();
            }
        }

        private void SetParam(string name, float value)
        {
            //MelonLogger.Msg($"Setting {name} to {value}");
            if(parmDriving.Value) PlayerSetup.Instance.animatorManager.SetAnimatorParameter(name, value);
        }

        public void KeyboardParam(bool state)
        {
            //MelonLogger.Msg($"Setting {name} to {value}");
            if (keyboardParamCoroutine != null) MelonCoroutines.Stop(keyboardParamCoroutine);
            if (state)
            {
                MuteTTSMod.Instance.SetParam("MuteTTSkeyboard", 1f);
                keyboardParamCoroutine = MelonCoroutines.Start(KeyboardParamTimeout());
            }
            else
                MuteTTSMod.Instance.SetParam("MuteTTSkeyboard", 0f);
        }

        private static System.Collections.IEnumerator KeyboardParamTimeout()
        {
            var timeout = Time.time + parmkeyboardValue.Value;
            while (Time.time < timeout)
            {
                yield return new WaitForSecondsRealtime(1f);
            }
            MuteTTSMod.Instance.SetParam("MuteTTSkeyboard", 0f);
        }

        private void ExtractExecutable()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string path = "Executables";
                exeLocation = Path.GetFullPath(path + "/MuteTTSClient.exe");

                Directory.CreateDirectory(path);
                using (var stream = assembly.GetManifestResourceStream("MuteTTS.MuteTTSClient.exe"))
                {
                    using (FileStream file = new FileStream(exeLocation, FileMode.Create))
                        stream.CopyTo(file);
                }
                MelonLogger.Msg($"Extracted file to {exeLocation}");
            }
            catch (Exception)
            {
                MelonLogger.Msg("Couldnt extract exe file. Maybe file is in use and its not an error");
            }
        }

        private void LogAvailableVoices()
        {
            ProcessStartInfo startInfo = CreateDefaultStartInfo();

            startInfo.Arguments = $"ListVoices";
            MelonLogger.Msg("Available Voices:");
            using (Process exeProcess = Process.Start(startInfo))
            {
                _ = ConsumeReader(exeProcess.StandardOutput, true);
                exeProcess.WaitForExit();
            }
        }

        private async Task ConsumeReader(TextReader reader, bool logVoices)
        {
            lastLineRead = "";
            string text;

            while ((text = await reader.ReadLineAsync()) != null)
            {
                if (logVoices)
                {
                    MelonLogger.Msg(ConsoleColor.Cyan, text);
                    int index = text.IndexOf(' ');
                    int number = int.Parse(text.Substring(0, index));
                    string name = text.Substring(index + 1);
                    voicesDict.Add(number, name);
                }
                else
                    lastLineRead = text;
            }
        }

        public void GetVoice(string msg = "Hello World", bool audiosourceOnly = false)
        {
            KeyboardParam(false);
            Task.Run(() => {
                try
                {
                    if (!audiosourceOnly) SetParam("MuteTTSprocessing", 1f);
                    if (processingTone_en.Value && !String.IsNullOrWhiteSpace(processingTone) && !audiosourceOnly)
                    {
                        try
                        {
                            //Can do all of this processing once, or when volume changes
                            byte[] buffer = Convert.FromBase64String(processingTone);

                            int samplesRepeat = ((processingTone_Crunch.Value > 24) ? 24 : (processingTone_Crunch.Value < 0) ? 0 : processingTone_Crunch.Value);
                            bool crunch = samplesRepeat != 0 && processingTone_Crunch.Value != 0;
                            float crunchSum = 0f;
                            int crunchCount = 0;

                            float temp;
                            float vol = TTSVolume.Value * ((processingTone_Volume.Value > 1.5f) ? 1.5f : (processingTone_Volume.Value < 0f) ? 0f : processingTone_Volume.Value);
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                temp = buffer[i] - 128;
                                temp *= vol;
                                temp += 128;
                                if (crunch)
                                {
                                    if ((i != 0 && i % samplesRepeat == 0) || i == buffer.Length - 1)
                                    {
                                        var sample = (byte)(crunchSum / crunchCount);
                                        for (int r = 0; r < crunchCount; r++)
                                        {
                                            buffer[i - r] = sample;
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
                                    buffer[i] = (byte)(temp);

                            }
                            MelonLogger.Msg($"Playing processing tone: {buffer.Length}");
                            stream = new MemoryStream();
                            stream.Write(buffer, 0, buffer.Length);
                            stream.Position = 0;
                            MuteSpeakToggle(true);

                            playing = true;
                            playingTone = true;

                            if (audiosource == null)
                                audiosource = CreateAudioSource();
                            if (!processingAudioClip)
                            {
                                audiosource.clip = CreateAudioClipFromStream(buffer);
                                audiosource.Play();
                            }
                        }
                        catch (System.Exception ex) { MelonLogger.Error($"Error with Processing Tone\n" + ex.ToString()); }
                    }

                    ProcessStartInfo startInfo = CreateDefaultStartInfo();

                    msg = Utils.RemoveNewLine(msg, " ");
                    msg = msg.Replace("\\", "").Replace("\"", "");
                    if (btkUI_init && msgHistory.Value & !audiosourceOnly && //Don't add repeat messages
                    !(pastMessages.Count >= 1 && pastMessages[pastMessages.Count - 1] == msg)) pastMessages.Add(msg);

                    if (btkUI_init && msgHistory.Value & !audiosourceOnly)
                    {
                        if (mostUsedmsg.ContainsKey(msg))
                            mostUsedmsg[msg] += 1;
                        else
                            mostUsedmsg.Add(msg, 1);
                        SaveLoad.SaveCommonMsgList();
                    }
                    startInfo.Arguments = $"PlayVoice \"{msg}\" {useVoiceSetting.Value} {Convert.ToString(TTSSpeed.Value, CultureInfo.InvariantCulture)} {Convert.ToString(TTSVolume.Value, CultureInfo.InvariantCulture)} {Convert.ToString(TTSCrunch.Value, CultureInfo.InvariantCulture)}";

                    MelonLogger.Msg($"Calling executable with parameters {startInfo.Arguments.Replace($"\"{msg}\"", $"Length:{msg.Length}")}");
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        Task reader = ConsumeReader(exeProcess.StandardOutput, false);
                        exeProcess.WaitForExit();
                        reader.Wait();
                        byte[] buffer = Convert.FromBase64String(lastLineRead);

                        if (processingTone_complete.Value && playingTone)
                        {
                            MelonLogger.Msg($"Waiting for tone to finish");
                            while (playingTone)
                            {
                                Task.Delay(2);
                            }
                        }

                        MelonLogger.Msg($"Received {buffer.Length} bytes from executable to play");
                        SetParam("MuteTTSprocessing", 0f);
                        stream = new MemoryStream();
                        stream.Write(buffer, 0, buffer.Length);
                        stream.Position = 0;

                        if (audiosource == null)
                            audiosource = CreateAudioSource();
                        if (!processingAudioClip)
                        {   //Everything with audio source should be done on main thread, otherwise Player.log is spammed with errors, fix in the future?
                            //Issue exists in the old approved version and no one has complained yet!
                            audiosource.clip = CreateAudioClipFromStream(buffer);
                            Instance.MainThreadQueue.Enqueue(() =>
                            { //Putting this in the Queue as it can RARELY cause a crash
                                audiosource.Play();
                            });
                        }
                        if (!audiosourceOnly)
                        {
                            SetParam("MuteTTSplaying", 1f);
                            MuteSpeakToggle(true);
                            playing = true;
                        }
                        else MelonLogger.Msg($"Local Playback Only");
                    }
                }
                catch (Exception ex) { MelonLogger.Warning($"Error creating audio\n" + ex.ToString()); }

            });
        }

        private AudioClip CreateAudioClipFromStream(byte[] buffer)
        {
            if (buffer.Length == 0) return null;

            processingAudioClip = true;
            AudioClip myClip = AudioClip.Create("MuteTTS", buffer.Length, 1, 48000, false);
            try
            {
                
                float[] t = new float[buffer.Length];
                for (int i = 0; i < buffer.Length; i++)
                {
                    t[i] = ((float)buffer[i] - 128) / 128;

                }
                myClip.SetData(t, 0);
                processingAudioClip = false;
                return myClip;
            }
            catch (Exception ex) { MelonLogger.Warning($"Error creating audio clip\n" + ex.ToString()); }
            //finally
            //{
                // Without this Unity's GC does slowly get rid of these, but they can build up if doing repeat, very large clips.
                // Keep in mind to remove if Queuing audio stuff
                //UnityEngine.Object.Destroy(myClip);
            //}
            processingAudioClip = false;
            return null;
        }

        private ProcessStartInfo CreateDefaultStartInfo()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = exeLocation,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            return startInfo;
        }

        public AudioSource CreateAudioSource()
        {
            GameObject obj = new GameObject("MuteTTS");
            GameObject.DontDestroyOnLoad(obj);

            AudioSource audioSource = obj.AddComponent<AudioSource>();
            audioSource.spatialBlend = 0;

            return audioSource;
        }

        public void MuteSpeakToggle(bool unmute)
        { //This logic should be redone?
            if (!unMuteWhileSpeaking.Value) return;
            if (unmute && !unMuteRunning)
            {
                unMuteRunning = true;
                lastMuteValue = RootLogic.Instance.comms.IsMuted;
                SetMicMute(false); //Unmute mic
            }
            else if (!unmute && lastMuteValue)
            {
                unMuteRunning = false;
                SetMicMute(lastMuteValue);
            }
        }

        public void SetMicMute(bool muted)
        {
            EnqueueIfNotMainThread(() =>
            {
                Audio.SetMicrophoneActive(muted);
            });
        }

        public static void ConsumeSamples(ref ArraySegment<float> samples)
        {
            if (playing)
            {
                byte[] buffer = new byte[samples.Count];
                int read = stream.Read(buffer, 0, samples.Count);

                if (read == 0)
                {
                    Instance.SetParam("MuteTTSplaying", 0f);
                    Instance.MuteSpeakToggle(false);
                    playing = false;
                    playingTone = false;
                    return;
                }

                for (int i = 0; i < samples.Count; i++)
                {
                    if (i < read)
                        samples.Array[i] = ((float)buffer[i] - 128) / 128;
                    else
                        samples.Array[i] = 0;
                }

            }
            else if (blockMic.Value)
            {
                if (blockMicAlert.Value)
                {
                    float sum = 0;
                    int count = 0;
                    for (int i = 0; i < samples.Count; i++)
                    {
                        sum += Math.Abs(samples.Array[i] * 1000);
                        count++;
                        samples.Array[i] = 0;
                    }
                    if ((sum / count) > 30)
                    {
                        MicIsBlocked();
                        //MelonLogger.Msg(ConsoleColor.Cyan, $"Heard: {sum / count} - {sum} - {count}");
                    }
                }
                else
                {
                    for (int i = 0; i < samples.Count; i++)
                    {
                        samples.Array[i] = 0;
                    }
                }
            }
        }


        public static void MicIsBlocked()
        {
            if (lastBlockMicNotif <= Time.time - 15f)
            {
                lastBlockMicNotif = Time.time;
                EnqueueIfNotMainThread(() =>
                {
                    CohtmlHud.Instance.ViewDropText("MuteTTS", "Mic activity detected while BlockMic is active.");
                });
            }
        }

        public void OpenTTSInput() 
        {
            KeyboardParam(true);
            OpenKeyboard("", (str) => GetVoice(str));
        }

        public static void OpenKeyboard(string currentValue, Action<string> callback)
        {
            OnKeyboardSubmitted = callback;
            ViewManager.Instance.openMenuKeyboard(currentValue);
        }

        //https://github.com/SDraw/ml_mods_cvr/blob/master/ml_fpt/resources/menu.js
        public IEnumerator WaitForMainMenuView()
        {
            while (ViewManager.Instance == null)
                yield return null;
            while (ViewManager.Instance.gameMenuView == null)
                yield return null;
            while (ViewManager.Instance.gameMenuView.Listener == null)
                yield return null;

            ViewManager.Instance.gameMenuView.Listener.ReadyForBindings += () =>
            {
                ViewManager.Instance.gameMenuView.View.RegisterForEvent("MelonMod_MuteTTS_Action", new Action(OpenTTSInput));
            };

            ViewManager.Instance.gameMenuView.Listener.FinishLoad += (_) =>
            {
                ViewManager.Instance.gameMenuView.View.ExecuteScript(@"﻿{
    var l_block = document.createElement('div');
            l_block.innerHTML = `<h2> MuteTTS </h2><div class=""action-btn"" onclick=""engine.trigger('MelonMod_MuteTTS_Action');"">MuteTTS</div>`;
        document.getElementById('settings-implementation').appendChild(l_block);
    }");
            };
        }
    }

    [HarmonyPatch(typeof(ViewManager))]
    class ViewManagerPatches
    {
        [HarmonyPatch("SendToWorldUi")]
        [HarmonyPostfix]
        static void SendToWorldUi(string value)
        {
            MuteTTSMod.OnKeyboardSubmitted?.Invoke(value);

            MuteTTSMod.OnKeyboardSubmitted = null;
        }
    }
}
