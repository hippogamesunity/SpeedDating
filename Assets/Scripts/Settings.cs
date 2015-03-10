using System.Collections.Generic;

namespace Assets.Scripts
{
    public static class Settings
    {
        public static bool Debug = true;
        public static List<CharacterId> BonusCharacters = new List<CharacterId>
        {
            CharacterId.f9,
            CharacterId.f10,
            CharacterId.m9,
            CharacterId.m10
        };
        public static Dictionary<CharacterId, int> UnlockCharacterPrice = new Dictionary<CharacterId, int>
        {
            { CharacterId.f1, 2 },
            { CharacterId.f2, 2 },
            { CharacterId.f3, 2 },
            { CharacterId.f4, 2 },
            { CharacterId.f5, 2 },
            { CharacterId.f6, 2 },
            { CharacterId.f7, 2 },
            { CharacterId.f8, 2 },
            { CharacterId.f9, 0 },
            { CharacterId.f10, 0 },

            { CharacterId.m1, 2 },
            { CharacterId.m2, 2 },
            { CharacterId.m3, 2 },
            { CharacterId.m4, 2 },
            { CharacterId.m5, 2 },
            { CharacterId.m6, 2 },
            { CharacterId.m7, 2 },
            { CharacterId.m8, 2 },
            { CharacterId.m9, 0 },
            { CharacterId.m10, 0 }
        }; 
    }
}