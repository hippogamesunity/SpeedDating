using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x5b = new Level
        {
            TableNumber = 5,
            Time = 120,
            Target = 13,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H12, Hobby.H1, Hobby.H2, Hobby.H22, Hobby.H13, Hobby.H19, Hobby.H9 },
                new List<Hobby> { Hobby.H21, Hobby.H7, Hobby.H9, Hobby.H5, Hobby.H24 },
                new List<Hobby> { Hobby.H12, Hobby.H18, Hobby.H24, Hobby.H13, Hobby.H8 },
                new List<Hobby> { Hobby.H10, Hobby.H22, Hobby.H16, Hobby.H6, Hobby.H2, Hobby.H20, Hobby.H21, Hobby.H13 },
                new List<Hobby> { Hobby.H4, Hobby.H11, Hobby.H6, Hobby.H18, Hobby.H17, Hobby.H22, Hobby.H9, Hobby.H12 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H12, Hobby.H20, Hobby.H9, Hobby.H18, Hobby.H8 },
                new List<Hobby> { Hobby.H10, Hobby.H11, Hobby.H22, Hobby.H14, Hobby.H2, Hobby.H3, Hobby.H6 },
                new List<Hobby> { Hobby.H23, Hobby.H12, Hobby.H13, Hobby.H16 },
                new List<Hobby> { Hobby.H1, Hobby.H10, Hobby.H20, Hobby.H21, Hobby.H15, Hobby.H4 },
                new List<Hobby> { Hobby.H6, Hobby.H9, Hobby.H1, Hobby.H22, Hobby.H21, Hobby.H13, Hobby.H16, Hobby.H3 }
            },
            Сomplexity = 5
        };
    }
}