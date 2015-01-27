using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static readonly List<Hobby> Hobbies = Enum.GetValues(typeof(Hobby)).Cast<Hobby>().ToList(); 

        public static void Shuffle()
        {
            _maleNames = _maleNames.Shuffle();
            _femaleNames = _femaleNames.Shuffle();
            _maleImages = _maleImages.Shuffle();
            _femaleImages = _femaleImages.Shuffle();
        }

        public static string GetNextFemaleName()
        {
            return GeNext(_femaleNames, ref _femaleName);
        }

        public static string GetNextMaleImage()
        {
            return GeNext(_maleImages, ref _maleImage);
        }

        public static string GeNextFemaleImage()
        {
            return GeNext(_femaleImages, ref _femaleImage);
        }

        private static List<string> _maleNames = new List<string>
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

        private static List<string> _femaleNames = new List<string>
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
            "Ruth",
            "Sharon"
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
            "m8"
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
            "f8"
        };

        private static int _maleName, _femaleName;
        private static int _maleImage, _femaleImage;

        public static string GetNextMaleName()
        {
            var name =  _maleNames[_maleName];

            if (_maleName == _maleNames.Count - 1)
            {
                _maleName = 0;
            }
            else
            {
                _maleName++;
            }

            return name;
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
    }
}
