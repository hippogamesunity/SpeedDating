using System;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public static class Profile
    {
        private static readonly string ProgressEasyKey = Md5.Encode("ProgressEasyKey");
        private static readonly string ProgressHardKey = Md5.Encode("ProgressHardKey");
        private static readonly string ProgressSwapKey = Md5.Encode("ProgressSwapKey");
        private static readonly string MuteKey = Md5.Encode("MuteKey");
        private static readonly string ShowAdTimeKey = Md5.Encode("ShowAdTimeKey");

        public static int ProgressEasy
        {
            get { return PlayerPrefs.HasKey(ProgressEasyKey) ? PlayerPrefs.GetInt(ProgressEasyKey) : 1; }
            set { PlayerPrefs.SetInt(ProgressEasyKey, value); PlayerPrefs.Save(); }
        }

        public static int ProgressHard
        {
            get { return PlayerPrefs.HasKey(ProgressHardKey) ? PlayerPrefs.GetInt(ProgressHardKey) : 1; }
            set { PlayerPrefs.SetInt(ProgressHardKey, value); PlayerPrefs.Save(); }
        }

        public static int ProgressSwap
        {
            get { return PlayerPrefs.HasKey(ProgressSwapKey) ? PlayerPrefs.GetInt(ProgressSwapKey) : 1; }
            set { PlayerPrefs.SetInt(ProgressSwapKey, value); PlayerPrefs.Save(); }
        }

        public static bool Mute
        {
            get { return PlayerPrefs.HasKey(MuteKey) && PlayerPrefs.GetInt(MuteKey) == 1; }
            set { PlayerPrefs.SetInt(MuteKey, value ? 1 : 0); PlayerPrefs.Save(); }
        }
        public static DateTime ShowAdTime
        {
            get { return PlayerPrefs.HasKey(ShowAdTimeKey) ? DateTime.Parse(PlayerPrefs.GetString(ShowAdTimeKey)) : DateTime.UtcNow.AddMinutes(10); }
            set { PlayerPrefs.SetString(ShowAdTimeKey, Convert.ToString(value)); PlayerPrefs.Save(); }
        }
    }
}