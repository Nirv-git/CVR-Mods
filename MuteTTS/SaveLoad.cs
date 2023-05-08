using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MelonLoader;
using UnityEngine;

namespace MuteTTS
{
    class SaveLoad
    {
        public static string custMsgPath = "UserData/MuteTTS/Custom_Messages.txt";
        public static string quickMsgPath = "UserData/MuteTTS/Quick_Messages.txt";
        public static string GreetingsPath = "UserData/MuteTTS/Canned_Greetings_Messages.txt";
        public static string FeelingsPath = "UserData/MuteTTS/Canned_Feelings_Messages.txt";
        public static string RequestsPath = "UserData/MuteTTS/Canned_Requests-Response_Messages.txt";
        public static string GratitudePath = "UserData/MuteTTS/Canned_Gratitude-Compliments_Messages.txt";
        public static string SocialVRPath = "UserData/MuteTTS/Canned_SocialVR_Messages.txt";
        public static string DirectionsPath = "UserData/MuteTTS/Canned_Directions_Messages.txt";
        public static string MiscPath = "UserData/MuteTTS/Canned_Misc_Messages.txt";
        public static string SmallTalkPath = "UserData/MuteTTS/Canned_SmallTalk_Messages.txt";

        public static string processTonePath = "UserData/MuteTTS/Advanced/Tone/ProcessingTone.txt";
        public static string commonMsgPath = "UserData/MuteTTS/Internal/Common_Messages.txt";

        private static float lastCommonWrite = 0;
        private static float lastCustomWrite = 0;

        public static Dictionary<string, List<string>> customLists = new Dictionary<string, List<string>>();

        public static Dictionary<string, List<string>> files = new Dictionary<string, List<string>>()
            {
                {custMsgPath, CannedMessages.listCustom},
                {quickMsgPath, CannedMessages.listQuick},
                {GreetingsPath, CannedMessages.dictGreetings},
                {GratitudePath, CannedMessages.dictGratitudeCompliments},
                {DirectionsPath, CannedMessages.dictDirections},
                {MiscPath, CannedMessages.dictMisc},
                {FeelingsPath, CannedMessages.dictFeelings},
                {RequestsPath, CannedMessages.dictRequestsResponse},
                {SocialVRPath, CannedMessages.dictSocialVR},
                {SmallTalkPath, CannedMessages.dictSmallTalk}
            };

        public static void InitFileListOrLoad()
        {
            if (!Directory.Exists("UserData/MuteTTS")) Directory.CreateDirectory("UserData/MuteTTS");
            if (!Directory.Exists("UserData/MuteTTS/Internal")) Directory.CreateDirectory("UserData/MuteTTS/Internal");
            if (!Directory.Exists("UserData/MuteTTS/Advanced")) Directory.CreateDirectory("UserData/MuteTTS/Advanced");
            if (!Directory.Exists("UserData/MuteTTS/Advanced/Tone")) Directory.CreateDirectory("UserData/MuteTTS/Advanced/Tone");
            if (!Directory.Exists("UserData/MuteTTS/CustomLists")) Directory.CreateDirectory("UserData/MuteTTS/CustomLists");

            foreach (var file in files)
            {
                var path = file.Key;
                if (File.Exists(path))
                {
                    try
                    {
                        var newData = new List<string>(File.ReadAllLines(path).ToList());
                        file.Value.Clear();
                        file.Value.AddRange(newData);
                    }
                    catch (Exception ex) { MelonLogger.Error($"Error reading: {file.Key} \n" + ex.ToString()); }
                }
            }
            SaveListFiles();

            //Processing Tone
            if (File.Exists(processTonePath))
            {
                try
                {
                    MuteTTSMod.processingTone = File.ReadAllText(processTonePath);
                }
                catch (Exception ex) { 
                    MelonLogger.Error($"Error reading: {processTonePath} \n" + ex.ToString()); 
                    MuteTTSMod.processingTone = CannedMessages.cannedProcessing; }
            }
            else
            {
                File.WriteAllText(processTonePath, CannedMessages.cannedProcessing, Encoding.UTF8);
                MuteTTSMod.processingTone = CannedMessages.cannedProcessing;
            }
            //Common List
            if (File.Exists(commonMsgPath))
            {
                try
                {
                    MuteTTSMod.mostUsedmsg = new Dictionary<string, int>(File.ReadAllLines(commonMsgPath).Select(s => s.Split(new char[] { '␟' }, StringSplitOptions.RemoveEmptyEntries))
                      .Where(x => x.Length == 2).ToLookup(p => p[0].Trim(), p => int.Parse(p[1].Trim()))
                      .ToDictionary(p => p.Key, p => p.First()));
                }
                catch (Exception ex) { MelonLogger.Warning($"Error reading: {commonMsgPath}\n" + ex.ToString()); }
            }
            //Custom Lists
            string[] fileNames = Directory.GetFiles("UserData/MuteTTS/CustomLists");
            customLists.Clear();
            foreach (string path in fileNames)
            {
                try
                {
                    var filename = Path.GetFileName(path);
                    if (filename.EndsWith(".txt"))
                    {
                        customLists.Add(filename.Replace(".txt",""), new List<string>(File.ReadAllLines(path).ToList()));
                    }
                }
                catch (Exception ex) { MelonLogger.Error($"Error reading custom lists: {path} \n" + ex.ToString()); }
            }
        }

        public static void SaveListFiles()
        {
            foreach(var file in files)
            {
                try
                {
                    File.WriteAllLines(file.Key, file.Value, Encoding.UTF8);
                }
                catch (Exception ex) { MelonLogger.Error($"Error writing: {file.Key}\n" + ex.ToString()); }
            }
        }

        public static void SaveCustomList()
        {
            //Should do something more to make sure it retries the save....
            if ((lastCustomWrite + 5f) >= Time.time) return;
            try
            {
                File.WriteAllLines(custMsgPath, CannedMessages.listCustom, Encoding.UTF8);
                lastCustomWrite = Time.time;
            }
            catch (Exception ex) { MelonLogger.Error($"Error writing: {custMsgPath}\n" + ex.ToString()); }
        }

        public static void SaveCommonMsgList()
        {
            if ((lastCommonWrite + 60f) >= Time.time) return;
            try
            {
                File.WriteAllLines(commonMsgPath, MuteTTSMod.mostUsedmsg.Select(p => string.Format("{0}␟ {1}", p.Key, p.Value)), Encoding.UTF8);
                lastCommonWrite = Time.time;
            }
            catch (Exception ex) { MelonLogger.Error($"Error writing: {commonMsgPath}\n" + ex.ToString()); }
        }
    }
}
