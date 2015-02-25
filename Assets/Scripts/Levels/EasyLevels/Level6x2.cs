using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x2 = new Level
        {
            TableNumber = 6,
            Time = 120,
            Target = 13,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H6, Hobby.H21, Hobby.H2, Hobby.H24, Hobby.H16 },
                new List<Hobby> { Hobby.H22, Hobby.H12, Hobby.H3, Hobby.H21 },
                new List<Hobby> { Hobby.H16, Hobby.H21, Hobby.H2, Hobby.H12, Hobby.H4, Hobby.H7, Hobby.H10 },
                new List<Hobby> { Hobby.H21, Hobby.H18, Hobby.H13, Hobby.H17, Hobby.H2 },
                new List<Hobby> { Hobby.H5, Hobby.H14, Hobby.H10 },
                new List<Hobby> { Hobby.H24, Hobby.H8, Hobby.H21, Hobby.H13, Hobby.H12 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H5, Hobby.H18, Hobby.H4 },
                new List<Hobby> { Hobby.H16, Hobby.H12, Hobby.H1, Hobby.H22, Hobby.H18, Hobby.H10, Hobby.H4 },
                new List<Hobby> { Hobby.H14, Hobby.H6, Hobby.H17, Hobby.H12 },
                new List<Hobby> { Hobby.H11, Hobby.H10, Hobby.H19, Hobby.H2, Hobby.H5, Hobby.H17, Hobby.H14 },
                new List<Hobby> { Hobby.H24, Hobby.H22, Hobby.H4, Hobby.H12, Hobby.H21, Hobby.H18, Hobby.H15 },
                new List<Hobby> { Hobby.H18, Hobby.H10, Hobby.H12, Hobby.H22, Hobby.H15, Hobby.H4, Hobby.H11, Hobby.H23 }
            },
            Сomplexity = 2
        };
    }
}