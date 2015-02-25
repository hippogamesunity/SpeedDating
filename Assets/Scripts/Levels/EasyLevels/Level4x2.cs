using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x2 = new Level
        {
            TableNumber = 4,
            Time = 60,
            Target = 10,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H18, Hobby.H21, Hobby.H16, Hobby.H12, Hobby.H22, Hobby.H10, Hobby.H11 },
                new List<Hobby> { Hobby.H14, Hobby.H17, Hobby.H8, Hobby.H4, Hobby.H21, Hobby.H3, Hobby.H20 },
                new List<Hobby> { Hobby.H10, Hobby.H8, Hobby.H21, Hobby.H9, Hobby.H23 },
                new List<Hobby> { Hobby.H6, Hobby.H16, Hobby.H14, Hobby.H23, Hobby.H20, Hobby.H7, Hobby.H17 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H12, Hobby.H21, Hobby.H24, Hobby.H10, Hobby.H9, Hobby.H3, Hobby.H4 },
                new List<Hobby> { Hobby.H22, Hobby.H16, Hobby.H13, Hobby.H11 },
                new List<Hobby> { Hobby.H4, Hobby.H11, Hobby.H5, Hobby.H16, Hobby.H13, Hobby.H8 },
                new List<Hobby> { Hobby.H24, Hobby.H20, Hobby.H17, Hobby.H8, Hobby.H12 }
            },
            Сomplexity = 2
        };
    }
}