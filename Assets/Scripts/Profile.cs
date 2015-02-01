using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public static class Profile
    {
        private static readonly string ProgressKey = Md5.Encode("ProgressKey");

        public static int Progress
        {
            get
            {
                return PlayerPrefs.HasKey(ProgressKey) ? PlayerPrefs.GetInt(ProgressKey) : 1;
            }
            set
            {
                PlayerPrefs.SetInt(ProgressKey, value);
                PlayerPrefs.Save();
            }
        }
    }
}