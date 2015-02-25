using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x1 = new Level
        {
            TableNumber = 6,
            Time = 80,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H2, Hobby.H6, Hobby.H14, Hobby.H16 },
                new List<Hobby> { Hobby.H3, Hobby.H14, Hobby.H5, Hobby.H1, Hobby.H2 },
                new List<Hobby> { Hobby.H3, Hobby.H11, Hobby.H2, Hobby.H7, Hobby.H19, Hobby.H18 },
                new List<Hobby> { Hobby.H22, Hobby.H23, Hobby.H16, Hobby.H11 },
                new List<Hobby> { Hobby.H8, Hobby.H20, Hobby.H17, Hobby.H6, Hobby.H22, Hobby.H16 },
                new List<Hobby> { Hobby.H8, Hobby.H18, Hobby.H6 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H5, Hobby.H23, Hobby.H14, Hobby.H10, Hobby.H2, Hobby.H16, Hobby.H13, Hobby.H19 },
                new List<Hobby> { Hobby.H9, Hobby.H5, Hobby.H15, Hobby.H19 },
                new List<Hobby> { Hobby.H24, Hobby.H4, Hobby.H9, Hobby.H1, Hobby.H14, Hobby.H20, Hobby.H7, Hobby.H2 },
                new List<Hobby> { Hobby.H17, Hobby.H23, Hobby.H3, Hobby.H15, Hobby.H14, Hobby.H6, Hobby.H19, Hobby.H8 },
                new List<Hobby> { Hobby.H13, Hobby.H2, Hobby.H6 },
                new List<Hobby> { Hobby.H7, Hobby.H12, Hobby.H6, Hobby.H10, Hobby.H24, Hobby.H15, Hobby.H23 }
            },
            Сomplexity = 1
        };
    }
}