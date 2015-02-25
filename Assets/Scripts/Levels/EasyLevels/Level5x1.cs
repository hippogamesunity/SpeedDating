using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x1 = new Level
        {
            TableNumber = 5,
            Time = 80,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H21, Hobby.H1, Hobby.H22, Hobby.H20 },
                new List<Hobby> { Hobby.H16, Hobby.H13, Hobby.H8, Hobby.H19, Hobby.H11 },
                new List<Hobby> { Hobby.H9, Hobby.H1, Hobby.H3, Hobby.H20, Hobby.H6 },
                new List<Hobby> { Hobby.H9, Hobby.H1, Hobby.H16, Hobby.H14, Hobby.H8, Hobby.H7 },
                new List<Hobby> { Hobby.H10, Hobby.H24, Hobby.H21, Hobby.H20, Hobby.H22, Hobby.H5, Hobby.H12, Hobby.H4 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H2, Hobby.H23, Hobby.H14, Hobby.H21, Hobby.H12 },
                new List<Hobby> { Hobby.H20, Hobby.H15, Hobby.H13, Hobby.H1 },
                new List<Hobby> { Hobby.H6, Hobby.H16, Hobby.H15, Hobby.H8, Hobby.H7, Hobby.H19 },
                new List<Hobby> { Hobby.H5, Hobby.H24, Hobby.H12, Hobby.H2, Hobby.H15, Hobby.H13, Hobby.H11 },
                new List<Hobby> { Hobby.H21, Hobby.H13, Hobby.H16, Hobby.H9, Hobby.H1, Hobby.H17, Hobby.H18, Hobby.H7 }
            },
            Сomplexity = 1
        };
    }
}