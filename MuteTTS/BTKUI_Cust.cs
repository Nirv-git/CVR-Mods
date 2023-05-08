using System;
using MelonLoader;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BTKUILib;
using BTKUILib.UIObjects;
using UnityEngine;

namespace MuteTTS
{
    class BTKUI_Cust
    {
        public static void loadAssets()
        {
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-TextToSpeach", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.TextToSpeach.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Keyboard", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Keyboard.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-History", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.History.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-HistoryCommon", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.HistoryCommon.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Delete", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Delete.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Settings", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Settings.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Greetings", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Greetings.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Feelings", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Feelings.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Complement", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Complement.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Directions", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Directions.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Misc", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Misc.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Request", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Request.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-SmallTalk", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.SmallTalk.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-VR", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.VR.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Up", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Up.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Down", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Down.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-UpDown", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.UpDown.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-List", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.List.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-ListSettings", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.ListSettings.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-ListAdd", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.ListAdd.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-ListAddHistory", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.ListAddHistory.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-ReloadFiles", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.ReloadFiles.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Voice", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Voice.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Grid-Icons", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Grid-Icons.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Sound", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Sound.png"));
            QuickMenuAPI.PrepareIcon("MuteTTS", "MTTS-Trans", Assembly.GetExecutingAssembly().GetManifestResourceStream("MuteTTS.Icons.Trans.png"));
        }

        //This is done to keep BTKUI an optional dependancy 
        public static System.Object pageMuteTTSRoot, pageSettings, pageSettingsVoices, pageSettingsCannedMask, pageHistory,
            pageCustomMessages, pageCustMsgManagement, pageCustMsgAdd, pageMostCommon;
        public static System.Object quickButtons, cannedButtons, customListButtons;
        public static List<System.Object> generatedCats = new List<System.Object>();

        private static float lastMsgSent = 0f;

        private static FieldInfo _uiInstance = typeof(QMUIElement).Assembly.GetType("BTKUILib.UserInterface").GetField("Instance", BindingFlags.NonPublic | BindingFlags.Static);
        private static MethodInfo _registerRootPage = typeof(QMUIElement).Assembly.GetType("BTKUILib.UserInterface").GetMethod("RegisterRootPage", BindingFlags.NonPublic | BindingFlags.Instance);
        public static void HackRegisterRoot(Page element)
        {
            _registerRootPage.Invoke(_uiInstance.GetValue(null), new object[] { element });
        }

        public static void UpdateUI(bool newValue, bool oldValue) { ChangeButtons(); }
        public static void UpdateUI(int newValue, int oldValue) { ChangeButtons(); }


        public static void ChangeButtons()
        {
            foreach (var cat in generatedCats)
            {
                ((Category)cat).Delete();
            }
            generatedCats.Clear();
            PopulateQuickMessages();
            PopulateCannedMessages();
            PopulateCustListMessages();
        }

        public static void SetupUI()
        {
            loadAssets();

            pageSettings = new Page("MuteTTS", "MuteTTS - Settings", false);
            HackRegisterRoot((Page)pageSettings);
            pageHistory = new Page("MuteTTS", "MuteTTS - History", false);
            HackRegisterRoot((Page)pageHistory);
            pageCustomMessages = new Page("MuteTTS", "MuteTTS - Custom Messages", false);
            HackRegisterRoot((Page)pageCustomMessages);
            pageCustMsgManagement = new Page("MuteTTS", "MuteTTS - Custom Messages Management", false);
            HackRegisterRoot((Page)pageCustMsgManagement);
            pageCustMsgAdd = new Page("MuteTTS", "MuteTTS - Custom Messages Add", false);
            HackRegisterRoot((Page)pageCustMsgAdd);
            pageMostCommon = new Page("MuteTTS", "MuteTTS - Most Common Messages", false);
            HackRegisterRoot((Page)pageMostCommon);

            if (MuteTTSMod.useMiscPage.Value)
            {
                var catMisc = QuickMenuAPI.MiscTabPage.AddCategory("MuteTTS", "MuteTTS");
                pageMuteTTSRoot = new Page("MuteTTS", "Mute TTS", false);
                HackRegisterRoot((Page)pageMuteTTSRoot);
                catMisc.AddButton("Open MuteTTS Menu", "MTTS-TextToSpeach", "Page for MuteTTS options").OnPress += () =>
                {
                    ((Page)pageMuteTTSRoot).OpenPage();
                };
                catMisc.AddButton("Keyboard", "MTTS-Keyboard", "Opens a keyboard for typing a custom message").OnPress += () =>
                {
                    MuteTTSMod.Instance.KeyboardParam(true);
                    QuickMenuAPI.OpenKeyboard("", (action) => { if (action != "") MuteTTSMod.Instance.GetVoice(action); });
                };
                catMisc.AddButton("History", "MTTS-History", "Message History").OnPress += () =>
                {
                    OpenHistory();
                };
            }
            else
            {
                pageMuteTTSRoot = new Page("MuteTTS", "MuteTTS", true, "MTTS-TextToSpeach");
            }

            var page = (Page)pageMuteTTSRoot;
            page.MenuTitle = "MuteTTS";
            page.MenuSubtitle = "Text to speech stuff!";


            var cat = page.AddCategory("");
            cat.AddButton("Keyboard", "MTTS-Keyboard", "Opens a keyboard for typing a custom message").OnPress += () =>
            {
                MuteTTSMod.Instance.KeyboardParam(true);
                QuickMenuAPI.OpenKeyboard("", (action) => { if(action != "") MuteTTSMod.Instance.GetVoice(action); });
            };
            cat.AddButton("History", "MTTS-History", "Message History").OnPress += () =>
            {
                OpenHistory();
            };
            cat.AddButton("Settings", "MTTS-Settings", "Mod Settings").OnPress += () =>
            {
                OpenSettings();
            };
            cat.AddButton("Custom Messages", "MTTS-List", "List of custom saved messages. Add and edit using Settings menu.").OnPress += () =>
            {
                OpenCustMessages();
            };


            quickButtons = page.AddCategory(QuickCatString());
            PopulateQuickMessages();

            cannedButtons = page.AddCategory(CannedCatString());
            PopulateCannedMessages();

            customListButtons = page.AddCategory(CustListCatString());
            PopulateCustListMessages();
            
        }

        private static string QuickCatString()
        {
            return (MuteTTSMod.disableCatNames.Value || CannedMessages.listQuick.Count == 0) ? "" : "Quick Messages";
        }
        public static void PopulateQuickMessages()
        {
            if (((Category)quickButtons).IsGenerated)
            {
                ((Category)quickButtons).CategoryName = QuickCatString();
                ((Category)quickButtons).ClearChildren();
            }
            if (CannedMessages.listQuick.Count == 0) return;

            foreach (var msg in CannedMessages.listQuick)
            { //Only should have four, but if users want to add more, why not?
                ((Category)quickButtons).AddButton(FitToButton(msg), "MTTS-Trans", $"Say: {msg}").OnPress += () =>
                {
                    if (lastMsgSent < Time.time - 1 || MuteTTSMod.disableButtonPressTimeout.Value)
                    {
                        lastMsgSent = Time.time;
                        MuteTTSMod.Instance.GetVoice(msg);
                        //QuickMenuAPI.ShowAlertToast($"Speaking: {saying}", 2);
                    }
                    else
                        QuickMenuAPI.ShowAlertToast($"--- Message not sent --- <1 second since last message", 2);
                };
            }
        }

        private static string CannedCatString()
        {
            return (MuteTTSMod.disableCatNames.Value || !MuteTTSMod.loadCannedLists.Value) ? "" : "Message Categories";
        }
        public static void PopulateCannedMessages()
        {
            if (((Category)cannedButtons).IsGenerated)
            {
                ((Category)cannedButtons).CategoryName = CannedCatString();
                ((Category)cannedButtons).ClearChildren();
            }
            if (!MuteTTSMod.loadCannedLists.Value) return;
            
                var cat5 = (Category)cannedButtons;
                var catsToMake = new List<(string, string, List<string>, string, int)>()
                    {    //Cat Name    Description       Dict             Icon,  EnabledMask
                    {("Greetings Farewells", "Greetings and Farewells", CannedMessages.dictGreetings, "MTTS-Greetings", 1)},
                    {("Responses Requests", "Responses and Requests", CannedMessages.dictRequestsResponse, "MTTS-Request", 2)},
                    {("Compliments Gratitude", "Compliments and Gratitude", CannedMessages.dictGratitudeCompliments, "MTTS-Complement", 3)},
                    {("Misc", "Misc", CannedMessages.dictMisc, "MTTS-Misc", 4)},

                    {("Feelings", "I'm Feeling...", CannedMessages.dictFeelings, "MTTS-Feelings", 5)},
                    {("Directions", "Directions", CannedMessages.dictDirections, "MTTS-Directions", 6)},
                    {("SocialVR", "SocialVR", CannedMessages.dictSocialVR, "MTTS-VR", 7)},
                    {("Small Talk", "Small Talk", CannedMessages.dictSmallTalk, "MTTS-SmallTalk", 8)}
                    };
                foreach (var makingCat in catsToMake)
                {
                if (!Utils.IsLayerEnabled(MuteTTSMod.enabledCannedLists.Value, makingCat.Item5)) continue;
                    string catname = makingCat.Item1;
                    var pageSub = cat5.AddPage(catname, makingCat.Item4, makingCat.Item2, "MuteTTS");
                    var subCat = pageSub.AddCategory(catname);
                    generatedCats.Add(subCat);
                    foreach (var saying in makingCat.Item3)
                    {
                        subCat.AddButton(FitToButton(saying), "MTTS-Trans", $"Say: {saying}").OnPress += () =>
                        {
                            if (lastMsgSent < Time.time - 1 || MuteTTSMod.disableButtonPressTimeout.Value)
                            {
                                lastMsgSent = Time.time;
                                MuteTTSMod.Instance.GetVoice(saying);
                                //QuickMenuAPI.ShowAlertToast($"Speaking: {saying}", 2);
                            }
                            else
                                QuickMenuAPI.ShowAlertToast($"--- Message not sent --- <1 second since last message", 2);
                        };
                    }
                }
        }

        private static string CustListCatString()
        {
            return (MuteTTSMod.disableCatNames.Value || SaveLoad.customLists.Count == 0 || !MuteTTSMod.loadCustomLists.Value ||
                (MuteTTSMod.mergeCustomAndCannedLists.Value && MuteTTSMod.loadCannedLists.Value)) ? "" : "Custom Categories";
        }
        public static void PopulateCustListMessages()
        {
            if (((Category)customListButtons).IsGenerated)
            {
                ((Category)customListButtons).CategoryName = CustListCatString();
                ((Category)customListButtons).ClearChildren();
            }
            if (SaveLoad.customLists.Count == 0 || !MuteTTSMod.loadCustomLists.Value) return;

            Category cat10 = null;
            if (MuteTTSMod.mergeCustomAndCannedLists.Value && MuteTTSMod.loadCannedLists.Value)
                cat10 = (Category)cannedButtons;
            else
                cat10 = (Category)customListButtons;

            foreach (var makingCat in SaveLoad.customLists.OrderBy(x => x.Key))
            {
                string catname = makingCat.Key;
                var pageSub = cat10.AddPage(catname, "MTTS-Trans", $"Custom List: {makingCat.Key}", "MuteTTS");
                var subCat = pageSub.AddCategory(catname);
                generatedCats.Add(subCat);
                foreach (var saying in makingCat.Value)
                {
                    subCat.AddButton(FitToButton(saying), "MTTS-Trans", $"Say: {saying}").OnPress += () =>
                    {
                        if (lastMsgSent < Time.time - 1 || MuteTTSMod.disableButtonPressTimeout.Value)
                        {
                            lastMsgSent = Time.time;
                            MuteTTSMod.Instance.GetVoice(saying);
                            //QuickMenuAPI.ShowAlertToast($"Speaking: {saying}", 2);
                        }
                        else
                            QuickMenuAPI.ShowAlertToast($"--- Message not sent --- <1 second since last message", 2);
                    };
                }
            }
        }

        public static void OpenSettings()
        {
            try
            {
                var page = (Page)pageSettings;
                page.ClearChildren();
                page.MenuTitle = "Settings";
                page.MenuSubtitle = "Mod settings";

                var cat1 = page.AddCategory("");

                cat1.AddToggle("Block Mic", "CVR will no longer be able hear your mic, only TTS", MuteTTSMod.blockMic.Value ).OnValueUpdated += action =>
                {
                    MuteTTSMod.blockMic.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                cat1.AddButton("New Custom Message", "MTTS-ListAdd", "Add a new message from keyboard to the custom messages list").OnPress += () =>
                {
                    QuickMenuAPI.OpenKeyboard("", (action) => {
                        if (action != "") 
                        {
                            CannedMessages.listCustom.Insert(0, action);
                            SaveLoad.SaveCustomList();
                            QuickMenuAPI.ShowAlertToast($"Added: {action}", 3);
                        } 
                    });
                };
                cat1.AddButton("Add Custom Messages", "MTTS-ListAddHistory", "Copy messages from history into custom messages list").OnPress += () =>
                {
                    OpenCustMsgAdd();
                };
                cat1.AddButton("Edit Custom Messages List", "MTTS-ListSettings", "List of custom saved messages, delete and reorder").OnPress += () =>
                {
                    OpenCustMsgManagement();
                };
                
                page.AddSlider("Volume", "TTS Volume", MuteTTSMod.TTSVolume.Value*100, 0f, 100f).OnValueUpdated += action =>
                {
                    MuteTTSMod.TTSVolume.Value = action/100;
                };
                page.AddSlider("Speed", "TTS Speed Default=100", MuteTTSMod.TTSSpeed.Value*100, 60f, 120f).OnValueUpdated += action =>
                {
                    MuteTTSMod.TTSSpeed.Value = action/100;
                };

                string currentVoiceCat()
                {
                    if (MuteTTSMod.voicesDict.ContainsKey(MuteTTSMod.useVoiceSetting.Value))
                    {
                        var cur = MuteTTSMod.voicesDict[MuteTTSMod.useVoiceSetting.Value];
                        var trimmed = cur.Substring(0, cur.IndexOf("-")).Trim();
                        return $"Voices - Current: {trimmed}";
                    }
                    else
                    {
                        return "Voices - Current: Default (-1)";
                    }
                }

                var catVoices = page.AddCategory(currentVoiceCat());

                pageSettingsVoices = catVoices.AddPage("Change Voice", "MTTS-Voice", "Change current TTS voice.", "MuteTTS");
                if (((Page)pageSettingsVoices).IsGenerated) ((Page)pageSettingsVoices).ClearChildren();
                var voicesCat = ((Page)pageSettingsVoices).AddCategory(currentVoiceCat());

                foreach (var voice in MuteTTSMod.voicesDict)
                {
                    var trimmed = voice.Value.Substring(0, voice.Value.IndexOf("-")).Trim();
                    voicesCat.AddButton(trimmed, "MTTS-Trans", $"Select Voice: {voice.Value}<p>(Plays voice name locally)").OnPress += () =>
                    {
                        MuteTTSMod.useVoiceSetting.Value = voice.Key;
                        catVoices.CategoryName = currentVoiceCat();
                        voicesCat.CategoryName = currentVoiceCat();
                        MuteTTSMod.Instance.GetVoice($"Voice set to {trimmed}", true);
                        MuteTTSMod.cat.SaveToFile(false);
                    };
                }
                catVoices.AddButton("Test Voice", "MTTS-Sound", $"Plays currently selected voice to test<p>(Plays locally)").OnPress += () =>
                {
                    MuteTTSMod.Instance.GetVoice($"The quick brown fox jumps over a lazy dog", true);
                    MuteTTSMod.cat.SaveToFile(false);
                };

                page.AddSlider("TTS Crunch", "Crunch lowers the sample rate of audio, making it sound 'crunchy' (Int).<p>Levels above 4-6 really aren't great for understandability", MuteTTSMod.TTSCrunch.Value, 0f, 16f).OnValueUpdated += action =>
                {
                    MuteTTSMod.TTSCrunch.Value = (int)Math.Round(action, 0);
                };

                //Processing Tone
                var cat20 = page.AddCategory("");

                cat20.AddToggle("Play processing tone", "Plays a sound between submitting a message and the audio playing<p>See Mod ReadMe for instructions on creating a custom tone.", MuteTTSMod.processingTone_en.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.processingTone_en.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                cat20.AddToggle("Wait for Processing Tone", "Wait for tone to complete before paying voice", MuteTTSMod.processingTone_complete.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.processingTone_complete.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                page.AddSlider("Processing Tone Volume", "Processing Tone Volume", MuteTTSMod.processingTone_Volume.Value * 100, 0f, 150f).OnValueUpdated += action =>
                {
                    MuteTTSMod.processingTone_Volume.Value = action / 100;
                };
                page.AddSlider("Processing Tone Crunch", "Crunch lowers the sample rate of audio, making it sound 'crunchy' (Int).<p>Levels above 4-6 really aren't great", MuteTTSMod.processingTone_Crunch.Value, 0f, 16f).OnValueUpdated += action =>
                {
                    MuteTTSMod.processingTone_Crunch.Value = (int)Math.Round(action, 0);
                };

                var cat15 = page.AddCategory("Advanced Settings");

                cat15.AddToggle("Blocked Mic Alert", "Show HUD alert if speaking with blocked mic", MuteTTSMod.blockMicAlert.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.blockMicAlert.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                cat15.AddToggle("Unmute while TTS", "Unmute mic when trying to use TTS", MuteTTSMod.unMuteWhileSpeaking.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.unMuteWhileSpeaking.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                cat15.AddToggle("Hotkey Enabled", $"MuteTTS keyboard will open when you press: {MuteTTSMod.hotkeyCode}", MuteTTSMod.useHotkey.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.useHotkey.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                cat15.AddToggle("Parameter Driving", "Enable driving of MuteTTS parameters on avatars.<p>(MuteTTSkeyboard, MuteTTSprocessing, MuteTTSplaying)", MuteTTSMod.parmDriving.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.parmDriving.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };

                var cat10 = page.AddCategory("UI Settings");

                cat10.AddToggle("Populate Canned Messages", "Loads the normal 'Canned Messages' Buttons", MuteTTSMod.loadCannedLists.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.loadCannedLists.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };

                pageSettingsCannedMask = cat10.AddPage("Enable/Disable Specific", "MTTS-Grid-Icons", "Enable/Disable Specific Canned Messages Categories", "MuteTTS");
                if (((Page)pageSettingsCannedMask).IsGenerated) ((Page)pageSettingsCannedMask).ClearChildren();
                var cannedSpecificCat = ((Page)pageSettingsCannedMask).AddCategory("Enable Specific Categories");
                var catsToMake = new List<(string, int)>()
                    {
                        {("Greetings Farewells", 1)},
                        {("Responses Requests", 2)},
                        {("Compliments Gratitude", 3)},
                        {("Misc", 4)},

                        {("Feelings", 5)},
                        {("Directions", 6)},
                        {("SocialVR", 7)},
                        {("Small Talk", 8)}
                    };
                foreach (var cannedCat in catsToMake)
                {
                    cannedSpecificCat.AddToggle(cannedCat.Item1, "Enable/Disable this Canned Category", Utils.IsLayerEnabled(MuteTTSMod.enabledCannedLists.Value, cannedCat.Item2)).OnValueUpdated += action =>
                    {
                        if (action)
                            MuteTTSMod.enabledCannedLists.Value = MuteTTSMod.enabledCannedLists.Value | (1 << cannedCat.Item2); //Add
                        else
                            MuteTTSMod.enabledCannedLists.Value = MuteTTSMod.enabledCannedLists.Value & ~(1 << cannedCat.Item2); //Remove
                        MuteTTSMod.cat.SaveToFile(false);
                    };
                }

                cat10.AddToggle("Populate Custom List Messages", "Loads Custom Messages Lists from the from the folder<p>UserData/MuteTTS/Advanced/CustomLists", MuteTTSMod.loadCustomLists.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.loadCustomLists.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                cat10.AddToggle("Merge Custom into Canned", "Merge Custom Lists into Canned Messages Category", MuteTTSMod.mergeCustomAndCannedLists.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.mergeCustomAndCannedLists.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };
                cat10.AddToggle("Disable Category Names", "Disable Category names for Quick Msgs, Canned, Custom Lists", MuteTTSMod.disableCatNames.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.disableCatNames.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };

                var cat30 = page.AddCategory("");
                cat30.AddButton("Reload file lists", "MTTS-ReloadFiles", $"Try to reload files from Disk<p>UserData/MuteTTS").OnPress += () =>
                {
                    SaveLoad.InitFileListOrLoad();
                    ChangeButtons();
                };

                page.OpenPage();
            }
            catch (System.Exception ex) { MelonLogger.Error($"Error when creating settings menu\n" + ex.ToString()); }
        }

        public static void OpenHistory()
        {
            try
            {
                var page = (Page)pageHistory;
                page.ClearChildren();
                page.MenuTitle = "History";
                page.MenuSubtitle = "History of recent messages from this session";

                var cat1 = page.AddCategory("");
                cat1.AddButton("Clear", "MTTS-Delete", $"Clear History").OnPress += () =>
                {
                    QuickMenuAPI.ShowConfirm("Confirm", "Clear history?", () =>
                    {
                        MuteTTSMod.pastMessages.Clear();
                        OpenHistory();
                    }, () => { }, "Yes", "No");
                };
                cat1.AddButton("Most Common", "MTTS-HistoryCommon", $"List of most commonly sent messages").OnPress += () =>
                {
                    OpenCommonHistory();
                };
                cat1.AddToggle("Record message history", "Toggles recording history for recent messages.", MuteTTSMod.msgHistory.Value).OnValueUpdated += action =>
                {
                    MuteTTSMod.msgHistory.Value = action;
                    MuteTTSMod.cat.SaveToFile(false);
                };

                var cat2 = page.AddCategory("Past Messages");
                if (MuteTTSMod.pastMessages.Count == 0)
                {
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("History is empty");
                }
                foreach (var msg in MuteTTSMod.pastMessages.Reverse<string>())
                {
                    cat2.AddButton(FitToButton(msg), "MTTS-Trans", $"Repeat msg: {msg}").OnPress += () =>
                    {
                        if (lastMsgSent < Time.time - 1 || MuteTTSMod.disableButtonPressTimeout.Value)
                        {
                            lastMsgSent = Time.time;
                            MuteTTSMod.Instance.GetVoice(msg);
                            //QuickMenuAPI.ShowAlertToast($"Speaking: {saying}", 2);
                        }
                        else
                            QuickMenuAPI.ShowAlertToast($"--- Message not sent --- <1 second since last message", 2);
                    };
                }
                page.OpenPage();
            }
            catch (System.Exception ex) { MelonLogger.Error($"Error when creating history menu\n" + ex.ToString()); }
        }

        public static void OpenCommonHistory()
        {
            try
            {
                var page = (Page)pageMostCommon;
                page.ClearChildren();
                page.MenuTitle = "Most Common History";
                page.MenuSubtitle = "History of most commonly sent recent messages";

                var cat1 = page.AddCategory("");
                cat1.AddButton("Clear", "MTTS-Delete", $"Clear Commonly Sent History").OnPress += () =>
                {
                    QuickMenuAPI.ShowConfirm("Confirm", "Clear history for commonly sent messages?", () =>
                    {
                        MuteTTSMod.mostUsedmsg.Clear();
                        SaveLoad.SaveCommonMsgList();
                        OpenCommonHistory();
                    }, () => { }, "Yes", "No");
                };

                var cat2 = page.AddCategory("Past Common Messages");
                if (MuteTTSMod.mostUsedmsg.Count == 0)
                {
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("Common History is empty");
                }
                foreach (var msg in MuteTTSMod.mostUsedmsg.OrderBy(x => x.Value).Reverse())
                {
                    if (msg.Value >= 3)
                    {
                        cat2.AddButton(FitToButton(msg.Key), "MTTS-Trans", $"{msg.Value}-Repeat msg: {msg.Key}").OnPress += () =>
                        {
                            if (lastMsgSent < Time.time - 1 || MuteTTSMod.disableButtonPressTimeout.Value)
                            {
                                lastMsgSent = Time.time;
                                MuteTTSMod.Instance.GetVoice(msg.Key);
                                //QuickMenuAPI.ShowAlertToast($"Speaking: {saying}", 2);
                            }
                            else
                                QuickMenuAPI.ShowAlertToast($"--- Message not sent --- <1 second since last message", 2);
                        };
                    }
                }
                page.OpenPage();
            }
            catch (System.Exception ex) { MelonLogger.Error($"Error when creating common history menu\n" + ex.ToString()); }
        }

        public static void OpenCustMessages()
        {
            try
            {
                var page = (Page)pageCustomMessages;
                page.ClearChildren();
                page.MenuTitle = "Custom Messages";
                page.MenuSubtitle = "Custom Messages List";

                if (CannedMessages.listCustom.Count == 0)
                {
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("List is empty");
                    page.AddCategory("You can add custom messages in the settings menu.");
                }

                var cat2 = page.AddCategory("");
                foreach (var msg in CannedMessages.listCustom)
                {
                    cat2.AddButton(FitToButton(msg), "MTTS-Trans", $"Say: {msg}").OnPress += () =>
                    {
                        if (lastMsgSent < Time.time - 1 || MuteTTSMod.disableButtonPressTimeout.Value)
                        {
                            lastMsgSent = Time.time;
                            MuteTTSMod.Instance.GetVoice(msg);
                            //QuickMenuAPI.ShowAlertToast($"Speaking: {saying}", 2);
                        }
                        else
                            QuickMenuAPI.ShowAlertToast($"--- Message not sent --- <1 second since last message", 2);
                    };
                }
                page.OpenPage();
            }
            catch (System.Exception ex) { MelonLogger.Error($"Error when creating Cust Messages menu\n" + ex.ToString()); }
        }

        public static void OpenCustMsgManagement()
        {
            try
            {
                var page = (Page)pageCustMsgManagement;
                page.ClearChildren();
                page.MenuTitle = "Custom Messages Management";
                page.MenuSubtitle = "Change the order of messages or delete them.";

                if(CannedMessages.listCustom.Count == 0)
                {
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("List is empty");
                }

                for (int i = 0; i < CannedMessages.listCustom.Count; i++)
                {
                    var pos = i;
                    var msg = CannedMessages.listCustom[pos];
                    var catTemp = page.AddCategory($"{pos}: {WrapCatLine(msg)}");
                   
                    catTemp.AddButton("Move Up", "MTTS-Up", $"Move Up one Position").OnPress += () =>
                    {
                        if (pos > 0)
                        {
                            CannedMessages.listCustom.RemoveAt(pos);
                            CannedMessages.listCustom.Insert(pos - 1, msg);
                            OpenCustMsgManagement();
                            SaveLoad.SaveCustomList();
                        }
                    };
                    catTemp.AddButton("Move Down", "MTTS-Down", $"Move Down one Position").OnPress += () =>
                    {
                        if (pos < CannedMessages.listCustom.Count-1)
                        {
                            CannedMessages.listCustom.RemoveAt(pos);
                            CannedMessages.listCustom.Insert(pos + 1, msg);
                            OpenCustMsgManagement();
                            SaveLoad.SaveCustomList();
                        }
                    };
                    catTemp.AddButton("Move to Top/Bottom", "MTTS-UpDown", $"Moves to Top position, if at Top, move to Bottom").OnPress += () =>
                    {
                        if (pos != 0)
                        {
                            CannedMessages.listCustom.RemoveAt(pos);
                            CannedMessages.listCustom.Insert(0, msg);
                        }
                        else
                        {
                            CannedMessages.listCustom.RemoveAt(pos);
                            CannedMessages.listCustom.Add(msg);
                        }
                        OpenCustMsgManagement();
                        SaveLoad.SaveCustomList();
                    };
                    catTemp.AddButton("Delete", "MTTS-Delete", $"Deletes Message").OnPress += () =>
                    {
                        QuickMenuAPI.ShowConfirm("Confirm Delete", $"Remove the following message?<p><p><p>{msg}", () => {
                            CannedMessages.listCustom.RemoveAt(pos);
                            OpenCustMsgManagement();
                            SaveLoad.SaveCustomList();
                        }, () => { }, "Yes", "No");
                    };
                }
                page.OpenPage();
            }
            catch (System.Exception ex) { MelonLogger.Error($"Error when creating Cust Messages menu\n" + ex.ToString()); }
        }

        public static void OpenCustMsgAdd()
        {
            try
            {
                var page = (Page)pageCustMsgAdd;
                page.ClearChildren();
                page.MenuTitle = "Custom Messages Add";
                page.MenuSubtitle = "Add Custom Messages to list from history";

                if (MuteTTSMod.pastMessages.Count == 0)
                {
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("");
                    page.AddCategory("History is empty");
                }

                foreach (var msg in MuteTTSMod.pastMessages.Reverse<string>())
                {
                    var catTemp = page.AddCategory(WrapCatLine(msg));

                    catTemp.AddButton("Add to top of list", "MTTS-Up", $"Add to custom list at the top position").OnPress += () =>
                    {
                        CannedMessages.listCustom.Insert(0, msg);
                        SaveLoad.SaveCustomList();
                        QuickMenuAPI.ShowAlertToast($"Added: {msg}", 3);
                    };
                    catTemp.AddButton("Add to bottom of list", "MTTS-Down", $"Add to custom list at the last position").OnPress += () =>
                    {
                        CannedMessages.listCustom.Add(msg);
                        SaveLoad.SaveCustomList();
                        QuickMenuAPI.ShowAlertToast($"Added: {msg}", 3);
                    };
                }
                page.OpenPage();
            }
            catch (System.Exception ex) { MelonLogger.Error($"Error when creating Cust Messages Add menu\n" + ex.ToString()); }
        }    

        public static string FitToButton(string value)
        {
            return (value.Length > 32) ? value.Substring(0, 21) + "..." : value;
        }

        public static string WrapCatLine(string inputString)
        {
            int charsPerLine = 30;
            StringBuilder outputBuilder = new StringBuilder();
            for (int i = 0; i < inputString.Length; i += charsPerLine)
            {
                outputBuilder.Append(inputString.Substring(i, Math.Min(charsPerLine, inputString.Length - i)));
                outputBuilder.Append("<p>");
            }
            return outputBuilder.ToString();
        }
    }
}
