## Back again, thanks to BBC! (Better Better Communications)

## Now with BTKUI Support! 
    
![image](https://user-images.githubusercontent.com/81605232/235373398-e4828789-699e-4b81-b4c7-4fa7caf91b0d.png)

    
The goal of this update was to move the keyboard to a more accessible menu and provide more features, such as,
* Message History 
* Saved Custom Messages 
* Canned messages (fully customizable)
* Settings menu for adjusting config easily 
* Keyboard hotkey for freeform keyboard input (Default: Right Control)
* Parameter support when mod is speaking - "MuteTTSplaying", "MuteTTSprocessing", "MuteTTSplaying"

The original keyboard button is still available in the big menu Settings -> Implementation or the Shortcuts of the Home menu       
![image](https://github.com/Nirv-git/CVR-Mods/assets/81605232/0804ff03-080d-46c5-a24f-0cef3b5aca60)![image](https://github.com/Nirv-git/CVR-Mods/assets/81605232/4ddf7a4e-3476-4da9-8cf4-69b0b37442a3)

### Customizing messages

All of the messages are customizable, once you launch the game with this mod installed several text files starting with `Canned_` will be generated in the following folder `ChilloutVR\UserData\MuteTTS`. These text files can be edited when the game is closed and on launch, those are the messages that will populate the categories.
> You can disable individual categories with the "Enable/Disable Specific" option in the BTKUI settings menu.

*This includes the 'Quick Messages' buttons! You can change, or add more than four of them by editing the `Quick_Messages.txt` file*

You can also populate a list of Custom/Favorite messages using the 'Custom Messages' category from an in game UI.  It is a tad clunky, but it works by using the message history, which you can then copy over to the saved Custom Messages list. 
You can alternatively, directly edit the `Custom_Messages.txt` file.    

>You can edit these files while the game is running and use the `Reload file lists` button at the bottom of the settings menu in BTKUI.   
 
![image](https://user-images.githubusercontent.com/81605232/235373499-636fe814-0f30-4fda-b4a3-99f2b3c799e6.png)
### CustomLists
The mod can also load your own custom messages lists, by default these will show up under the normal `Message Categories` in the `Custom Categories` section. You can optionally merge these into the above category, with options in settings. 
Custom lists are stored in the folder `ChilloutVR\UserData\MuteTTS\CustomLists` and are simply one message per line, just like the Canned Messages files.     
    
*If you want you can completely disable the built in Canned Messages and just use your own lists.*
![image](https://user-images.githubusercontent.com/81605232/236359905-3cbc921d-88e2-49a9-9ecc-af526d444353.png)


### Parameter Driving

The mod will attempt to drive 3 parameters if they exist on your avatar (Can be disabled in MelonPrefs)   
 * "MuteTTSkeyboard" - True/1 - When keyboard is opened, times out in 15 seconds by default
 * "MuteTTSprocessing" - True/1 - Between submitting a message and speaking
 * "MuteTTSplaying" - True/1 - While mod is speaking



### Settings
| MelonPref Name | In BTKUI Settings | Default Value | Desc | Extra Details |
|--|--|--|--|--|
|useVoiceSetting| Yes |-1|Text to speech voice to use, see log at game start for list| Can also set the voice with the settings menu in BTKUI |
|blockMic| Yes |false|CVR will no longer be able to send your Voice. Only TTS is available| |
|unMuteWhileSpeaking| |true|Unmute mic when trying to use TTS| MuteTTS needs your mic to be unmuted when speaking. If you want to make sure your real mic isn't heard, use the blockMic setting. |
|TTSVolume| Yes |1f|Value between 0 and 1| |
|TTSSpeed| Yes |1f|Speed of voice| |
|useHotkey| Yes |true|Pressing the hotkey will open the keyboard.| |
|hotkey|No|RightControl|See here for a list of keycodes https://docs.unity3d.com/ScriptReference/KeyCode.html| |
|parmDriving| Yes |true|Enable driving of MuteTTS parameters on avatars. (MuteTTSkeyboard, MuteTTSprocessing, MuteTTSplaying)| |
|parmkeyboardValue|No|15 |Timeout for MuteTTSkeyboard param after opening keyboard| |
|TTSCrunch| Yes |0|TTS Crunch 0-24 (0 is off)| Crunch lowers the sample rate of audio, making it sound 'crunchy'. Levels above 4-6 really aren't great for understandability |
|processingTone_en| Yes |false|Play processing tone| Plays a sound between submitting a message and the audio playing |
|processingTone_complete|Yes|false|Wait for tone to complete before playing voice||
|processingTone_Volume| Yes |.5f|Value between 0 and 1.5| |
|processingTone_Crunch| Yes |0|Crunch Tone 0-24 (0 is off)| Crunch lowers the sample rate of audio, making it sound 'crunchy'. Levels above 4-6 really aren't great for understandability |
|BTKUILib_en|No|true|BTKUILib Support (Requires Restart)| |
|useMiscPage|No|false|BTKUI - Use 'Misc' page instead of custom page. (Restart req)| |
|msgHistory| Yes |true|Keep message history for current session - Shows in BTKUI| |
|loadCannedLists|Yes|true|Create normal canned messages buttons|Populates buttons for the "Message Categories" section|
|enabledCannedLists|Yes*|-1|Mask for what Canned Categories are Enabled|This can disable/enable individual categories from the "Message Categories" section. This is a mask and is intended to be edited through the in game settings menu in BTKUI|
|loadCustomLists|Yes|true|Attempt to load any custom lists from the folder Advanced/CustomLists|See the 'CustomLists' section of this ReadMe|
|mergeCustomAndCannedLists|Yes|false|Merge Custom Lists into Canned Category||
|disableCatNames|Yes|false|Disable Category names for QuickMsg, Canned, CustomLists||
|disableButtonPressTimeout|No|false|Disables the 1 second timeout between sending messages. This can cause issues if you spam them.|The timeout exists for a reason, disable at your own risk|
||||||


## How to add extra voices 
MuteTTS uses Window's built in Text to Speech, you can install more by opening your settings menu and under 'Manage Voices' click the 'Add voices' option. *You will need to restart CVR to update the voices list in game.*
![image](https://user-images.githubusercontent.com/81605232/235373329-8fe298d2-8745-4671-bac5-fac4fad44047.png) 

## Advanced Folder
### Processing Tone
To create a custom processing tone you will need to use the `MuteTTSConverter.exe` utility.       
It expects a file saved as a 8-bit PCM at **48,000 Hz**. If using Audacity the specific export option is under `Export Selected Audio > Type: Other uncompressed files > WAV (Microsoft) Unsigned 8-bit PCM`   
_I recommend Normalizing Volume to -20 db._   
Use by running from CMD with the .wav you want to convert as the first argument. 
`MuteTTSConverter.exe "Beeping Signal.wav"`   
And it will generate a `ProcessingTone.txt` file in the same directory.  Place this file in `ChilloutVR\UserData\MuteTTS\Advanced\Tone`


### Other changes from the base version
* Audio buffer gets cleared with every message, prevents repeat messages if invalid input is sent.
* MuteTTS now finds all TTS provides on Windows
* Auto unmute mic when TTS is speaking
* Alerts when trying to speak normally when Block mic is on
* Added Spaghetti to the code
