using System;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public static class Profile
    {
        private static readonly string PasswordKey = Md5.Encode("Password");
        private static readonly string ProgressEasyKey = Md5.Encode("ProgressEasy");
        private static readonly string ProgressHardKey = Md5.Encode("ProgressHard");
        private static readonly string ProgressSwapKey = Md5.Encode("ProgressSwap");
        private static readonly string ProgressMemoKey = Md5.Encode("ProgressMemo");
        private static readonly string MuteKey = Md5.Encode("Mute");
        private static readonly string ShowAdTimeKey = Md5.Encode("ShowAdTime");
        private static readonly string CreditsKey = Md5.Encode("Credits");
        private static readonly string DeluxeKey = Md5.Encode("Deluxe");

        public static int ProgressEasy
        {
            get { return GetValueInt(ProgressEasyKey); }
            set { SetValue(ProgressEasyKey, value); }
        }

        public static int ProgressHard
        {
            get { return GetValueInt(ProgressHardKey); }
            set { SetValue(ProgressHardKey, value); }
        }

        public static int ProgressSwap
        {
            get { return GetValueInt(ProgressSwapKey); }
            set { SetValue(ProgressSwapKey, value); }
        }

        public static int ProgressMemo
        {
            get { return GetValueInt(ProgressMemoKey); }
            set { SetValue(ProgressMemoKey, value); }
        }

        public static bool Mute
        {
            get { return GetValueInt(MuteKey) == 1; }
            set { SetValue(MuteKey, value ? 1 : 0); }
        }

        public static DateTime ShowAdTime
        {
            get
            {
                if (PlayerPrefs.HasKey(ShowAdTimeKey))
                {
                    return DateTime.Parse(GetValue(ShowAdTimeKey));
                }

                return (ShowAdTime = DateTime.UtcNow.AddMinutes(10));
            }
            set { SetValue(ShowAdTimeKey, Convert.ToString(value)); }
        }

        public static int Coins
        {
            get { return GetValueInt(CreditsKey); }
            set { SetValue(CreditsKey, value); }
        }

        public static bool Deluxe
        {
            get { return GetValueInt(DeluxeKey) == 1; }
            set { SetValue(DeluxeKey, value ? 1 : 0); }
        }

        public static bool CharacterUnlocked(CharacterId id)
        {
            var key = Md5.Encode(Convert.ToString(id));

            return GetValueInt(key) == 1;
        }

        public static void UnlockCharacter(CharacterId id)
        {
            var key = Md5.Encode(Convert.ToString(id));

            SetValue(key, 1);
        }

        private static string Password
        {
            get
            {
                if (!PlayerPrefs.HasKey(PasswordKey))
                {
                    PlayerPrefs.SetString(PasswordKey, Md5.Encode(Convert.ToString(CRandom.GetRandom(1000000))));
                }

                return PlayerPrefs.GetString(PasswordKey);
            }
        }

        private static void SetValue(string key, string value)
        {
            PlayerPrefs.SetString(key, B64X.Encrypt(value, Md5.Encode(key + Password)));
            PlayerPrefs.Save();
        }

        private static void SetValue(string key, int value)
        {
            SetValue(key, Convert.ToString(value));
        }

        private static string GetValue(string key)
        {
            return PlayerPrefs.HasKey(key) ? B64X.Decrypt(PlayerPrefs.GetString(key), Md5.Encode(key + Password)) : null;
        }

        private static int GetValueInt(string key)
        {
            return PlayerPrefs.HasKey(key) ? int.Parse(GetValue(key)) : 0;
        }
    }
}