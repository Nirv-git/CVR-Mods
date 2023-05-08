using System;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Collections;
using NAudio.Wave;
using System.Text;

namespace MuteTTSConverter
{
    class MuteTTSConverter
    {
        static void Main(string[] args)
        {
            string fileName = "";
            if (args.Length == 1)
            {
                fileName = args[0].Trim();
            }
            else
            {
                Environment.Exit(-1);
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file does not exist in the same directory as the executable.");
                return;
            }

            using (var reader = new WaveFileReader(filePath))
            {
                var waveFormat = reader.WaveFormat;

                // Convert WAV to raw bytes
                using (var stream = new MemoryStream())
                {
                    var buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        stream.Write(buffer, 0, bytesRead);
                    }

                    var audioBytes = stream.ToArray();

                    // Convert bytes to Base64 string
                    var base64String = Convert.ToBase64String(audioBytes);

                    //Console.WriteLine(base64String);
                    File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProcessingTone.txt"), base64String, Encoding.UTF8);
                }
            }
        }
    } 
}
