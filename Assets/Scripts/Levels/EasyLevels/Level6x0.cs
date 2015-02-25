using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x0 = new Level
        {
            TableNumber = 6,
            Time = 60,
            Target = 14,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H7, Hobby.H20, Hobby.H14, Hobby.H18, Hobby.H12, Hobby.H4 },
                new List<Hobby> { Hobby.H9, Hobby.H4, Hobby.H23, Hobby.H12, Hobby.H22, Hobby.H8, Hobby.H5, Hobby.H20 },
                new List<Hobby> { Hobby.H12, Hobby.H3, Hobby.H7, Hobby.H11, Hobby.H17, Hobby.H13, Hobby.H8 },
                new List<Hobby> { Hobby.H3, Hobby.H19, Hobby.H2, Hobby.H20, Hobby.H10 },
                new List<Hobby> { Hobby.H2, Hobby.H3, Hobby.H20 },
                new List<Hobby> { Hobby.H8, Hobby.H18, Hobby.H19, Hobby.H10, Hobby.H4, Hobby.H21, Hobby.H14 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H24, Hobby.H14, Hobby.H2, Hobby.H6, Hobby.H3, Hobby.H10, Hobby.H12, Hobby.H9 },
                new List<Hobby> { Hobby.H4, Hobby.H8, Hobby.H16, Hobby.H10, Hobby.H13, Hobby.H1, Hobby.H22 },
                new List<Hobby> { Hobby.H12, Hobby.H10, Hobby.H21, Hobby.H20, Hobby.H4 },
                new List<Hobby> { Hobby.H10, Hobby.H4, Hobby.H24, Hobby.H3, Hobby.H22, Hobby.H15, Hobby.H8, Hobby.H1 },
                new List<Hobby> { Hobby.H14, Hobby.H12, Hobby.H21, Hobby.H5 },
                new List<Hobby> { Hobby.H1, Hobby.H10, Hobby.H21, Hobby.H16, Hobby.H22, Hobby.H13, Hobby.H18, Hobby.H2 }
            },
            Сomplexity = 0
        };
    }
}