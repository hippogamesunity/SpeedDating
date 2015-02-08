using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public static class Profile
    {
        private static readonly string ProgressKey = Md5.Encode("ProgressKey");
        private static readonly string SwapProgressKey = Md5.Encode("SwapProgressKey");
        private static readonly string MuteKey = Md5.Encode("MuteKey");

        public static int Progress
        {
            get { return PlayerPrefs.HasKey(ProgressKey) ? PlayerPrefs.GetInt(ProgressKey) : 1; }
            set
            {
                PlayerPrefs.SetInt(ProgressKey, value);
                PlayerPrefs.Save();
            }
        }

        public static int SwapProgress
        {
            get { return PlayerPrefs.HasKey(SwapProgressKey) ? PlayerPrefs.GetInt(SwapProgressKey) : 1; }
            set
            {
                PlayerPrefs.SetInt(SwapProgressKey, value);
                PlayerPrefs.Save();
            }
        }

        public static bool Mute
        {
            get
            {
                return PlayerPrefs.HasKey(MuteKey) && PlayerPrefs.GetInt(MuteKey) == 1;
            }
            set
            {
                PlayerPrefs.SetInt(MuteKey, value ? 1 : 0);
                PlayerPrefs.Save();
            }
        }
    }
}