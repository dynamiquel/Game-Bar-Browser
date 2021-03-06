﻿namespace GameBarBrowser.Shortcuts
{
    public static class ShortcutHandler
    {
        public static NormalShortcuts NormalShortcuts { get; private set; }

        static ShortcutHandler()
        {
            NormalShortcuts = new NormalShortcuts();
            NormalShortcuts.Add("bing", "https://bing.com/");
            NormalShortcuts.Add("google", "https://google.com/");
            NormalShortcuts.Add("ddg", "https://duckduckgo.com/");
            NormalShortcuts.Add("yt", "https://youtube.com/");
            NormalShortcuts.Add("ttv", "https://twitch.tv/");
            NormalShortcuts.Add("xbox", "https://xbox.com/");
            NormalShortcuts.Add("steam", "https://steampowered.com/");
        }
    }
}
