using System.Collections.Generic;

namespace MuteTTS
{
    class CannedMessages
    {
        public static List<string> listCustom = new List<string>();
        public static List<string> listQuick = new List<string>()
        {"Thank you!", "One moment", "I'm confused", "Can you repeat that?" };

        public static List<string> dictGreetings = new List<string>()
        {
            "Excuse me",
            "Hello",
            "Greetings",
            "Good morning",
            "Good afternoon",
            "Good evening",
            "Nice to meet you",
            "Hi everyone",
            "How's it going?",
            "Good to see you",
            "Welcome back",
            "Goodbye",
            "See you later",
            "Have a good one",
            "Take care!",
            "See you soon!",
            "Have a great day!",
            "I have to go.",
            "It was nice talking to you!",
            "Good night",
        };

        public static List<string> dictFeelings = new List<string>()
        {
            "I'm happy",
            "I'm sad",
            "I'm afraid",
            "I'm excited",
            "I'm anxious",
            "I'm nervous",
            "I'm frustrated",
            "I'm angry",
            "I'm overwhelmed",
            "I'm tired",
            "I'm bored",
            "I'm confused",
            "I'm curious",
            "I'm grateful",
            "I'm proud",
            "I'm relieved",
            "I'm content",
            "I'm optimistic",
            "I'm pessimistic",
            "I'm peaceful",
            "I'm guilty",
            "I'm ashamed",
            "I'm lonely",
            "I'm loved",
            "I'm thankful",
            //
            "Happy",
            "Sad",
            "Afraid",
            "Excited",
            "Anxious",
            "Nervous",
            "Frustrated",
            "Angry",
            "Overwhelmed",
            "Tired",
            "Bored",
            "Confused",
            "Curious",
            "Grateful",
            "Proud",
            "Relieved",
            "Content",
            "Optimistic",
            "Pessimistic",
            "Peaceful",
            "Guilty",
            "Ashamed",
            "Lonely",
            "Love",
            "Thankful"
        };

        public static List<string> dictRequestsResponse = new List<string>()
        {
            "Yes",
            "No",
            "Maybe",
            "Maybe later",
            "Probably",
            "Why?",
            "Thank you",
            "Do not",
            "Stop",
            "I don't know",
            "I'm not sure",
            "I'm confused...",
            "Sorry, I didn't understand.",
            "Could you please slow down?",
            "Can you repeat that?",
            "Continue",
            "Go on...",
            //
            "Query",
            "Can you share that with me?",
            "Can you please pass me that?",
            "Can I see?",
            "Can you help me?",
            "Can you spare a moment?",
            "Would you be able to help me with this?",
        };



        public static List<string> dictGratitudeCompliments = new List<string>()
        {
            "Thank you",
            "Thank you so much",
            "I appreciate your help",
            "You've been so kind to me",
            "You're a lifesaver",
            "Your generosity is greatly appreciated",
            "Thank you for being there for me",
            "Your kindness means a lot to me",
            "Thank you for your advice",
            "You're the best",
            "You've been so patient with me",
            "You're amazing",
            "You're a good friend",
            "I'm so grateful to have you in my life",
            //
            "You are cute",
            "Very cute",
            "Cutie",
            "Nerd",
            "You look great today.",
            "Your outfit is really stylish.",
            "You have a great sense of humor.",
            "Your smile is contagious.",
            "You're an amazing friend.",
            "You have a beautiful voice.",
            "You're so talented at what you do.",
            "You have a great energy about you.",
            "You're so kind to everyone you meet.",
            "Your creativity inspires me.",
            "You have a heart of gold.",
            "You always know how to make me smile.",
            "You're one of the most genuine people I know.",
            "Your work is truly impressive.",
            "You have such a positive outlook on life.",
            "You're one of a kind.",
            "Your intelligence always impresses me.",
            "You have an infectious enthusiasm.",
            "You make the world a better place.",
        };

        public static List<string> dictSocialVR = new List<string>()
        {
            "Loading, one moment",
            "Avatars are loading, one moment",
            "Are you muted?",
            "Do you want to cuddle?",
            "Do you want to go to a different instance?",
            "I will make a new instance and invite you.",
            "Do you want to go world hopping?",
            "I'm having fun exploring this world with you!",
            "Have you tried any VR games lately?",
            "Do you have any VR games you'd recommend?",
            "What's your favorite thing about Social VR?",
            "I've met so many interesting people in VR!",
            "It's great to see you in VR!",
            "This VR environment is so immersive, isn't it?",
            "Enterprise Resource Planning?",
            "This is a public world",
            "Drink?",
            "Hydrate",
        };
        public static List<string> dictDirections = new List<string>()
        {
            "Up",
            "Down",
            "Left",
            "Right",
            "Straight ahead",
            "Behind you",
            "Turn around",
            "Go forward",
            "Go back",
            "Upstairs",
            "Downstairs",
            "Through the door",
            "To your left",
            "To your right",
        };

        public static List<string> dictMisc = new List<string>()
        {
            "Hmmmmm",
            "A F K",
            "Be Right Back",
            "I am using Text to Speech.",
            "Sorry, that was a mistake.",
            "Sorry",
            "Typo",
            "My apologies.",
            "Awesome job!",
            "That's impressive!",
            "I'm really enjoying this!",
            "No worries, it's all good.",
            "Congratulations!",
            "Good luck with that!",
            "Hahahaha",
            //
            "! Exclamation Point",
            "? Question Mark",
            "~ Tilde",
            //
            ":)",
            ":(",
            ";)",
            ";(",
            ":D",
            ":o",
            ":|",
            ":/",
            ":'(",
            ":*",
            "<3",
            "^_^",
            "-_-",
            ":S",
            ";D",

        };
        public static List<string> dictSmallTalk = new List<string>()
        {
            "Nice weather today, isn't it?",
            "Have you been here before?",
            "What brings you here?",
            "How do you like this place?",
            "How's your day going so far?",
            "Do you have any plans for the weekend?",
            "I like your outfit!",
            "What do you do for work?",
            "Do you have any pets?",
            "Have you seen any good movies lately?",
            "Have you heard about any upcoming events around here?",
        };

