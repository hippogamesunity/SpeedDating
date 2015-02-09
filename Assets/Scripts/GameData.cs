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

        public static List<Level> Levels
        {
            get
            {
                return new List<Level>
                {
                    Level2x0, Level3x0, Level3x1, Level3x2, Level4x0a,
                    Level4x0b, Level4x2, Level4x3, Level4x4, Level4x5,
                    Level5x0, Level5x1, Level5x2, Level5x3, Level5x4,
                    Level5x5a, Level5x5b, Level5x6, Level6x0, Level6x1,
                    Level6x2, Level6x3, Level6x4a, Level6x4a, Level6x5, Level6x4b
                };
            }
        }

        public static List<Level> SwapLevels
        {
            get
            {
                return new List<Level>
                {
                    SwapLevel3x0
                };
            }
        }

        public static void Shuffle()
        {
            _maleNamesEn = _maleNamesEn.Shuffle();
            _femaleNamesEn = _femaleNamesEn.Shuffle();
            _maleNamesJp = _maleNamesEn.Shuffle();
            _femaleNamesJp = _femaleNamesEn.Shuffle();
            _maleImages = _maleImages.Shuffle();
            _femaleImages = _femaleImages.Shuffle();
        }

        public static string GetNextMaleName(bool japan)
        {
            return GeNext(japan ? _maleNamesJp : _maleNamesEn, ref _maleName);
        }

        public static string GetNextFemaleName(bool japan)
        {
            return GeNext(japan ? _femaleNamesJp : _femaleNamesEn, ref _femaleName);
        }

        public static string GetNextMaleImage()
        {
            return GeNext(_maleImages, ref _maleImage);
        }

        public static string GeNextFemaleImage()
        {
            return GeNext(_femaleImages, ref _femaleImage);
        }

        private static List<string> _maleNamesEn = new List<string>
        {
            "James",
            "John",
            "Robert",
            "Michael",
            "William",
            "David",
            "Richard",
            "Charles",
            "Joseph",
            "Thomas",
            "Chris",
            "Daniel",
            "Paul",
            "Mark",
            "Donald",
            "George",
            "Kenneth",
            "Steven",
            "Edward",
            "Brian"
        };

        private static List<string> _femaleNamesEn = new List<string>
        {
            "Mary",
            "Patricia",
            "Linda",
            "Barbara",
            "Elizabeth",
            "Jennifer",
            "Maria",
            "Susan",
            "Margaret",
            "Dorothy",
            "Lisa",
            "Nancy",
            "Karen",
            "Betty",
            "Helen",
            "Sandra",
            "Donna",
            "Carol",
            "Sharon",
            "Kate"
        };

        private static List<string> _maleNamesJp = new List<string>
        {
            "Haruto",
            "Yuto",
            "Sota",
            "Yuki",
            "Hayato",
            "Haruki",
            "Ryusei",
            "Koki",
            "Sora",
            "Sosuke",
            "Riku",
            "Soma",
            "Ryota",
            "Rui",
            "Kaito",
            "Haru",
            "Kota",
            "Yusei",
            "Yuito",
            "Yuma"
        };

        private static List<string> _femaleNamesJp = new List<string>
        {
            "Yui",
            "Rio",
            "Yuna",
            "Hina",
            "Koharu",
            "Hinata",
            "Mei",
            "Mio",
            "Saki",
            "Miyu",
            "Kokona",
            "Haruka",
            "Rin",
            "Akari",
            "Yuna",
            "Honoka",
            "Momoka",
            "Aoi",
            "Ichika",
            "Sakura"
        };

        private static List<string> _maleImages = new List<string>
        {
            "m1",
            "m2",
            "m3",
            "m4",
            "m5",
            "m6",
            "m7",
            "m8",
            "m9"
        };

        private static List<string> _femaleImages = new List<string>
        {
            "f1",
            "f2",
            "f3",
            "f4",
            "f5",
            "f6",
            "f7",
            "f8",
            "f9"
        };

        private static int _maleName, _femaleName;
        private static int _maleImage, _femaleImage;

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
                    new Vector2(-400, 40), new Vector2(400, 40), new Vector2(0, -120)
                }
            },
            {
                4, new List<Vector2>
                {
                    new Vector2(-240, 80), new Vector2(240, 80), new Vector2(-440, -240), new Vector2(440, -240)
                }
            },
            {
                5, new List<Vector2>
                {
                    new Vector2(-280, 80), new Vector2(280, 80), new Vector2(0, -120), new Vector2(-440, -260), new Vector2(440, -260)
                }
            },
            {
                6, new List<Vector2>
                {
                    new Vector2(-180, 100), new Vector2(180, 100),
                    new Vector2(-500, -60), new Vector2(500, -60),
                    new Vector2(-220, -260), new Vector2(220, -260)
                }
            },
            {
                7, new List<Vector2>
                {
                    new Vector2(-240, 100), new Vector2(240, 100),
                    new Vector2(-500, -60), new Vector2(0, -60), new Vector2(500, -60),
                    new Vector2(-280, -260), new Vector2(280, -260)
                }
            }
        };
    }
}
