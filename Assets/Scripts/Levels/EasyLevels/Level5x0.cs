using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x0 = new Level
        {
            TableNumber = 5,
            Time = 60,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H8, Hobby.H7, Hobby.H12, Hobby.H1, Hobby.H18 },
                new List<Hobby> { Hobby.H15, Hobby.H18, Hobby.H3, Hobby.H16, Hobby.H1, Hobby.H2, Hobby.H6 },
                new List<Hobby> { Hobby.H4, Hobby.H15, Hobby.H12, Hobby.H11 },
                new List<Hobby> { Hobby.H23, Hobby.H15, Hobby.H24, Hobby.H13, Hobby.H12, Hobby.H19, Hobby.H9 },
                new List<Hobby> { Hobby.H22, Hobby.H12, Hobby.H20, Hobby.H10, Hobby.H6, Hobby.H23, Hobby.H13, Hobby.H16 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H20, Hobby.H7, Hobby.H8, Hobby.H13, Hobby.H2, Hobby.H9 },
                new List<Hobby> { Hobby.H8, Hobby.H23, Hobby.H14, Hobby.H6, Hobby.H22 },
                new List<Hobby> { Hobby.H9, Hobby.H4, Hobby.H1, Hobby.H6, Hobby.H5, Hobby.H15 },
                new List<Hobby> { Hobby.H3, Hobby.H21, Hobby.H9, Hobby.H14, Hobby.H10, Hobby.H23 },
                new List<Hobby> { Hobby.H14, Hobby.H13, Hobby.H15, Hobby.H11, Hobby.H18 }
            },
            Сomplexity = 0
        };
    }
}