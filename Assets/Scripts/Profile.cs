using System;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public static class Profile
    {
        private static readonly string ProgressEasyKey = Md5.Encode("ProgressEasy");
        private static readonly string ProgressHardKey = Md5.Encode("ProgressHard");
        private static readonly string ProgressSwapKey = Md5.Encode("ProgressSwap");
        private static readonly string ProgressMemoKey = Md5.Encode("ProgressMemo");
        private static readonly string MuteKey = Md5.Encode("Mute");
        private static readonly string ShowAdTimeKey = Md5.Encode("ShowAdTime");
        private static readonly string CreditsKey = Md5.Encode("Credits");
        private static readonly string PremiumKey = Md5.Encode("Premium");

        public static int ProgressEasy
        {
            get { return PlayerPrefs.HasKey(ProgressEasyKey) ? PlayerPrefs.GetInt(ProgressEasyKey) : 0; }
            set { PlayerPrefs.SetInt(ProgressEasyKey, value); PlayerPrefs.Save(); }
        }

        public static int ProgressHard
        {
            get { return PlayerPrefs.HasKey(ProgressHardKey) ? PlayerPrefs.GetInt(ProgressHardKey) : 0; }
            set { PlayerPrefs.SetInt(ProgressHardKey, value); PlayerPrefs.Save(); }
        }

        public static int ProgressSwap
        {
            get { return PlayerPrefs.HasKey(ProgressSwapKey) ? PlayerPrefs.GetInt(ProgressSwapKey) : 0; }
            set { PlayerPrefs.SetInt(ProgressSwapKey, value); PlayerPrefs.Save(); }
        }

        public static int ProgressMemo
        {
            get { return PlayerPrefs.HasKey(ProgressMemoKey) ? PlayerPrefs.GetInt(ProgressMemoKey) : 0; }
            set { PlayerPrefs.SetInt(ProgressMemoKey, value); PlayerPrefs.Save(); }
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

        public static int Coins
        {
            get { return PlayerPrefs.HasKey(CreditsKey) ? PlayerPrefs.GetInt(CreditsKey) : 0; }
            set { PlayerPrefs.SetInt(CreditsKey, value); PlayerPrefs.Save(); }
        }

        public static bool Premium
        {
            get { return PlayerPrefs.HasKey(PremiumKey) && PlayerPrefs.GetInt(PremiumKey) == 1; }
            set { PlayerPrefs.SetInt(PremiumKey, 1); PlayerPrefs.Save(); }
        }

        public static CharacterState GetCharacterState(CharacterId id)
        {
            var key = Md5.Encode(Convert.ToString(id));

            return PlayerPrefs.HasKey(key) ? PlayerPrefs.GetString(key).ToEnum<CharacterState>() : CharacterState.Locked;
        }

        public static void SetCharacterState(CharacterId id, CharacterState state)
        {
            var key = Md5.Encode(Convert.ToString(id));

            PlayerPrefs.SetString(key, Convert.ToString(state));
            PlayerPrefs.Save();
        }
    }
}