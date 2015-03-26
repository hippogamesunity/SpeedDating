using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x3 = new Level
        {
            TableNumber = 6,
            Time = 80,
            Target = 14,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H22, Hobby.H11, Hobby.H14, Hobby.H4, Hobby.H15, Hobby.H1, Hobby.H7, Hobby.H10 },
                new List<Hobby> { Hobby.H10, Hobby.H9, Hobby.H11, Hobby.H1, Hobby.H18 },
                new List<Hobby> { Hobby.H19, Hobby.H13, Hobby.H4, Hobby.H1, Hobby.H21, Hobby.H24 },
                new List<Hobby> { Hobby.H23, Hobby.H7, Hobby.H18, Hobby.H1 },
                new List<Hobby> { Hobby.H24, Hobby.H20, Hobby.H10, Hobby.H23, Hobby.H16, Hobby.H13, Hobby.H5, Hobby.H1 },
                new List<Hobby> { Hobby.H17, Hobby.H22, Hobby.H3, Hobby.H2, Hobby.H14, Hobby.H16, Hobby.H8 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H19, Hobby.H18, Hobby.H9, Hobby.H13 },
                new List<Hobby> { Hobby.H19, Hobby.H15, Hobby.H10 },
                new List<Hobby> { Hobby.H12, Hobby.H18, Hobby.H11, Hobby.H5 },
                new List<Hobby> { Hobby.H5, Hobby.H10, Hobby.H3, Hobby.H4, Hobby.H14, Hobby.H18, Hobby.H23 },
                new List<Hobby> { Hobby.H14, Hobby.H7, Hobby.H15, Hobby.H20, Hobby.H1, Hobby.H9, Hobby.H22, Hobby.H17 },
                new List<Hobby> { Hobby.H3, Hobby.H7, Hobby.H16, Hobby.H17, Hobby.H5, Hobby.H22, Hobby.H6, Hobby.H10 }
            },
            Сomplexity = 3
        };
    }
}