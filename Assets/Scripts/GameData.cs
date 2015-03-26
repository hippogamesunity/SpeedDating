using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static readonly List<Hobby> Hobbies = Enum.GetValues(typeof(Hobby)).Cast<Hobby>().ToList();

        private static List<string> _maleImages, _femaleImages;
        private static int _maleName, _femaleName;
        private static int _maleImage, _femaleImage;

        public static List<CharacterId> DeluxeCharacters = new List<CharacterId>
        {
            CharacterId.f9,
            CharacterId.f10,
            CharacterId.m9,
            CharacterId.m10
        };

        public static Dictionary<CharacterId, int> CharacterPrice = new Dictionary<CharacterId, int>
        {
            { CharacterId.f1, 5 },
            { CharacterId.f2, 5 },
            { CharacterId.f3, 10 },
            { CharacterId.f4, 10 },
            { CharacterId.f5, 15 },
            { CharacterId.f6, 15 },
            { CharacterId.f7, 20 },
            { CharacterId.f8, 20 },
            { CharacterId.f9, 25 },
            { CharacterId.f10, 25 },

            { CharacterId.m1, 5 },
            { CharacterId.m2, 5 },
            { CharacterId.m3, 10 },
            { CharacterId.m4, 10 },
            { CharacterId.m5, 15 },
            { CharacterId.m6, 15 },
            { CharacterId.m7, 20 },
            { CharacterId.m8, 20 },
            { CharacterId.m9, 25 },
            { CharacterId.m10, 25 }
        }; 

        public static List<Level> EasyLevels
        {
            get
            {
                return new List<Level>
                {
                    Level2x0, Level3x0, Level3x1, Level3x2, Level4x0a,
                    Level4x0b, Level4x2, Level4x3, Level4x4, Level4x5,
                    Level5x0, Level5x1, Level5x2, Level5x3, Level5x4,
                    Level5x5a, Level5x5b, Level5x6, Level6x0, Level6x1,
                    Level6x2, Level6x3, Level6x4a, Level6x4a, Level6x4b,
                };
            }
        }

        public static List<Level> GetLevels(LevelType levelType)
        {
            switch (levelType)
            {
                case LevelType.Easy:
                    return EasyLevels;
                case LevelType.Hard:
                    return Levels.HardLevels;
                case LevelType.Swap:
                    return Levels.SwapLevels;
                case LevelType.Memo:
                    return Levels.MemoLevels;
                default:
                    throw new Exception();
            }
        }

        public static void Initialize()
        {
            _maleImages = new List<string>
            {
                "m1",
                "m2",
                "m3",
                "m4",
                "m5",
                "m6",
                "m7",
                "m8"
            };

            _femaleImages = new List<string>
            {
                "f1",
                "f2",
                "f3",
                "f4",
                "f5",
                "f6",
                "f7",
                "f8"
            };

            if (Profile.Deluxe)
            {
                _maleImages.Add("m9");
                _maleImages.Add("m10");
                _femaleImages.Add("f9");
                _femaleImages.Add("f10");
            }

            _maleImages = _maleImages.Shuffle();
            _femaleImages = _femaleImages.Shuffle();
        }

        public static string GetNextMaleImage()
        {
            return GeNext(_maleImages, ref _maleImage);
        }

        public static string GeNextFemaleImage()
        {
            return GeNext(_femaleImages, ref _femaleImage);
        }

        public static string GetNameById(CharacterId id)
        {
            return GetNameById(Convert.ToString(id));
        }

        public static string GetNameById(string id)
        {
            return Localization.Get(string.Format("%{0}name%", id));
        }

        public static string GetBackground()
        {
            var backs = new List<string> { "CoffeeShop", "Attic", "SushiBar" };

            return backs[CRandom.GetRandom(backs.Count)];
        }

        private static string GeNext(IList<string> list, ref int index)
        {
            var result = list[index];

            if (index == list.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }

            return result;
        }

        public static readonly Dictionary<int, float> TableScales = new Dictionary<int, float>
        {
            { 2, 1.00f },
            { 3, 1.00f },
            { 4, 0.90f },
            { 5, 0.85f },
            { 6, 0.80f },
            { 7, 0.70f },
            { 8, 0.70f },
        };

        public static readonly Dictionary<int, List<Vector2>> TablePositions = new Dictionary<int, List<Vector2>>
        {
            {
                2, new List<Vector2>
                {
                    new Vector2(-280, -40), new Vector2(280, -40)
                }
            },
            {
                3, new List<Vector2>
                {
                    new Vector2(-400, 40), new Vector2(400, 40), new Vector2(0, -180)
                }
            },
            {
                4, new List<Vector2>
                {
                    new Vector2(-150, 100), new Vector2(350, 100), new Vector2(-400, -240), new Vector2(100, -240)
                }
            },
            {
                5, new List<Vector2>
                {
                    new Vector2(-320, 100), new Vector2(320, 100), new Vector2(0, -80), new Vector2(-480, -240), new Vector2(480, -240)
                }
            },
            {
                6, new List<Vector2>
                {
                    new Vector2(-180, 100), new Vector2(180, 100),
                    new Vector2(-500, -40), new Vector2(500, -40),
                    new Vector2(-180, -240), new Vector2(180, -240)
                }
            },
            {
                7, new List<Vector2>
                {
                    new Vector2(-250, 120), new Vector2(250, 120),
                    new Vector2(-500, -80), new Vector2(0, -80), new Vector2(500, -80),
                    new Vector2(-250, -300), new Vector2(250, -300)
                }
            },
            {
                8, new List<Vector2>
                {
                    new Vector2(-500, 60), new Vector2(0, 120), new Vector2(500, 60),
                    new Vector2(-230, -80), new Vector2(230, -80),
                    new Vector2(-500, -240), new Vector2(0, -300), new Vector2(500, -240)
                }
            }
        };
    }
}