        //Beep beep beep
        public static string cannedProcessing = "gICAf39/f39/f39/f4CAgICAgIB/f39/f39/f3+AgICAgH9/f39/f39/f39/f39/f39/f39/f4CAgICAgICAf39/f39/f39/f4CAgIB/gIB/gH+AgICAgIB/f39/f39/gICAgICAgH9/f39/f39/f39/gICAgIB/f39/f39/gICAgICAgH9/f3+AgICAgICAf39/f39/gICAgICAgICAgH+Af4CAgICAgICAgH9/f39/f39/f4CAgICAgIB/f39/f39/f4CAgICAgIB/f39/f39/f39/f39/f39/f39/f39/f4CAgICAf39/f39/f3+AgICAgICAgIB/f39/f39/f39/gICAgICAgICAgICAgICAf39/f39/f39/f3+AgICAf39/f35+fn9/gIGBgYGBgH9/fn5+f4CBgoODg4OCgX9+fXx8fH1+fn9/gIB/f39/f39/gICBgYGBgIB/fn9/gIGCg4ODgYB/fn19fX5/gICAgH9+fHt6ent8foCChISEhIOCgoGBgYGBgoKCgoGBf359fHx8fX+BgoOCgX99enh2dnZ3en2Ag4aIiYmHhYJ/fXt6e3x/goWIioqJhoN/e3h2dXZ4enx9f39/f39/f39/gICBg4SGh4eHhoSCgH9+fX5/gIKDhISDgX98end1dXV2eXyAg4aHiIaEgHx4dXR0d3p/g4aJiomIhoWDgYB/f35+f39/gIB/fn17enp6e3x9fn9/f39+fHt6ent8foCDhoiJiomIhYJ/fHl4eHp9gISHiYmIhYF+enh2dnd4ent9fn+AgICAgICAgYGChIWGhoaFhIKBgICAgYKDhIWFhIKAfnx5d3Z1dnd5fH6Bg4WFg4F9end2dnd6foKFiImJiYiGhYOCgYCAf39/f39/f358e3l4eHh5ent9fn5+fn18e3t7fH2AgoWIiouLioiFgn98enp6fYCEh4qKiYaCfnp3dXR1dnh6fH5/gYGCgYGAf39/gIGDhYaHiIeGhIOBgICAgIKDg4SDgoF+e3l2dXR1dnl8f4KEhYWDf3x4dnV2eHyAhIiKi4uLiYeEgoB/fn19fn+AgIB/fnx6eHd3d3h6fH1/f39/fXx7e3t8foGEhomLi4uJh4SAfXp5enx/g4eJi4qIhH97d3VzdHV3eXt9f4GCgoKBgH9+fn+AgoSGiIiIh4WDgoCAgICBg4SEhIOBf3x5d3V0dXZ4e36ChIaFg4B8eXZ0dXd7f4OHiouLiomGhIKAf359fX5/f4CAgH58enh3dnd3eXt9fn9/fn18enp6e31/g4aIiouLioeEgX17eXp8f4OHioyLiYWBfHh1dHR1dnl7fX6AgIGBgH9/fn5/gIKFh4iIiIeGhIKBgICBg4SFhYWEgn98eXd1dHR1eHp9gYOFhYOAfHl2dHV3en6Dh4qLi4qJh4WDgYB/fn5/f4CAgH9+fHp4d3Z2d3l6fH1+f359fHt6ent9f4KFiIqLi4qIhYJ/fHp6fH+Dh4qLi4mFgX15dnR0dXd5e31+f4CAgIB/f35+f4CChIaIiIiIhoWDgoGBgYKDhIWFhIOAfXp4dnV0dXd6fYCDhISDgH15dnR0dnl9goaJi4uKiYeFg4KAf39/f3+AgIGAf317eXd2dnd4enx9fn5+fXx6enp6fH6BhIeJi4uKiIWCf3x7e3x/goaJi4uKhoJ+eXZ1dHV2eHp8fn9/gIB/f35+fn6AgoSGh4iJiIeFhIKBgYGCg4SFhYSDgX57eHZ1dXV3eXx/goSEg4F9eXZ0dHV5fYGFiIqLiomHhYSCgYB/f4CAgIGBgH99e3l3dnZ2d3l7fH1+fn18e3p6enx+gYSHiYqLioiGg4B9e3t8foKGiYuMioeDfnp2dHR0dnh6fH1+f39/f35+fX5+f4GEhoiJiYmHhoSDgYGBgoOEhYWFg4F+e3h2dXR1d3l8f4GDhIOBfXp2dHN1eHyAhYiKi4uKiIaEgoGAf39/gICBgYF/fnt5d3Z2dnd5e3x9fn59fHt6eXp7foCDhomKi4qJh4SBfnx7fH6ChYmLjIuIhH97d3V0dHZ3eXt9fn9/f39/fn59fn+Bg4WHiImIh4aEgoGBgYKDhIWFhYSCf3x5d3V0dXZ4e36Ag4ODgX56d3RzdHd7f4SHiouLioiGhIOBgYCAgICBgYGBgH58enh3dnZ3eXt8fX5+fn17enp6e32Ag4aIiouLioiFgn99fHx+gYWIi4yLiYWAfHh1dHR1d3l7fX5/gIB/f35+fX5/gIKFh4iJiYiHhYOCgYGCg4SFhYWEgn98eXd1dHR2eHp9gIKDg4J/e3d1dHR2en6Dh4mLi4qIhoSDgYCAf3+AgIGBgYB/fXp4d3Z2d3h6fH1+fn59fHt6ent9gIKFiIqLiomHhYJ/fXt8fYCEh4qMi4mFgXx5dnR0dXd5e3x+f3+Af39+fn19foCChIaIiYmIh4WDgoGBgYKDhIWFhIKAfXp3dXR0dXd6fYCChISCf3x4dXR0dnl+goaJiouKiIeFg4GAgH9/f4CBgYGAf317eXd2dnd4ent9fn5+fXx7enp7fX+ChYiKi4uKiIWCf317e32Ag4eKjIyKhoJ9eXZ0dHV2eHp8fn9/gH9/fn5+fn6AgoSGiImJiIeFg4KBgYGCg4SFhYSCgH16eHZ0dHV3eXx/goOEg4B9eXZ0dHV5fYGFiIqLiomHhYOCgYCAf4CAgYGBgH99e3l3dnZ2eHp7fX5/fn59e3t6e31/goSHiYuLiomGg4B9fHt8f4KGiYuMioeDfnp3dXR1dnh6fH5/f4CAf39+fn5+gIKEhoiJiYiHhYSCgYCBgYOEhYWEg4F+e3h2dXR1d3l8f4KDhIOBfXp2dHR1eHyAhYiKi4qJh4WDgoGAf3+AgICBgYB/fXt5d3Z2dnh5e31+f39+fXx7ent8foGEh4mKi4qJh4SAfnx7fH6BhYmLi4qHg397d3V0dHZ3enx9fn9/f39+fn19fn+Bg4WHiImIh4aEgoGAgIGCg4SFhIOBfnt5dnV0dXZ4e36Bg4SDgX56d3R0dXd7gISHiouLioiGhIKBgH9/f4CBgYGBgH58enh2dnZ3eXt8fn5+fn18e3p7fH6BhIeJi4uLioeEgX58e3x+gYWIi4yLiISAe3h1dHR1d3l7fX5/gIB/f35+fn5/gYOFh4iJiYiGhIOBgYGBgoOEhYWDgn98eXd1dHR2eHt+gYOEhIJ/e3h1dHR3e3+Dh4qLi4qIhoSCgYCAf4CAgYGBgYB+fHp4dnZ2d3l6fH5+f359fHt6ent9gIOGiYqLi4qIhYJ/fHt7fYCEiIqMi4mFgXx4dXR0dXd5e31+f4CAf39+fn1+f4GDhYeIiYmIhoSDgYGAgYKDhIWFhIJ/fXp3dXR0dXd6fYCDhISCf3x4dXR0dnp+g4aJi4uKiYeFg4GAgH+AgICBgYGAf316eHd2dnd4enx9fn9+fXx7enp7fX+ChYiKi4uKiIWCf317e32Ag4eKjIyKhoF9eXV0c3R2eHt9fn+AgH9/fn59fn6AgoSHiImJiIeFg4KBgYGCg4SFhYSCgH16d3V0dHV3en2AgoSEg4B8eHVzdHV5fYKGiYuLi4mHhYOBgH9/f4CAgYGBgH99e3h3dnZ3eHp8fX5/fn18e3p6e3x/goWIiouLioiGg399e3t8f4OHioyMioaCfXl2dHR1dnh7fX5/gIB/f35+fX1+gIKEhoiJiYiHhYOCgYCBgoOEhYWEg4B9end1dHR1d3l8f4KEhIOAfHl1dHN1eH2BhYmLi4qJh4WDgYB/f3+AgIGBgYF/fXt5d3Z2d3h6fH1+f359fHt6ent8f4KFiIqLjIuJhoOAfXt7fH+ChoqMjIqHg356dnV0dXZ4e31+f4CAgH9+fn19foCChIaIiYmIh4WDgoGAgYKDhIWFhYOBfnt4dXR0dXZ5fH+Cg4SDgH15dnRzdXh8gYWIiouLiYeFg4GAf39/gICBgYGBf317eXd2dnZ4eXt9fn9+fXx7enp6fH6BhIeKi4yLiYaDgH17e3x+goaJi4yLiIN/end0dHR2eHp8fn+AgIB/fn59fX5/gYOGh4mJiIeFhIKBgIGCg4SFhYWEgX57eHZ0dHR2eHt+gYOEg4F+enZ0c3R3e4CEiIqLi4qIhYOCgIB/f4CAgYGCgYB+fHl4dnZ2eHl7fX5/f359e3p6ent9gIOHiYuLi4mHhIF+fHt7foGFiYuMi4iEgHt3dXR0dnh6fH5/gICAf35+fX1+f4GDhYeIiYiHhoSCgYCAgYKEhYWFhIJ/fHl2dXR0dnh7foGDhIOBfnp3dHN0dnp/g4eKi4uKiIaEgoCAf39/gIGBgYGAfnx6eHZ2dnd5e3x+f39+fXt6enp7fYCDhomKi4uKh4WBfnx7e32AhIiLjIuJhYB8eHV0dHV3eXt9f3+AgH9/fn19fn+Ag4WHiImJiIaEg4GAgIGChIWFhYSCgH16d3V0dHV4en2Ag4SEgn97eHVzdHZ6foOHiouLioiGhIKBgH9/gICBgYGBgH98enh3dnZ3eHp8fn5/fn18e3p6e31/goWIiouLioiFgn98e3t9gISIi4yMioaCfXl2dHR1d3l7fX9/gIB/f35+fX5/gIKFh4iJiYiGhYOBgYCBgoOFhYWEg4B9end1dHR1d3p9gIKEhIKAfHh1c3N1eX2ChomLi4qJh4WDgYCAf4CAgYGCgYB/fXt4d3Z2d3h6fH1+f359fHt6enp8foGFh4qLi4qIhoJ/fXt7fH+Dh4qMjIqHgn55dnR0dXZ4enx+f39/f39+fX19foCChIaIiYmIh4WDgYGAgYKDhIWFhYOBfnt4dnR0dXd5fH+Cg4SDgH15dnRzdXh8gYWIiouLiYeFg4GAgH9/gICBgoKBf317eXd2dnd4ent9fn9+fXx7enp6fH6BhIeJi4uLiYaDgH17e3x+goaJjIyLiIN/end1dHR2eHp8fn+AgH9/fn59fX5/gYSGiImJiIeFhIKBgYGCg4SFhYWEgX97eHZ0dHV2eXx/gYOEg4F9enZ0c3V3e4CEiIqLi4qIhYOCgYCAgICBgYKCgYB+fHl3dnZ2d3l7fX5+fn58e3p5ent9gIOGiYuLi4mHhIB+e3t7foGFiYuMi4iEf3t3dXR0dXd6fH1/f39/f359fX1+f4GDhYeIiYiHhoSCgYGBgoOEhYWFhIJ/fHl2dXR0dnh7foGDhIOBfnp3dHN0d3p/g4eKi4uKiIaEgoGAgICAgIGBgoGAfnx6eHZ2dnd5e3x+fn5+fXt6enp7fYCDhomLi4uKh4SBfnx7e32AhIiLjIuJhYF8eHV0dHV3eXt9fn9/f39+fn19fX+Ag4WHiImJiIaEg4GBgYGDhIWFhYSCf3x5d3V0dHV4en2Ag4SEgn97eHVzdHZ6foOGiYuLioiGhIKBgICAgICBgYKBgH99enh3dnZ3eXp8fX5+fn17enp6e31/goWIiouLioiFgn98e3t9gIOHioyMiYaBfXl2dHR1d3l7fX5/f39/f359fX5+gIKFh4iJiYiGhYOBgYGBgoSFhYWEgoB9end1dHR1d3p9gIKEhIKAfHh1c3R1eX2ChomKi4qIh4SDgYCAf4CAgYGBgYB/fXp4d3Z2d3h6fH1+fn59fHt6enp8f4KFiIqLi4qIhYJ/fHt7fH+DhoqLjIqHgn55dnR0dXZ5e3x+f39/f39+fX19foCChIaIiYmIh4WDgoGAgYKDhIWFhIOAfXp4dXR0dXd5fH+ChISDgH15dnR0dXh8gYWIiouKiYeFg4GAgH+AgICBgYGBf317eXd2dnd4ent9fn5+fXx7enp6fH6BhIeKi4uLiYaDgH17e3x+goaJi4yKh4N/end1dHV2eHp8fn9/gH9/fn59fX5/gYSGh4mJiIeFg4KBgIGCg4SFhYWDgX57eHZ0dHV2eXx/gYOEg4F+enZ0dHV4e4CEiIqLi4mHhYOCgIB/f4CAgYGBgX9+e3l3dnZ3eHl7fX5/f359e3p6enx+gYSHiYuLi4mHhIB9e3t7foGFiYuMi4iEf3t3dXR0dnh6fH5/gICAf35+fX1+f4GDhYeIiYiHhYSCgYCBgoOEhYWFhIJ/fHl2dXR0dnh7foGDhISCf3t3dXR0d3t/hIeKi4uKiIaEgoGAf3+AgIGBgoGAfnx6eHd2d3h5e31+f39+fXt6enp7fYCDhomLi4uKh4SBfnx7e32AhIiLjIuJhYB8eHV0dHV3enx9f3+AgH9/fn19fn+Bg4WHiImIh4aEgoGAgIGChIWFhYSCf3x5dnV0dHV3en2Ag4SEgn97eHVzdHZ6foKGiYuLioiGhIKBgH9/f4CBgYGBgH58enh3dnZ3eXp8fn5+fn17enp6e31/goWIiouLioiFgn98e3t9gISHioyLiYaBfXl2dHR1d3l7fX5/gIB/f35+fX5/gIKFh4iJiYiGhIOBgYCBgoOFhYWEg4B9end1dHR1d3p9gIKEhIOAfHh1dHR2eX2ChomLi4qJhoSDgYCAf3+AgIGBgYB/fXp4d3Z2d3h6fH1+f359fHp6enp8f4KFiIqLi4qIhoJ/fXt7fH+Dh4qMjIqHgn55dnR0dXZ5e31+f3+Af39+fn1+foCChIaIiYmIh4WDgoGBgYKDhYWFhYOBfnt4dXR0dXd5fH+ChISDgX15dnR0dXh8gYWIiouKiYeFg4GAgH9/gICBgYGAf317eXd2dnd4enx9fn9+fXx7enp6fH6BhIeKi4yLiYaDgH17e3x+goaJjIyLiIN/end1dHV2eHp8fn+AgIB/fn59fn6AgoSGiImJiIeFg4KBgYGCg4SFhoWDgX57eHZ0dHV2eXx/gYSEg4F+enZ0c3V4fICEiIqLi4mHhYOCgYCAgICAgYGBgX9+e3l3dnZ3eHl7fX5/fn58e3p5ent9gIOGiYuLi4mHhIB9e3t7foGFiIuMi4iEf3t3dXR0dXd6fH1+f39/f35+fX1+f4GDhYeIiYiHhYOCgYCAgYOEhYWFhIJ/fHl2dHR0dnh7foGDhISCfnt3dHN0d3t/hIeKi4uKiIaEgoGAf3+AgIGBgYGAfnx5eHZ2dnd5e3x+fn5+fHt6eXp7fYCDhomKi4uKh4SBfnx7e32AhIiLjIuJhYB8eHV0dHV3eXt9fn9/f39+fn19fn+Bg4WHiImIh4aEgoGAgIGChIWFhYSCf3x5d3V0dHV3en2Ag4SEgn97eHVzdHZ6foOHiYuLioiGhIKBgIB/gICBgYGBgH58enh3dnd4eXt8fn5/fn18e3p6e31/goWIiouLiYiFgn99fHx9gIOGiYqKiIWBfXp3dnZ3eHp8fX9/gIB/f35+fn5/gIKEhYeHh4aFg4KBgICBgYKDhISDgoB+e3l3d3d3eXt9gIKDg4KAfXt4d3d5e36BhIaIiIeGhIOBgIB/f4CAgIGBgYB/fnx7enp6ent8fX5/f39+fX18fH1+f4GDhYaHh4aFg4F/fn19foCChIaGhoWDgH57enl5ent8fn+AgICAgH9/fn5+f4CBgoOEhISDg4KBgH9/gICBgYKCgYB/fnx7enp6ent9fn+BgYGAf358e3p7fH1/gYOEhISEg4KBgH9/f39/f4CAgICAf39+fX19fX1+fn9/f39/f39/f39/f4CBgoKDg4KCgYCAf35+fn+AgIGCgoKBgYB+fn19fX1+fn+AgICAgICAf39/f39/f4CAgICAgICAgICAgICAgIB/f39/f39+fn5+fn5+f39/gICAgIB/f39/f39/f4CAgIGBgYGAgIB/f39/f39/f3+AgICAgICAgICAgH9/f39/f3+AgICAgICAgICAgIGBgYCAgIB/f39/f3+AgICAgIB/f39+fn5+f39/f4CAgICAgICAgH9/f39/f39/f39/f39/f39/f39/f4CAgIB/f39/f39/f39/f4CAgICAgIB/f39/f39/gICAgYGBgICAgH9/f39/f4CAgICAgICAgICAgICAgICAgICAgH9/f39/f3+AgICAgICAgICAf39/f39/f4CAgIGBgYCAgH9/f39/f39/gICAgICAgH9/f39/f39/f4CAgICAgH9/f39/f3+AgICAgIB/f39/f39/f39/gICAgICAf39/f39/f39/gICAgICAgICAgH9/f39/f3+AgICAgICAgICAgIB/f39/f39/f3+AgICAgICAgICAgICAf39/f39/f3+AgICAgICAf39/f39/f39/gICAgIB/f39/f39/f39/f39/f39/f39/f39/f4CAgICAgH9/f39/f39/gICAgICAgICAgIB/f39/f39/gICAgICAgIB/f39/f39/gICAgICAgICAgICAgICAgICAgICAgIB/f39/f39/gICAgICAgH9/f39/f39/gICAgICAgICAf39/f3+AgICAgICAgIB/f39/f39/f39/gICAgH9/f39/f39/f4CAgICAgICAf39/f39/f4CAgICAgICAf39/f39/f3+AgICAgICAgIB/f4CAgICAgICAgICAf39/f3+AgICAgICAgIB/f39/f39/f39/gICAgICAf39/f39/f3+AgICAgICAgH9/f39/f3+AgICAgIB/f39/f39/f3+AgICAgICAf39/f39/f3+AgICAgICAgH9/f39/f3+AgICAgICAgH9/f39/f39/f4CAgICAf39/f39/f3+AgICAgICAgH9/f39/f39/gICAgICAgH9/f39/f39/gICAgICAgH9/f39/f39/gICAgICAgIB/f39/f39/gICAgICAgH9/f39/f39/f4CAgICAgH9/f39/f39/f4CAgICAgIB/f39/f39/gICAgICAgH9/f39/f39/f4CAgICAgH9/f39/f39/gICAgICAgICAf39/f39/f4CAgICAgIB/f39/f39/f3+AgICAgH9/f39/f39/f4CAgICAgICAf39/f39/gICAgICAgICAf39/f39/f3+AgICAgICAf39/f39/f4CAgICAgICAgH9/f39/gICAgICAgIB/gH+Af4B/gIB/gH+AgH+Af4B/gICAf4B/gIB/gH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gIB/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4CAf4CAf4CAf4B/gIB/gH+AgH+AgH+Af3+Af4B/gH+Af4CAf4B/gH+Af4B/gICAf4B/gIB/gH9/gH+AgH+Af4CAf4CAf4CAf4B/gIB/gICAf4B/gIB/gIB/gH+Af4B/gH+Af4B/gH+Af4CAgH+Af4B/gH9/gH+Af3+Af4B/gH+Af4CAf4B/gH+Af4B/gIB/gH9/gH+AgH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gH+Af4B/gH+AgH+Af4CAgH+Af4B/gH+AgH+Af4CAf4B/gIB/gH+AgH+Af4CAf4B/gIB/gH+AgH+Af4B/gICAgH+AgICAgICAgH+AgH+Af4CAf4B/gIB/gH+AgH+Af4B/gH+Af3+Af4B/gICAgIB/gIB/gH+Af4CAf4B/gIB/gH+Af4CAf4B/gH+AgH+Af4B/gH+Af4CAf4B/gH+Af4B/gIB/gH+Af4B/gIB/gH+AgH+Af4CAf4CAf4B/f4B/gH+AgIB/gICAgICAgH+Af4B/gH9/gH9/gH+Af4B/gH+Af4B/gH9/gH+Af4B/gH+Af4B/gH+AgICAgIB/gH+Af4CAgIB/gIB/gIB/gH+Af4B/gIB/gIB/gH+Af4CAf4B/gH+Af4B/gIB/gIB/gH+AgIB/gH+Af4CAgICAf4B/gH+Af4B/gICAf4B/gH+Af4CAgH+Af4B/gICAgICAf4B/gH+Af3+Af4B/gH+AgH+Af4B/gH+Af4CAgH+Af4B/gICAgICAgIB/gH+Af4B/gIB/gH+Af4CAf4B/gIB/gH+AgH+Af4CAf4CAf4B/gICAgH9/gIB/gH+Af4B/gH+AgH+Af4B/gH9/gH+AgH+AgH+Af4B/gICAgH+AgICAgIB/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gIB/gH+AgIB/gH+Af4B/gH+Af4B/gH+Af4CAf4CAf4B/gH+AgICAgICAf4B/gIB/gIB/gH+Af4CAgH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gIB/gH+AgH+Af4CAf4B/gIB/gH+Af4B/gIB/gH+Af4B/gH+AgH+Af4CAf4B/gH+AgIB/gH+AgIB/gH+Af4B/gIB/gH+Af4B/gIB/gIB/gH+Af4B/gIB/gH+AgH+Af4B/gH+Af4CAf4B/gH+AgH+Af4CAf4B/gH+Af4CAgICAf4B/gH+Af4CAf4B/gH+Af4B/gIB/gH+Af4CAf4B/gH+Af4CAf4B/gIB/gH+Af4CAf4B/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gH+AgH+AgH+Af4B/gH+Af4B/gH+Af4CAf4B/gH+Af4CAf4B/gH+Af4B/gH+Af4CAf4CAgICAf4B/gIB/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gICAgIB/gIB/gH+Af4B/gH+Af4B/gH+Af4B/gH+AgH+Af3+Af4B/gH+Af4B/gIB/gIB/gIB/gH+Af4B/gH+Af4CAf4B/gIB/gH+AgH+AgH+Af4CAgIB/gH+Af4B/gIB/gH+Af4B/gICAf4B/gIB/gICAgICAgH+Af4B/f4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+Af4CAf4CAf4B/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gIB/gH+AgH+Af4B/gH9/gH+Af4CAgIB/gH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gICAgICAf4B/gH+Af4CAgIB/gH+Af4CAgICAf4B/gIB/gIB/gH+Af4B/gH+Af4B/gIB/gICAgH+AgH+Af4CAf4B/gH+Af4CAf4B/gH+Af4B/gH+AgH+AgH+AgH+Af4B/gICAf4B/gH+AgH+Af4CAf4B/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gH+AgICAgIB/gH+Af4B/gH+AgICAgIB/gH+Af4B/gH+Af4B/gH+Af4CAgIB/gH+Af4B/gIB/gH+AgIB/gH+Af4CAf4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+AgH+AgH+Af4B/f4B/gH+Af4CAgICAgH+Af4B/gH+Af4B/gICAf4CAf4B/gH+Af4B/f4B/gH9/gH+Af4B/gH+AgH+AgH+Af4B/gICAgIB/gH+AgH+Af4CAf4B/gH+AgIB/gH+Af4B/gIB/gIB/gH+Af4CAf4CAf4B/gH+Af4CAf4CAf4B/gH9/gH+Af4CAf4B/gIB/gIB/gH+Af4CAgH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+AgH+AgH+Af4B/gH+Af4CAf4CAgH+Af4B/gH+Af4B/gH+Af4CAf4CAf4B/gIB/gICAf4B/gH+Af4CAf4B/gH+AgH+Af4B/gIB/gH+Af4CAf4CAf4CAf4B/gH+Af4B/gH+AgIB/gH+AgH+AgH+AgH+Af4B/gICAgH+Af4B/gH+AgH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+AgH+Af4B/gIB/gIB/gH+Af4B/gH+Af4B/gH+Af4B/gIB/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gICAf4B/gH+AgH+AgH+AgH+Af4B/gH+AgICAgH+AgH+Af4B/gH+Af4B/gH+Af4B/gH+AgICAf4B/gH+AgIB/gH+Af4B/gICAgIB/gH+AgIB/gH+Af4B/gH+AgH+Af4B/gIB/gIB/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gIB/gH+AgH+AgICAgH+AgH+Af4B/gH+Af4B/gH9/gH+Af3+AgICAf4CAf4B/gIB/gH9/gH+Af4B/gH+Af4CAf4CAgH+Af4B/gH+AgH+Af4B/gH+AgICAgH+Af4B/gH+Af4B/gICAgH+Af4B/gH+AgH+Af4B/gH+Af4B/gH+AgH+Af4CAf4B/gH+AgH+Af4B/gH+Af4B/gICAgH+Af4CAf4B/gIB/gH+Af4B/gH+Af4B/gIB/gICAf4B/gH+Af4B/gH+AgH+Af4CAf4B/gIB/gH+AgH+AgH+AgH+Af3+Af3+Af4B/gIB/gH+AgH+Af4CAf4B/gIB/gH+AgH+Af4B/gICAgH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gH9/gH+Af4CAf4B/gH+Af4CAf4B/gH+Af4CAf4B/gIB/gH9/gH+AgH+Af4B/gICAgICAgICAgH+Af4CAf4CAf4B/gIB/gH+AgH+Af4CAgICAgH+Af4B/gH+Af4CAgH+AgIB/gH+Af4CAf4B/gH9/gH+Af4B/gICAf4B/gIB/gH+Af4B/gH+AgH9/gH+Af3+Af4B/gH+Af4CAgH+Af4B/gH+Af4CAf4CAf4CAf4B/gH+Af4B/gH+Af4B/gIB/gH+AgH+Af4CAf4B/f4B/gH+Af3+Af4B/gICAf4CAgICAf4B/gH+Af4B/gH+Af4B/gIB/gH+Af4CAf4B/gIB/gIB/gH+Af4CAf4B/gH+AgH+Af4B/gH+Af4CAf4CAf4B/gIB/gH+Af4CAf4CAgH+Af4B/gH+Af4CAgH+AgH+Af4B/gICAf4B/gH+AgH+Af4CAf4B/gIB/gIB/gH+Af4B/gH+AgH+AgICAgH+Af4CAgICAf4B/gIB/f4B/gH+AgICAgICAgICAf4CAf4B/gICAgH+AgICAf4CAf4B/gH+AgICAgIB/gH+Af4CAgH+Af4B/gH+AgH+Af4B/f4B/gH9/gH+Af4B/gH+Af4B/gIB/gH+AgIB/gH+Af4CAgH+AgH+Af4B/gH+AgICAgH+Af4B/gH+AgH+Af4B/gH+AgH+Af4CAgH+AgH+Af4B/gH+Af4CAf4B/gH+AgIB/gH+Af4B/gH+AgH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gH+AgH+Af4CAgH+Af4B/gIB/gIB/gH+Af4B/gH+AgICAf4B/gH+Af4B/gH+Af4CAf4B/gICAf4B/gH+Af4B/gH+Af4B/gIB/gH+Af4B/gH+Af4B/gH+AgH+AgH+Af3+Af3+Af4CAf4CAgIB/gIB/gH+AgIB/gIB/gH+AgH+Af4CAf4B/gH+Af4CAf4CAf4B/gIB/gH+AgH+Af4CAf4B/gH+Af4B/gICAgICAgIB/gH+Af4CAgIB/gH+Af4B/gH+AgH+Af4B/gH+Af4CAf4B/gH+Af4B/gIB/gIB/gH+Af4B/gH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gIB/gH+AgH+Af4B/gIB/gH+AgH+Af4B/gIB/gH+Af4B/f4B/gH+AgICAf4B/gIB/gH+AgH+Af4B/gH+Af4B/gH+Af4B/gH+AgIB/gH+Af4CAf4B/gH+Af4CAf4B/gH+AgH+Af4B/gICAf4B/gH+Af4B/gICAf4CAgICAf4B/gH9/gH+Af4B/gIB/gIB/gH+Af4B/gH+Af4B/gH+AgIB/gH+Af4CAf4CAf4CAf4CAf4CAf4CAf4CAf4B/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gIB/gH+Af4CAgICAf4CAf4B/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gH+AgIB/gH+AgH+AgH+Af4B/gH9/gH+AgH+Af4B/gIB/gIB/gIB/gH+Af4CAf4B/gH+Af4CAf4B/gH+AgH+Af3+Af4B/gIB/gH+Af4B/gH+AgIB/gH+Af4B/gIB/gH+Af4CAgH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gIB/gH+AgH+Af4B/gH+Af3+Af4CAf4B/gH+Af4B/gIB/gH+Af4B/gH+AgIB/gH+AgH+Af4B/gH+AgH+Af4B/gH+Af3+Af4B/f4B/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+Af4CAf4B/gH+Af4CAf4B/gICAgIB/gH+Af4B/gH+AgH+Af4B/gH+AgH+Af4CAf4B/gH+AgICAf4B/gH+AgH+Af4B/gIB/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+Af4B/gH+AgH+AgH+Af4CAgH+AgICAf4B/gICAgICAgICAf4B/gH+Af4B/gICAgH+AgH+Af4CAgH+Af4B/gH+Af4B/gH+AgH+Af4B/gIB/gH+Af4CAgH+Af4B/gIB/gH+Af4B/gH+AgH+AgH+AgH+Af4B/gH+AgH+Af4CAf4B/gICAgH+AgICAf4B/gH+Af4B/gH+AgIB/gH+Af4CAgICAgH+Af4CAgH+Af4B/gH+AgIB/gICAgIB/gH+Af4CAf4B/gICAgH+AgICAf4B/gH+Af4B/gH+AgICAf4CAgH+Af4CAgH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+AgH+Af4CAf4B/gH+AgH+AgICAgH+Af4B/gH+Af4B/gH+Af4B/gIB/gH+Af4B/gH+Af4B/gICAgICAf4B/gH9/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gH9/gH+Af4CAgH+Af4B/gH+Af4CAf4B/gH+AgH+Af4B/gH+Af4B/gIB/gH+Af4CAf4B/gIB/gIB/gH+Af4CAf4B/gICAf4B/gH+AgH+Af4B/gH+Af4B/gIB/gIB/gH+Af4B/f4B/gIB/gH+AgH+Af4CAf4B/gH+Af4B/gIB/gIB/gIB/gIB/gH+Af4B/gICAf4B/gH+AgH+AgH+Af4B/f4B/gH+AgIB/gH+AgH+AgH+Af4B/gH+Af4CAf4B/gH+AgICAf4B/gIB/gH+AgIB/gH+AgH+Af4CAf4CAf4B/gH+Af4CAgIB/gH+Af4B/gH+Af4B/gH+AgH+Af4CAf4B/gH+Af4CAf4B/gIB/gH+Af4CAgH+AgH+AgH+Af4B/gIB/gH+Af4B/gH+AgICAgIB/gH+Af4CAgH+AgICAf4CAgH+AgICAgICAf4B/gH+Af4CAf4B/gH+Af4B/gH+Af4B/gIB/gIB/gH+AgH+AgH+AgH+AgH+Af4B/gIB/gH+AgH+Af4CAf4B/gH9/gH+Af4CAf4B/gIB/gH9/gH+Af4B/gIB/gH9/gH+AgH+Af4B/gIB/gICAgIB/gICAgICAgH+Af4B/f4B/gH9/gH+Af4CAf4B/gH+Af4B/gH+Af4B/f4B/gH+AgH+Af4CAf4CAgICAf4B/gH+Af4B/gIB/gH+AgH+AgH+Af4CAf4B/gH+Af4B/gH+AgH+Af4B/gIB/gIB/gICAf4B/gICAf4B/gH+AgIB/gH+Af4B/gH+AgICAgH+AgICAf4B/gH+AgH+Af4B/gICAgH+AgICAgH+Af4B/gH+Af4CAgH+Af4B/f4CAgH+Af4B/gIB/gH+AgICAf4B/gH+AgICAgH+AgH+Af4B/gICAgICAgH+AgH+Af4CAf4B/gIB/gH+Af4B/gH+Af3+Af4B/gH+Af4B/gH+AgH+AgH+Af4B/gIB/gH+Af4B/gH+AgH+Af4CAf4CAf4B/gH+Af4B/gIB/gH+Af4B/gIB/gIB/gICAgIB/gIB/gICAf4B/gICAf4B/gH+Af4CAf4B/gICAf4B/gH+AgIB/gICAgIB/gH+AgH+Af4B/gH+Af4B/gIB/gH+AgH+Af4B/gICAgIB/gH+Af4B/gH+AgH+AgH+Af4B/gH+AgH+Af4B/gIB/gIB/gICAgIB/gH+Af4CAgIB/gICAgH+Af4B/gIB/gH+Af4CAf4B/gH+Af4CAgIB/gH+Af4CAgH+Af4B/gH+AgH+Af4CAgH+Af4B/gH+AgH+Af4B/gH+Af4B/gH+AgH+Af4CAf4B/gH+Af4CAf4B/gIB/gH+Af4CAf4B/gIB/gIB/gICAf4B/gH+AgH+Af4B/gH+AgH+Af4B/gIB/gH+AgH+Af4B/gH+AgH+Af4CAf4CAf4B/gH+Af4CAf4B/gH+Af4CAf4B/gIB/gIB/gH+Af4CAf4CAf4B/gH+Af4CAf4B/gICAf4B/gH+Af4CAgICAf4B/gH+Af4B/gICAf4CAf4B/gH+Af4B/gH+Af4CAf4B/gH+AgH+AgH+AgH+AgIB/f39/f39/f39/gICAgICAgH9/f39/f39/f3+AgICAgH9/f39/f39/f39/f39/f39/f39/gICAgICAgICAf39/f39/f39/gICAgH+Af39/f3+AgICAgH9/f39/f39/gICAgICAgH9/f39/f39/f3+AgICAgH9/f39/f39/gICAgICAf39/f3+AgICAgICAgH9/f39/gICAgICAgICAgIB/f4CAgICAgICAgH9/f39/f39/gICAgICAgH9/f39/f39/gICAgICAgH9/f39/f39/f39/f39/f39/f39/f39/gICAgICAf39/f39/f3+AgICAgICAgIB/f39/f39/f3+AgICAgICAgICAgICAgIB/f39/f39/f39/f4CAgICAf39/fn5+f3+AgIGBgYGAgH9+fn5+f4CBgoODg4OBgH9+fXx8fX1+f3+AgIB/f39/f3+AgIGBgYGBgH9/f3+AgYKDg4OCgX9+fX19fX5/gICAf359fHt6e3x9f4GDhIWEhIOCgYGBgYGBgoKCgoGAf318fHx8foCBg4OCgH57eXd2dnZ4e36ChYeJiYiGhIF+fHt6fH6BhIeJioqIhYF9eXd1dnd5e31+f39/f39/f39/gIGChIWGh4eGhYOBf359fn6AgYKDhIOCgH57eHZ1dXZ4e36ChYeIh4WCfnp2dHR1eH2BhYiJiomHhoSCgYB/f35/f3+AgH9+fXx7enp6e3x+f39/f359fHt6ent9f4KEh4mKiomHhIF9enh4eXt+goaJiomHg398eXd2dnh5e3x+f3+AgICAgICAgYKDhIWGhoWEg4KBgICBgoOEhYWEg4J/fXp4dnV1dnh6fYCChIWEgn98eHZ2d3l8gISHiYmJiIeFhIOBgYB/f39/f39/fn17enl4eHl6e3x9fn5+fXx7e3t7fX6BhIeJiouLiYeEgX17enp8f4KGiYqKiISAfHh2dXR1d3l7fX+AgYGBgYB/f39/gIKEhoeIiIeFhIKBgICAgYKDhISDgn99end2dXV2eHp9gYOFhYSBfnp3dXV3en6ChomLjIuKiIaDgX9+fX19fn+AgIB/fXt5eHd3eHl7fX5/f39+fXx7e3t9f4KFiIqLi4qIhYJ+e3p5en2BhYiKiomGgn15dnRzdHZ4enx+gIGCgoGBgH9+f4CBg4WHiIiHhoSDgYCAgIGCg4SEhIKAfXt4dnV0dXd6fYCDhYaFgn56d3V0dnl9gYaJi4yLioiFg4F/fn59fn5/gICAf317eXh3dnd4enx9fn9/fnx7enp6fH6BhIeJi4uKiIaCf3x6eXt9gYWJi4yKh4N+enZ0dHR1eHp8fn+AgYGAgH9+fn+AgYSGh4iIiIaFg4GAgIGCg4SFhYWDgX57eHZ0dHV2eXx/goSFhIJ+end1dHV4fIGFiIqLi4qIhoSCgH9/fn5/f4CAgH99e3l3dnZ3eHl7fX5/fn58e3p6enx+gYSHiYuLi4mGg4B9e3p7fYGFiIuLioeDf3p3dXR1dnh6fH1/gICAgIB/fn5+f4GDhYeIiIiHhoSCgYGBgoOEhYWFg4F/fHl3dXR1dnl7f4GEhISCfnt3dXR1eHuAhIiKi4uKiIaEgoGAf39/f4CAgYB/fnx6eHd2d3h5e3x+fn59fHt6eXp7fYCDhoiKi4uJh4SBfnt6e32BhIiLjIuIhIB7eHV0dHZ3eXt9fn+AgH9/fn5+fn+Bg4WHiImIh4aEg4KBgYKDhIWFhYSCf3x5d3V1dXZ4e36Bg4SEgn97eHV0dHd7f4OHiYuLioiGhIOBgIB/f4CAgYGBgH58enh2dnZ3eHp8fX5+fXx7enp6e31/goWIiouLiYeFgX58e3t9gISIioyLiYWAfHh1dHR1d3l7fH5/f39/f35+fX5/gIKFh4iJiYiHhYOCgYGCg4SFhYWEgoB9end1dHV2eHp9gIKEhIJ/e3h1c3R2en6DhomLi4qJh4WDgoCAf3+AgIGBgYB/fXp4d3Z2d3h6e31+fn59e3p6ent8f4KFiIqLi4qIhYJ/fXt7fYCEh4qMjIqGgn15dnR0dXZ4enx+f39/f39+fn1+f4CChIaIiYmIh4WDgoGBgYKEhYWFhIOAfXp4dnR0dXd5fH+Cg4OCf3x4dXR0dnl9goaJiouKiYeFg4KBgICAgICBgYGAf317eXd2dnd4ent9fn5+fXx7enp7fH+BhIeJi4uKiYaDgH58fH2Ag4eKjIyKh4J+end1dHV2eHp8fn9/gIB/f35+fX5/gYSGiImJiYeGhIKBgYGCg4SFhYSDgH57eHZ1dHV3eXx/gYOEg4B9eXZ0dHV4fIGFiIqLiomHhYSCgYB/f4CAgYGBgX9+e3l3dnZ2d3l7fH5+fn18e3p6e3x+gYSHiYqLiomGg4B+fHt8f4KGiYuMioeDf3p3dXR0dnh6fH1+f4CAf39+fX1+f4GDhYeIiYiHhoSDgYGBgoOEhYWEg4F+e3l2dXR1dnh7foGDhIOBfnp2dHR1eHuAhIeKi4qJiIaEgoGAf39/gICBgYGAfnx6eHZ2dnd5e3x+fn5+fXt6enp8foGEhomKi4uJh4SBfnx7fH6BhYmLjIuIhIB7d3V0dHV3eXt9fn9/gH9/fn5+fn+Bg4WHiImJiIaEg4GBgYGChISFhIOBf3x5d3V0dXZ4e36Ag4SDgX57d3V0dHd7f4OHiouLioiGhIOBgIB/gICAgYGBgH58enh3dnZ3eXp8fn5/fn18e3p7fH6Ag4aIiouLioiFgn98e3x9gYSIi4yLiYWAfHh2dHR1d3l7fX5/gIB/f35+fn5/gYOFh4iJiYiGhIOBgYCBgoOEhYWEgn98end1dHR2eHp9gIOEhIJ/fHh1dHR2en6DhomLi4qIhoSCgYCAf3+AgIGBgYB+fHp4d3Z2d3h6fH1+f359fHt6ent9f4KFiIqLi4qIhYJ/fHt7fYCDh4qLi4mGgX15dnR0dXd5e3x+f39/f39+fn19foCChIaIiYmIhoWDgYGAgYKDhIWEhIKAfXp3dXR0dXd6fX+ChISCgHx4dXR0dnl9goaJi4uKiYeFg4GAgH9/gICBgYGAf317eXd2dnd4enx9fn5+fXx7enp7fX+ChYiKi4uLiYaDgH17e31/g4eKi4yKhoJ9eXZ0dHV2eHp8fn+AgIB/f35+fn+AgoSGiImJiIeFg4KBgYGCg4SFhYSDgH17eHZ0dHV3eXx/goSEg4F9eXZ0dHZ5fYGFiYuLi4mHhYOCgYB/f4CAgYGBgH99e3l3dnZ2eHl7fX5/fn58e3p6e3x+gYSHiouLi4mGg4B9e3t8foKGiYuMioeDfnp2dHR0dnh6fH5/f4CAf39+fX1+gIKEhoiJiYiHhYOCgYCBgYOEhYWFg4F+e3h2dHR1dnl8f4GDhIOBfXp2dHR1eHyAhYiKi4uKiIaEgoGAf3+AgIGBgYGAfnt5d3Z2dnd5e31+f35+fXt6enp8foGEh4mLjIuJh4SBfnx7fH6BhYmLjIuIhH96d3RzdHV3enx9f3+AgH9/fn19fn+Bg4aHiYmIh4aEgoGBgYKDhIWFhYOBf3t4dnR0dHZ4e36Bg4SDgX56d3RzdHd7gISIiouLioiGhIKBgH9/f4CBgYGBgH58eXh2dnZ3eXt9fn9+fn17enp6e36Ag4aJi4yLioeEgX58e3t9gYWIi4yLiIR/e3d1dHR1d3p8fX9/gIB/f359fX5/gYOFh4iJiIeGhIKBgIGBgoSFhYWEgn98eXZ0dHR2eHt+gYOEhIF+end0c3R3en+Dh4qLi4qIhoSCgYB/f4CAgYGCgYB+fHp4dnZ2d3l7fH5/f359e3p6ent9gIOGiYuMi4qIhYF+fHt7fYGEiIuMi4mFgHx4dXR0dXd6fH1/gICAf39+fX1+f4GDhYeIiYmIhoSCgYCBgYKEhYWFhIJ/fHl2dXR0dXh6fYCDhISCf3t3dHN0dnp+g4eJi4uKiIaEgoGAf39/gIGBgYGAfnx6eHZ2dnd5enx+fn9+fXt6enp7fX+DhomKi4uKiIWCf3x7e32AhIiKjIuJhYF8eHV0dHV3eXt9fn+AgH9/fn19fX+AgoWHiImJiIaEg4GAgIGCg4WFhYSDgH16d3V0dHV3en2AgoSEgn98eHVzdHZ5foKGiYuLiomHhIKBgH9/gICBgYKBgX99e3h3dnZ3eHp8fX5/fn18e3p6e3x/goWIiouLioiGgn99e3t8f4OHioyMioaCfXl2dHR1dnl7fX5/gIB/f35+fX1+gIKEhoiJiYiHhYOBgICBgoOEhYWEg4B9end1dHR1d3l8f4KDhIKAfHh1c3N1eH2BhYmLi4qJh4WDgYB/f3+AgIGBgYF/fXt5d3Z2d3h6fH1+f359fHt6enp8foGEh4qLi4uJhoOAfXt7fH+ChomMjIqHg356dnR0dHZ4enx+f4CAf39+fn19fn+BhIaIiYmIh4WDgoGAgYKDhIWFhYOBfnt4dnR0dXZ5fH+Cg4SDgX15dnRzdXh8gIWIiouLiYeFg4GAgH9/gICBgYGBf357eXd2dnZ4eXt9fn9+fnx7enp6fH6BhIeJi4uLiYeEgH18e3x+goaJjIyLiIR/e3d1dHR2eHp8fn+AgIB/f359fX5/gYSGiImJiYeGhIKBgIGBg4SFhYWEgn98eXZ1dHV2eHt+gYOEg4F+enZ0c3R3e3+EiIqLi4qIhoSCgYB/f4CAgYGBgYB+fHl4dnZ2d3l7fX5/f359e3p6ent9gIOGiYuLi4mHhIF+fHt7fYGFiIuMi4mFgHt4dXR0dXd5e31+f39/f35+fX19f4GDhYeIiYmHhoSCgYCAgYKEhYWFhIJ/fHl3dXR0dnh6foCDhIOBfnt3dHN0dnp+g4eKi4uKiIaEgoGAf3+AgIGBgoGAfnx6eHZ2dnd5e3x+fn5+fXt6enp7fX+ChoiKi4uKiIWCf3x7e32AhIiLjIyJhoF8eHZ0dHV3eXt9fn+AgH9/fn19fX+AgoWHiImJiIaEg4GBgYGChIWFhYSDgH16d3V0dHV3en2AgoSEgn98eHVzdHZ5foKGiYuLiomGhIOBgICAgICBgYKBgX99enh3dnZ3eHp8fX5+fn18enp6enx/goWIiouLioiFgn98e3t8f4OHioyMioaCfXl2dHR1dnl7fX5/f39/fn59fX1+gIKEhoiJiYiGhYOCgYGBgoOFhYWEg4B9end1dHR1d3p8gIKEhIOAfHl1dHN1eH2BhYmLi4qJh4WDgYCAgICAgYGCgYF/fXt5d3Z2d3h6e31+fn59fHt6enp8foGFiIqLi4qJhoOAfXt7fH+ChoqMjIqHg356d3V0dXZ4enx+f39/f39+fX19fn+BhIaIiYmIh4WDgoGBgYKDhIWFhYOBfnt4dnR0dXZ5fH+Cg4SDgX15dnRzdXh8gIWIiouLiYeFg4KBgICAgICBgYGBf357eXd2dnd4eXt9fn5+fXx7enp6fH6BhIeJi4uLiYaDgH17e3x+goWJi4yLiIR/e3d1dHR2eHp8fn9/gH9/fn59fX5/gYOGh4mJiIeFhIKBgYGCg4SFhYWDgX57eHZ0dHV2eHt+gYOEg4F+end0c3R3e3+Eh4qLi4mIhYOCgYCAf4CAgYGBgYB+fHl3dnZ2d3l7fH5+fn58e3p6ent9gIOGiYuLi4mHhIF+fHt7fYGFiIuMi4iEgHt4dXR0dnd6fH1+f39/f35+fX1+f4GDhYeIiYiHhoSCgYCBgYKEhYWFhIJ/fHl2dXR0dnh7foGDhISCf3t3dXN0dnp/g4eKi4uKiIaEgoGAgH+AgIGBgYGAfnx6eHd2dnd5e3x+fn5+fXt6enp7fYCDhomKi4uKiIWBfnx7e32AhIeKjIuJhYF8eHZ0dHV3eXt9fn+AgH9/fn19fn+AgoWHiImJiIaEg4GAgIGCg4WFhYSCgH15d3V0dHV3en2Ag4SEgn98eHV0dHZ5foKGiYuLioiGhIKBgH9/gICBgYGBgH98enh3dnZ3eXp8fn5/fn18e3p6e31/goWIiouLioiFgn98e3t8f4OHioyMioaCfXl2dHR1d3l7fX5/gIB/f359fX1+gIKEhoiJiYiGhYOBgYGBgoOFhYWFg4B9end1dHR1d3p9gIKEhIOAfXl2dHR2eX2ChomLi4qJh4WDgYCAf4CAgYGCgYF/fXt5d3Z2d3h6fH1+f359fHt6enp8foGFh4qLi4qJhoN/fXt7fH+ChomLjIqHg356d3V0dXZ4e3x+f4CAf39+fn19foCChIaIiYmIh4WDgoGAgYKDhIWFhYOBfnt4dXR0dXZ5fH+ChISDgX15dnRzdXh8gIWIiouKiYeFg4GAgH9/gICBgYGBf317eXd2dnd4ent9fn9+fXx7enp6fH6BhIeJi4uLiYaDgH17e3x+goWJi4yLiIR/e3d1dHR2eHp8fn+AgIB/fn59fX5/gYOGh4iJiIeFg4KBgIGCg4SFhYWEgX97eHZ0dHR2eHt+gYOEg4F+end0c3R3e4CEiIqLi4mIhYOCgYB/f4CAgYGBgX9+e3l4dnZ2eHl7fX5/fn58e3p5ent9gIOGiYuLi4mHhIF+fHt7fYGFiIuMi4mFgHt4dXR0dnd6fH1/f4B/f35+fX1+f4GDhYeIiYiHhoSCgYGBgYOEhYaFhIJ/fHl2dXR0dnh7foGDhISCf3t3dXR0d3p/g4eKi4uKiIaEgoGAf3+AgIGBgYGAfnx6eHZ2dnd5e3x+f39+fXt6enp7fYCDhomLjIuKiIWCf3x7e32AhIiLjIyJhoF8eHZ0dHV3eXt9f3+AgH9/fn59fn+Bg4WHiImJiIaEg4GBgYGChIWFhYSCgH16d3V0dHV3en2Ag4SEgoB8eHV0dHZ5foKGiYuLioiGhIKBgICAgICBgYGBgH58enh3dnZ3eXp8fn5/fn18enp6enx/goWIiouLioiFgn98e3t8f4OHioyLioaCfXl2dHR1dnh7fH5/f39/fn59fX1+gIKEhoiJiYiGhIOBgICBgoOEhYWFg4B9end1dHR1d3l8gIKEhIOAfXl2dHR1eX2BhomKi4qJh4WDgYCAf3+AgIGBgYB/fXt4d3Z2d3h6fH1+fn59fHp6eXp8foGEh4qLi4qJhoN/fXt7fH+ChomLjIqHg356dnR0dHZ4enx+f39/f39+fX19foCChIaIiYmIh4WDgoGAgYKDhIWFhYOBfnt4dXR0dXZ5fH+ChISDgX15dnRzdXh8gIWIiouKiYeFg4KAgH+AgICBgYGBf317eXh3dnd4ent9fn9+fnx7enp6fH6BhIaJiouKiYaDgX58fHx+gYWIioqJh4N/e3h2dnZ3eXt9fn+AgIB/f35+fn6AgYOFhoeHh4aEg4GAgICBgoOEhISDgX98enh3dnd4enx/gYKDgoF/fHl4d3h6fYCDhYeIh4aFg4KBgH9/f4CAgYGBgIB+fXx6enp6e3x9fn9/f39+fXx8fH1/gIKEhoeHh4aEgoB/fn1+f4GDhYaGhoSCf3x6eXl5enx9fn+AgICAgH9+fn5/f4CCg4SEhISDgoGAgH9/gICBgoKCgYB/fXx7enp6e3x9f4CBgYGAf318e3p7fH6AgoOEhYSEg4KAgH9/f39/f4CAgIB/f35+fX19fX1+fn9/f39/f39/f39/gIGBgoKDgoKBgYB/f35+f3+AgYKCgoKBgH9+fX19fX1+f3+AgICAgIB/f39/f39/f4CAgICAgICAgICAgICAgIB/f39/f35+fn5+fn5/f39/gICAgIB/f39/f39/gICAgYGBgYGAgIB/f39/f39/f4CAgICAgICAgICAf39/f39/f4CAgICAgICAgICAgYGBgICAgIB/f39/f4CAgICAgIB/f39+fn5/f39/gICAgICAgICAgH9/f39/f39/f39/f39/f39/f39/f4CAgIB/f39/f39/f39/gICAgICAgIB/f39/f39/gICAgYGBgICAf39/f39/gICAgICAgICAgICAgICAgICAgICAf39/f39/f4CAgICAgICAgIB/f39/f39/gICAgIGBgYCAgH9/f39/f39/gICAgICAf39/f39/f39/f4CAgICAf39/f39/f4CAgICAgH9/f39/f39/f3+AgICAgIB/f39/f39/f39/gICAgICAgICAgH9/f39/f4CAgICAgICAgICAgH9/f39/f39/f3+AgICAgICAgICAgIB/f39/f39/f4CAgICAgICAf39/f39/f39/gICAgIB/f39/f39/f39/f39/f39/f39/f39/f4CAgICAf39/f39/f39/gICAgICAgICAgH9/f39/f39/gICAgICAgIB/f39/f3+AgICAgICAgICAgICAgICAgICAgICAgIB/f39/f3+AgICAgICAf39/f39/f39/gICAgICAgICAf39/f3+AgICAgICAgIB/f39/f39/f39/gICAf39/f39/f39/f4CAgICAgIB/f39/f39/f4CAgICAgIB/f39/f39/f4CAgICAgICAgIB/f4CAgICAgICAgICAf39/f4CAgICAgICAgIB/f39/f39/f3+AgICAgICAf39/f39/f4B/gICAgH+Af4B/gICAgICAf4B/gH+AgH+Af4B/gIB/gH+AgH+Af4CAgICAf4B/f4B/gH+AgH+Af4B/f4B/gH+Af4B/gH+AgH+Af4CAf4B/gIB/gICAgICAgH+Af4CAgH+Af4CAf4CAgH+Af4CAf4CAf4B/gIB/gH+Af4B/gICAf4B/gIB/gH+Af4B/gICAf4B/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gICAgICAgICAgICAgH+Af4B/gH+Af4CAf4B/gH+Af4B/gH9/gH+Af4B/gH+AgH+Af4CAf4B/gH+Af4B/gH+Af4CAf4B/gH+Af4CAf4B/gH+Af4B/gICAgH+AgICAgICAgH+Af4B/f4B/gH+Af4B/gIB/gH+Af4CAf4B/gICAgIB/gH+Af4B/gH+Af4CAf4B/gH+Af4B/gICAgIB/gICAf4B/gH+Af4CAf4B/gIB/gH+Af4CAf4CAf4B/gH+AgIB/gH+Af4CAgH+Af4B/gICAgH+Af4B/gH+Af4CAf4CAf4B/gIB/gH+AgICAf4B/gIB/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gIB/gH+Af4B/gIB/gH+Af4CAf4B/gH+AgH+AgH+Af4B/f4B/gIB/gH+AgIB/gH+AgH+Af4CAf3+Af4B/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gH+AgH+Af4B/gICAgIB/gH+Af4B/gICAf4B/gIB/gH+Af4CAgH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gIB/gH+AgIB/gH+Af3+Af4B/gH+Af4CAgH+Af4B/gIB/gH+Af4B/gIB/gH+Af4B/gH+Af4CAf4B/gH9/gH+Af4B/gH+Af4CAf4B/gIB/gH+AgH+AgIB/gH+AgH+Af4B/gH+Af4B/gH+Af4CAf4B/gIB/gH9/gH+Af4CAf4B/gIB/gH+AgIB/gIB/gH+Af4B/gH+Af4B/gH+Af4B/gH9/gH+Af4B/gH+AgH+AgH+Af4CAgH+Af4B/gH+Af4CAf4B/gICAf4B/gH+AgIB/gH+Af4CAgH+Af4B/gH+Af4CAf4CAf4B/gIB/gIB/gH+Af4B/gH+AgH+Af3+Af4B/gIB/gIB/gH+AgH+Af4B/gH+AgH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gIB/gH+AgH+Af4B/gH+Af4B/gICAgIB/gICAgICAgICAf4B/gH+Af4B/gH+AgICAgH+Af4B/gH+Af4B/gH+Af4CAf4CAf4B/gH+Af4B/gH+Af4CAf4CAgH+Af4B/gH+Af4B/gIB/gH+Af4CAgH+Af4CAgH+Af4CAf4B/gH+Af4CAf4B/gH+AgH+AgICAf4CAf4B/gIB/gH+Af4B/gH+Af4B/gIB/gH+AgICAgICAgH+Af4B/gH+Af4CAf4B/gH+Af4B/gH+AgICAgH+Af4CAgICAf4B/gH+Af4B/gH9/gH9/gH+AgH+Af4B/gH+Af3+Af4B/gH+AgIB/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gH+Af4CAf4B/gIB/gH+Af4CAf4CAgICAf4B/gH+AgICAf4B/gH+Af4CAf4B/gH+Af4CAgICAf4B/gH+AgICAgH+Af4B/gICAf4B/gH+AgH+Af4B/gIB/gH+Af4B/gIB/gIB/gH+Af4CAf4B/gH+Af4B/gH+Af4CAf4B/gH+Af4CAf4B/gH+Af4CAf4B/gH+Af4CAgICAgIB/gH+Af4B/gH+Af4CAf4B/gH+Af4B/gH+Af4CAf4CAf4B/gH+Af4B/gIB/gH+Af4CAf4B/gH+Af4B/gH+Af4B/gIB/gIB/gH+AgH+AgH+Af4B/gH+AgIB/gH+Af4B/gICAf4B/gH+Af4B/gH+Af4B/gH+Af3+Af4CAf4B/gH+AgIB/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gIB/gH+Af3+Af4B/gH+Af4CAgIB/gH+Af4CAf4B/gIB/gH+Af4B/gH+AgH+Af4CAgICAgICAgICAgH+Af4B/gH+Af4B/gIB/gH+Af4CAgIB/gIB/gH+AgH+AgH+Af4CAgIB/gH+Af4B/gH+Af4B/gIB/gH+AgICAgICAf4B/gIB/gH+Af4CAf4B/gH+Af4B/gH+AgH+Af4CAgH+Af4B/gH+Af4B/gICAf4CAgICAgIB/gH+Af3+Af4CAgH+Af4B/f4B/gH+AgH+AgICAgH+AgH+Af4B/gH+Af4B/gH+AgIB/gIB/gH+Af3+Af4B/gH+AgICAgIB/gH+Af4CAf4B/gIB/gH+Af4CAf4CAf4B/gH9/gH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gIB/gH+AgH+AgICAgIB/gH+Af4B/gH+Af4B/gH+AgH+Af4CAf4CAf4B/gH+Af4CAf4B/gICAf4B/gH+Af4B/gH+Af4CAgH+Af4B/gH+Af4B/gIB/gH+AgICAf4B/gH+AgICAgICAf4B/gIB/gH9/gH+Af4B/gH+Af4CAf4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+Af4B/gH+Af4CAf4CAf4B/gH+Af4CAf4B/gIB/gIB/gH+Af4B/gIB/gH+Af4B/gH+AgICAgICAgIB/gH+Af4B/gH+AgH+Af4B/gICAf4B/gH9/gH+Af4CAf4B/f4B/gH+Af4B/gH+AgH+Af4B/gIB/gH+AgH+Af4B/gIB/gH+AgH+Af4CAf4B/gH+Af4CAf4B/gICAf4B/gH+Af4B/gH+Af4B/gIB/gH+AgH+Af4B/gIB/gIB/gH+Af4B/gH+Af4CAgH+Af4CAf4B/gH+AgICAf4CAgH+Af4B/gIB/gH+Af4CAf4B/gH+Af4B/gH+AgH+Af4CAgH+Af4B/gICAf4B/gH+Af4CAf4CAf4B/gIB/gH+Af3+Af4CAf4B/gH9/gH+Af4CAgICAf4B/gH+AgIB/gH+Af4B/gH+AgH+AgH+Af4B/gH+Af4B/gICAgH9/gH+Af4B/gH+Af4B/f4B/gH+Af4B/gICAgICAgICAf4B/gH+AgICAgIB/gH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+AgH+AgH+Af4B/gICAgH+Af4B/gH+AgICAf4B/gIB/gIB/gH+Af4B/gH+Af4B/gH+AgH+AgH+Af4CAf4CAf4B/gH+Af4CAf4B/gH+AgH+Af4B/gIB/gICAgIB/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gIB/gICAgH+Af4B/gH+Af4CAf4B/gH+Af4B/gICAgICAf4B/gH9/gH+AgH+Af3+AgH+Af4B/gH+Af4B/gH+Af4CAgICAgIB/gH+Af4CAgICAf4B/gH+AgH+Af4B/gICAgH+Af4CAf4CAf4CAf4B/gH+Af4B/f4B/gH+AgICAgH+Af4B/f4B/gICAgICAgH+Af4B/gH+AgH+AgICAf4B/gH+Af4CAgICAf4CAf4B/gH+AgH+AgH+AgH+Af4B/gH+Af4B/gH+AgH+Af4CAf4B/gICAgH+AgH+Af4B/gIB/gH+AgH+Af4B/gH+Af4CAf4CAf4CAgICAf4CAf4B/gH+AgH+Af4B/gH+AgH+Af4CAgH+Af4B/gIB/gIB/gH+Af4B/gICAf4B/gH+AgH+Af4B/gH+Af4B/gH+AgH+Af4CAgIB/gH+Af4B/gH+AgH+Af4B/gH+AgICAf4B/gH+Af4B/gIB/gH+AgICAgH+Af4CAgICAf4B/gIB/gH+AgH+Af4B/gIB/gH+Af4CAf4B/gH+Af4CAf4B/gH+Af4B/gICAf4B/gH+Af4B/gH+Af4CAgH+Af4B/gIB/gH+AgH+Af4B/gIB/gH+AgH+AgH+AgH+AgICAgH+AgH+AgH+Af4CAf4CAf4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+Af4CAf4CAf4B/gH+Af4B/gH+Af4B/gH+Af4CAgICAf4B/gH+Af4B/gH+Af4CAgH+Af4B/gIB/gH+Af4CAf4B/gICAgICAf4B/gH+AgICAf4B/gH+Af4CAgH+AgICAf4B/gIB/gH+Af4B/gH+AgH+Af4B/gIB/gIB/gIB/gH+Af4B/gH+Af4B/gH+Af3+Af4B/gH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gICAgICAgH+Af4CAf4CAf4CAf4B/gH+Af4B/gH+AgH+Af4CAgICAf4B/gH+AgIB/gH+Af4CAf4B/gH+Af4B/gH+AgH+Af4B/gH+AgICAf4CAgIB/gH+Af3+Af4B/gIB/gH+Af4CAf4B/f4B/gH+Af4B/gIB/gICAf4B/gH+Af4CAf4B/gIB/gH+AgICAf4CAgIB/gH+Af4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+AgH+Af4CAf4B/gH+Af4B/gICAgICAgH+Af4B/gIB/gH+AgH+Af4B/gH+AgH+Af4CAf4CAgICAgICAf4CAf4B/gH9/gH+AgH+Af4CAgICAf4CAgIB/gH+AgH+AgH+Af4CAf4CAf4CAf4CAf4B/gIB/gH+Af4B/gH+AgH+Af4B/gIB/gH+AgH+Af4B/gH+AgH+Af4CAf4CAf4B/gH+AgH+AgH+AgIB/gH+Af4CAf4B/gH+AgH+Af4CAgICAf4B/f4B/gH+Af4B/gH+Af4CAf4B/gH+Af4B/gIB/gH+AgH+Af3+Af4B/gH+Af4CAgICAf4B/gICAf4B/gH+Af4B/gH+Af4CAf4B/gIB/gIB/gH+Af4CAf4B/gH+AgH+AgH+Af4B/gIB/gH+Af4B/gH+AgH+Af4B/gH+Af4B/gH+Af4CAf4CAf4B/gH+AgH+AgH+Af4B/gICAf4CAf4B/gH+Af4B/gH9/gH+Af4B/gH+AgH+Af4CAf4CAf4B/gH+AgH+Af4B/gICAgH+Af4CAf4B/gH+AgH+Af4B/gH+Af4B/gH+Af4B/gH+Af4CAf4B/gICAgIB/gH+Af4CAgICAf4B/gH+AgH+AgIB/gH+Af4B/gH+Af4B/gH+Af4B/gIB/gIB/gH+Af4B/gIB/gH+AgH+AgH+Af4B/gIB/gH+AgH+Af4CAf4B/gIB/gH+Af4B/gH+Af4CAf4B/gICAgICAgH+Af4CAf4B/gH+AgH+Af4CAf4B/gH+Af4B/gIB/gIB/gIB/gIB/gIB/gIB/gH+AgH9/gH+Af4B/gH+Af4B/gIB/gH+Af4B/gICAf4B/gIB/gH+Af3+Af4CAf4B/gH+AgIB/gH+Af4CAf4B/gH+Af3+Af4B/gH9/gH+Af4B/gICAgICAgICAgIB/gH+Af3+Af4B/f4B/gIB/gH+AgICAgH+Af4B/gIB/gICAf4B/gH+Af4B/gICAgIB/gH+Af4B/f4B/gH+AgICAgH+Af4CAf4B/gICAf4B/gH+Af4B/gH+Af4B/gH+Af4B/gH+AgH+Af4CAf4B/gICAgIB/gH+AgH+AgH+Af4B/gH+AgH+Af4B/gICAf4B/gIB/gH+Af4B/gH+Af4CAgH+AgH+Af4B/gH+AgH+Af4B/gH+Af3+Af4B/gH+Af4B/gH+AgH+Af4B/gH+AgH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+Af4B/gH+AgH+Af4B/gH+Af4CAgH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gIB/gIB/gICAf4B/gH+AgH+Af4B/gIB/gH+Af4CAf4B/gH+Af4B/gH+AgH+Af4CAf4CAf4CAf4B/gH+Af4CAgIB/gH+Af3+AgH+Af4B/gH+AgIB/gH+Af4B/f4B/gIB/gIB/gH+AgH+AgICAgIB/gIB/gIB/gH+Af4CAf4CAf4B/gH+Af4B/gIB/gH9/gH+Af4B/gH9/gH+Af4B/gH+Af4CAgICAf4B/gIB/gIB/gIB/gH+Af4B/gH+AgICAgIB/gH+AgH+Af4B/f4B/gH9/gH+Af4CAf4B/gIB/gICAf4B/gH+AgH+Af4CAf4CAf4B/gH+Af4B/gH+AgH+AgH+Af4B/gIB/gICAgIB/gH+Af4B/gH+AgICAgH+Af4B/gH+Af4B/gH+Af4B/gH+AgICAgICAgIB/gH+Af4B/gIB/gIB/gIB/gH+AgICAgIB/gH+Af3+Af4CAgIB/gH+Af4CAgH+Af4B/gICAgIB/gH+Af4B/gH+Af4CAgH+Af4B/gIB/gH+Af4B/gH+Af4B/gH+AgH+Af4CAf4B/gH+Af4CAf4B/gH+AgH+Af4CAf4B/gH+AgICAgICAgH+AgICAgH+AgIB/gH+Af4CAf4B/gH+Af4B/gIB/gIB/gH+Af4CAf4B/gH+AgH+Af4B/gIB/gIB/gH+AgH+Af4CAf4B/gH+Af4B/gH+AgH+Af4B/gH+AgH+AgH+AgH+Af4B/gIB/gH+AgH+Af4B/gIB/gIB/gH+Af4CAf4B/gH+Af4CAgIB/gICAgH+Af4B/gH+Af4CAf4B/gICAf4CAgICAgICAgICAgICAgH+Af4B/gH+Af4CAgH+Af4B/gIB/gH+Af4CAf4B/gIB/gICAgH+AgICAgICAgH+Af4CAf4B/gH+Af4B/gIB/gH+AgIB/gH+Af4B/gH+Af4CAf4CAf4B/gH+AgH+Af4CAgICAf4B/gIB/gH+AgIB/gH+AgH+Af4CAf4B/gH+Af4B/gIB/gICAf4B/gICAf4B/gH+Af4CAf4B/gIB/gH+Af4B/gICAgIB/gICAf4B/gICAgIB/gH+AgH+AgIB/gH+AgH+Af4CAf4B/gH+Af4CAf4CAf4B/gH+AgICAgIB/gH+AgH+Af4B/gICAgIB/gICAgH+AgH+Af4CAf4B/gH+Af4CAf4CAf4B/gICAf4B/gH+Af4B/gH+Af4CAf4B/gIB/gH+Af4B/gH+Af4CAgH+AgH+Af4CAf4B/gH+Af4B/gH+Af4B/gICAgH+Af4B/gIB/gH+Af4B/gH+Af4CAf4CAf4CAf4B/gIB/gH+Af4B/gICAgIB/gH+Af4B/gH+Af4CAf4B/gH+AgH+Af4B/gICAgH+Af4B/gH+AgICAgH9/gH+AgH+AgH+Af3+Af4B/gH+Af4CAgICAf4CAf4CAf4B/gIB/gH+AgH+AgH+Af4B/gICAf4B/gIB/gIB/gH+Af4B/gH+Af4B/gIB/gH+AgH+Af4B/gH+Af4CAf4B/gIB/gIB/gH+Af4CAf4B/gIB/gH+Af4CAgH+Af4B/gH+AgH+AgH+Af4CAf4B/gICAgICAf4B/gH+Af4B/gIB/gIB/gH+AgH+Af4CAf4B/gIB/gH+Af4B/gH+AgICAgH+Af4B/gH+Af4B/gH+AgH+AgH+Af4B/gICAgH+Af4B/gICAgICAgICAgH+Af4B/gICAgH+Af4B/gH+Af4CAgH+Af4B/gH+AgH+AgH+AgH+Af4CAf4B/gH9/f39/f39/f3+AgICAgICAf39/f39/f3+Af4CAgICAf39/f39/f39/f39/f39/f39/f3+AgICAgICAgH9/f39/f39/f3+AgICAgH+Af39/f4CAgICAf39/f39/f4CAgICAgICAf39/f39/f39/f4CAgICAf39/f39/f3+AgICAgIB/f39/f4CAgICAgIB/f39/f4CAgICAgICAgICAf39/gICAgICAgICAf39/f39/f3+AgICAgICAf39/f39/f3+AgICAgICAf39/f39/f39/f39/f39/f39/f39/f3+AgICAgIB/f39/f39/f4CAgICAgICAgH9/f39/f39/f4CAgICAgICAgICAgICAgH9/f39/f39/f39/gICAgIB/f39+fn5/f4CAgYGBgYCAf35+fn9/gIGCg4ODgoGAfn19fHx9fn5/f4CAf39/f39/f4CAgYGBgYCAf39/f4CBgoODg4KAf359fX1+fn+AgIB/fn17e3p7fH6AgoOEhYSDg4KBgYGBgYGCgoKBgYB/fXx8fH1+gIKDg4KAfXt4d3Z2d3l8f4KFiImJiIaDgH17ent8foGFiIqKioeEgHx4dnV2d3l7fX5/f39/f39/f3+AgYKEhYeHh4aEgoF/fn1+f4CBg4SEg4KAfXp4dnV1dnh7f4KFh4iHhYF9eXZ0dHZ5fYKGiIqKiYeFg4KAf39+fn9/f4CAf359fHt6enp7fX5/f39/fn18e3p6fH2AgoWHiYqKiIaDgH16eHh5fH+Dh4mKiYaCf3t4d3Z3eHl7fX5/gICAgICAgIGBgoOEhYaGhYSDgYCAgIGCg4SFhYSDgX98enh2dXZ3eXt+gIOEhYSBfnt4dnZ3eX2BhIeJiYmIh4WEgoGAgH9/f39/f39+fXt6eHh4eXp7fH1+fn59fHt7e3t9f4KEh4mLi4qJhoOAfXt5enx/g4eJiomHg397eHV0dXZ3eXt9f4CBgoGBgH9/f3+BgoSGh4iHhoWDgoCAgICBgoOEhIOBf3x5d3V0dXZ4e36BhIWFg4B9eXZ1dXd7f4OHiouMi4mHhYOBf359fX5+f4CAgH99e3l3d3d4eXt9fn9/f358e3t7fH2Ag4aIiouLioiFgX57eXl7foKGiYqKiIWBfHh1dHN0dnh7fX+AgYKCgYB/f35/gIKEhoeIiIeGhIKBgICAgYKDhISDgoB9end1dHR1d3p9gYSFhoSBfXl2dXR2en6ChomLjIuJh4WDgX9+fX1+fn+AgIB/fXt5d3Z2d3l6fH5/f359fHt6ent8f4KFiIqLi4qIhYJ+e3p6e36ChoqMjIqGgn15dnR0dHZ4enx+f4CBgYB/f35+f4CChIaIiIiHhoSDgYCAgYKEhYWFhIOAfXp3dXR0dXd6fYCDhIWEgX16dnR0dnl9goaJi4uLiYeFg4KAf39+fn+AgICAfn17eXd2dnd4enx9fn9+fXx7enp7fH+BhIeKi4uKiIaDf317ent+goaJi4uKhoJ+enZ1dHV2eHp8fn+AgICAf39+fn+AgYSGh4iIiIeFhIKBgYGCg4SFhYSDgX57eHZ1dHV3eXx/goSEg4F+enZ0dHV4fIGFiIqLi4mIhoSCgYB/f39/gICBgH99e3l4dnZ3eHl7fX5+fn18e3p5ent+gISGiYqLiomGg4B9e3p7foGFiYuMioeDf3p3dXR1dnh6fH1+f4CAf39+fn5+f4GDhYeIiYiHhoSDgoGBgoOEhYWFg4F/fHl3dXV1dnl7foGDhISBfnp3dXR1eHuAhIiKi4uKiIaEgoGAgH9/gICBgYF/fnx5d3Z2dnd5enx9fn59fHt6enp7fYCDhoiKi4qJh4SBfnx7e36BhYiLjIuIhH97d3V0dHV3eXt9fn9/f39/fn59fn+Bg4WHiYmJiIaEg4KBgYKDhIWFhYSCf3x5d3V0dXZ4e36Bg4SDgn57d3RzdHd7f4OHiouLioiGhIOBgIB/f4CAgYGBgH58enh2dnZ3eHp8fX5+fXx7enl6e31/goWIiouLiYeEgX98e3x9gYSIi4yLiYWBfHh2dHR1d3l7fX5/f39/f35+fX5/gIKFh4iJiYiGhYOCgYGCg4SFhYWEgoB9end1dHV2d3p9gIKDg4J/e3h1dHR2en6ChomLi4qJh4WDgoGAgICAgIGBgYB+fHp4d3Z2d3h6fH1+fn59fHt6ent9f4KFiIqLi4qIhoOAfXx8fYCEh4qMi4mGgX15dnR0dXd5e3x+f4CAgH9+fn1+foCChIaIiYmIh4WEgoGBgYKDhIWFhIKAfXp4dnR0dXd5fH+Cg4OCf3x4dXR0dnl9goaJiouKiYeFg4KBgH9/gICBgYGAf317eXd2dnZ4eXt9fn5+fXx7enp7fH+ChIeJiouKiIaDgH18e31/g4eKi4uKhoJ+enZ1dHV2eHp8fX9/gIB/f359fX5/gYOGh4mJiIeFhIKBgYGCg4SFhYSDgH57eHZ1dHV3eXx/gYOEg4B9eXZ0dHV4fIGFiIqLiomHhYOCgYB/f3+AgIGBgH99e3l3dnZ2d3l7fX5+fn18e3p6e3x+gYSHiYuLiomGg4B9fHt8f4KGiYuMioeDf3p3dXR0dnh6fH1+f39/f39+fn5+f4GDhoeJiYiHhoSCgYGBgoOEhIWEg4F+e3h2dXR1dnh7foGDhIOBfnp2dHR1eHyAhIiKi4uJiIaEgoGAgH+AgIGBgYGAfnx5eHZ2dnd5e31+f39+fXx7ent8foGEhomKi4uJh4SBfnx7fH6BhYmLjIuIhH97d3V0dHZ4enx9fn+AgH9/fn5+fn+Bg4WHiYmJh4aEgoGAgIGCg4SFhIOBf3x5d3V0dXZ4e36Bg4SEgn57d3V0dXd7f4SHiouLioiGhIKBgH9/f4CAgYGBgH58enh2dnZ3eXt8fn9/fn18e3p6fH6Ag4aIiouLiYeEgX58e3t9gISIiouLiIWAfHh1dHR1d3l7fX5/f39/f359fX5/gIKFh4iJiYiGhIOBgICBgoOEhYSDgX98eXd1dHR2eHp9gIKEhIJ/e3h1dHR2en6Dh4mLi4qIhoSCgYB/f3+AgIGBgYB/fHp4d3Z2d3h6fH1+fn59fHt6ent9gIOGiIqLi4qIhYJ/fXt7fYCEh4qMi4mGgXx4dnR0dXd5e31+f4CAgH9+fn5+f4CChYeIiYmIhoWDgoGBgYKDhIWFhIKAfXp3dXR0dXd6fYCChISDgHx5dnR0dnl+goaJi4uLiYeFg4GAgH9/gICBgYGAf317eHd2dnd4enx9fn9+fXx7enp7fX+ChYiKi4uKiYaDf317e3x/g4eKjIyKhoJ9eXZ0dHV2eHt8fn+AgH9/fn59fn6AgoSGiImJiIeFg4KBgIGCg4SFhYSDgH16eHV0dHV3eXx/goSEg4B9eXZ0dHV5fYGGiYuLi4mHhYOCgIB/f4CAgYGBgX99e3l3dnZ2eHl7fX5/fn18e3p6e3x/gYWHiouLi4mGg4B9e3t8f4KGioyMioeDfnp2dHN0dnh6fH5/gICAf35+fX1+gIKEhoiJiYiHhYOCgYGBgoOEhYWFg4F+e3h2dHR1dnl8f4KEhIOBfXl2dHN1eHyBhYiKi4uJh4WDgoCAf3+AgIGBgYF/fXt5d3Z2dnh5e31+f35+fHt6enp8foGEh4qLjIuJh4OAfXt7fH6ChomLjIqHg356d3R0dHZ4enx+f3+AgH9+fn19fn+Bg4aHiYmIh4WEgoGAgYKDhIWFhYOBfnt4dnR0dHZ4e36Bg4SDgX16dnRzdXd7gISIiouLiYeFg4KAgH9/gICBgYGBgH58eXd2dnZ4eXt9fn9+fnx7enp6fH6BhIeJi4yLiYeEgX58e3x+gYWJi4yLiIR/e3d1dHR2eHp8fn+AgIB/f359fX5/gYOGh4mJiIeGhIKBgIGBg4SFhYWEgX98eXZ0dHR2eHt+gYOEg4F+enZ0c3R3e3+Eh4qLi4mIhYOCgIB/f4CAgYGBgYB+fHl4dnZ2d3l7fX5/fn59e3p6ent9gIOGiYuMi4qHhIF+fHt7fYGFiIuMi4iFgHt3dXR0dXd6fH1/f4CAf39+fX1+f4GDhYeIiYmHhoSCgYCBgYKEhYWFhIJ/fHl3dXR0dnh7foGDhISCf3t3dHN0dnp/g4eKi4uKiIaEgoGAf3+AgIGBgoGAf3x6eHd2dnd5e3x+f39+fXx6enp7fYCDhoiKi4uKiIWCf3x7e32AhIiLjIyJhYF8eHV0dHV3eXt9f3+AgH9/fn19fn+AgoWHiImJiIaEg4GAgIGCg4WFhYSCgH16d3V0dHV3en2AgoSEgn97eHVzdHZ5foKGiYuLioiGhIKBgH9/f4CAgYGBgH99enh3dnZ3eHp8fX5/fn18e3p6e3x/goWIiouLioiFgn98e3t8f4OHioyMioaCfXl2dHR1dnl7fX5/gIB/f359fX1+gIKEhoiJiYiHhYOCgYCBgoOEhYWFg4B+enh1dHR1d3p9gIKEhIOAfHh1dHR1eX2BhomLi4uJh4WDgYCAf3+AgIGBgYF/fXt5d3Z2d3h6fH1+f359fHt6enp8foGFh4qLi4uJhoOAfXt7fH+Dh4qMjIuHg356d3V0dXZ4e31+f4CAgH9+fn19foCChIaIiYmIh4WDgoGAgYKDhIWFhYOBfnt4dnR0dXd5fH+ChISDgH15dnRzdXh8gIWIiouLiYeFg4KAgH+AgICBgYGBf317eXd2dnZ4eXt9fn9+fnx7enp6e36BhIeJi4uLiYaDgH17e3x+goaJi4yLiIR/e3d1dHR2eHp8fX9/f39/fn19fX5/gYOGh4mJiIeFg4KBgICBg4SFhYWEgX98eXZ0dHR2eHt+gYOEg4F+enZ0c3R3e3+Eh4qLi4qIhoOCgYB/f4CAgYGCgYB+fHl4dnZ2d3l7fX5+fn59e3p6ent9gIOGiYuLi4qHhIF+fHt7foGFiYuMi4mFgHt4dXR0dnd6fH1/f4CAf35+fX1+f4GDhYeJiYmIhoSCgYGBgYOEhYWFhIJ/fHl3dXR0dnh7foGDhISCfnt3dXN0d3p/g4eKi4uKiIaEgoGAgICAgIGCgoGAfnx6eHZ2dnd5enx9fn5+fXt6enp7fX+DhoiKi4uKh4WBfnx7e32AhIiLjIuJhYF8eHV0dHV3eXt9fn9/f39+fn19fX6AgoWHiImJiIaEg4GBgYGChIWFhYSCgH16d3V0dHV3en2Ag4SEgn97eHVzdHZ5foKGiYuLioiGhIOBgICAgICBgYKBgH99enh3dnZ3eHp8fX5+fn18enp6e3x/goWIiouLioiFgn98e3t8f4OHioyMioaCfXl2dHR1d3l7fX5/f39/f359fX1+gIKEhoiJiYiGhYOCgYGBgoOFhYWEg4B9end1dHR1d3p9gIKEhIOAfHl1dHR1eX2BhYmLi4qJh4WDgYCAgICAgYGBgYF/fXt5d3Z2d3h6fH1+fn59fHt6enp8foGFh4qLi4qIhoN/fXt7fH+ChoqMjIqHg356dnV0dXZ4enx+f3+Af39+fn19foCChIaIiYmIh4WDgoGBgYKDhIWFhYOBfnt4dnR0dXd5fH+ChISDgX15dnRzdXh8gIWIiouKiYeFg4KAgH+AgICBgYGBf317eXd2dnZ4eXt9fn5+fXx7enp6fH6BhIeJi4uLiYaDgH17e3x+goWJi4yKiIN/end1dHV2eHp8fn9/f39/fn59fX5/gYOGh4iJiIeFhIKBgIGCg4SFhYWDgX57eHZ0dHR2eHt+gYOEg4F+end0c3R3e4CEiIqLi4mIhYOCgYCAgICAgYGBgYB+fHl4dnZ2eHl7fX5+fn58e3p6ent9gIOGiYuLi4mHhIF+e3t7fYGFiIuMi4iEgHt4dXR0dnh6fH1/f4B/f35+fX1+f4GDhYeIiYiHhoSCgYCBgYKEhYWFhIJ/fHl2dXR0dnh7foGDhISCf3t3dXR0d3p/g4eKi4uKiIaEgoGAf3+AgIGBgYGAfnx6eHd2dnd5e3x+f39+fXx6enp7fYCDhomKi4uKh4WBfnx7e32AhIiKjIuJhYF8eHZ0dHV3eXx9f3+AgH9/fn19fn+Ag4WHiImJh4aEgoGBgYGChIWFhYSCgH16d3V0dHV3en2Ag4SEgn98eHV0dHZ6foOGiYuLioiGhIKBgIB/gICBgYKBgH99enh3dnZ3eXp8fn5/fn18enp6e31/goWIiouLioiFgn98e3t8f4OHioyLiYaCfXl2dHR1d3l7fX5/gIB/f359fX1+gIKEhoiJiYiGhIOBgYCBgoOEhYWEg4B9end1dHR1d3l9gIKEhIOAfHl1dHR1eX2BhYmKi4qIhoSCgYB/f3+AgIGBgYB/fXt4d3Z2d3h6fH1+f359fHt6enp8foGFiIqLi4qJhoN/fXt7fH+ChoqMjIqHg356dnV0dXZ4e31+f4CAf39+fn1+foCChIaIiYmIh4WDgoGAgYKDhIWFhYOBfnt4dXR0dXZ5fH+ChISDgX15dnRzdXh8gYWIiouKiYeFg4GAgH9/gICBgYGAf317eXd2dnd4ent9fn9+fXx7enl6fH6BhIeJi4uLiYaDgH17e3x+goaJi4yLiIR/e3d1dHR2eHp8fn9/gH9/fn59fX6AgYSGiImJiIeFg4KBgYGCg4SFhoWEgX97eHZ0dHR2eHt+gYOEhIF+end0dHV3e4CEiIqLi4mHhYOCgYB/f4CAgYGBgYB+e3l3dnZ2eHl7fX5/f358e3p6ent9gIOHiYuMi4qHhIF+fHt7foGFiIuMi4mFgHx4dXR0dnh6fH5/gICAf39+fn5+f4GDhoeJiYmHhoSCgYGBgYOEhYaFhIJ/fHl2dXR0dnh7foGDhISCf3t3dXN0d3p/g4eKi4uKiIaEgoGAgICAgIGBgYGAfnx6eHZ2dnd5e3x+f39+fXt6eXp7fX+DhoiKi4uKiIWBfnx7e32AhIiKjIuJhYF8eHV0dHV3eXt9fn9/f39+fn19fX+Ag4WHiImIh4aEgoGAgIGChIWFhYSCgH16d3V0dHV3en2Ag4SEgn98eHV0dHZ6foKGiYuLioiGhIKBgH9/gICBgYGBgH58enh3dnZ3eHp8fX5+fn17enl5enx/goWIiouLioiFgn98e3t8f4OHioyMioaCfXl2dHR1d3l7fX5/f39/fn59fX1+gIKEhoiJiYiGhIOBgYCBgoOFhYWEg4B9end1dHR1d3l8gIKEhIOAfHl1dHR1eX2BhomKi4qJh4WDgYCAf4CAgIGBgYB/fXt5d3d2d3h6fH1+f359fHt6ent8f4GEh4mKi4qIhoOAfXx8fX+ChYiKiomGgn57eHZ2dnh6e31+f4CAgH9/fn5+f4CBg4WGh4eHhYSCgYCAgIGCg4SEhIKBfnx6eHd3d3l6fX+Bg4OCgX57eXd3eHp9gYSGh4iHhoWDgoGAf39/gICBgYGAf359e3p6enp7fH1+f39/fn59fHx9fn+Bg4SGh4eGhYSCgH59fX5/gYOFhoaFg4F+fHp5eXl6fH1/gICAgIB/f35+fn+AgYKDhISEhIOCgYCAf3+AgYGCgoGBgH59e3p6enp7fH5/gIGBgYB+fXt7e3t9foCChISEhIOCgYCAf39/f3+AgICAgH9/fn59fX19fX5+f39/f39/f39/f3+AgYGCgoOCgoGBgH9/fn5/f4CBgoKCgoGAf359fX19fX5/f4CAgICAgH9/f39/f3+AgICAgICAgICAgICAgICAf39/f39/fn5+fn5+fn9/f4CAgICAf39/f39/f3+AgICBgYGBgICAgH9/f39/f39/gICAgICAgICAgIB/f39/f39/gICAgICAgICAgICBgYGAgICAf39/f39/gICAgICAf39/f35+fn9/f3+AgICAgICAgICAf39/f39/f39/f39/f39/f39/f39/gICAf39/f39/f39/f3+AgICAgICAf39/f39/f3+AgIGBgYCAgIB/f39/f3+AgICAgICAgICAgICAgICAgICAgIB/f39/f39/gICAgICAgICAgH9/f39/f3+AgICAgYGAgIB/f39/f39/f3+AgICAgIB/f39/f39/f39/gICAgIB/f39/f39/gICAgICAf39/f39/f39/f4CAgICAgH9/f39/f39/f4CAgICAgICAgICAf39/f39/gICAgICAgICAgICAf39/f39/f39/f4CAgICAgICAgICAgH9/f39/f39/gICAgICAgIB/f39/f39/f4CAgICAgH9/f39/f39/f39/f39/f39/f39/f39/gICAgIB/f39/f39/f4CAgICAgICAgICAf39/f39/f4CAgICAgICAgH9/f39/f4CAgICAgICAgICAgICAgICAgICAgICAf39/f39/f4CAgICAgIB/f39/f39/f4CAgICAgICAgIB/f39/f4CAgICAgICAgH9/f39/f39/f4CAgIB/f39/f39/f3+AgICAgICAgH9/f39/f39/gICAgICAgH9/f39/f39/gICAgICAgICAf39/gICAgICAgICAgH9/f39/gICAgICAgICAgH9/f39/f39/f4CAgICAgH9/f39/f38=";
            
    }
}
