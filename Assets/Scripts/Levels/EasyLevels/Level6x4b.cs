using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x4b = new Level
        {
            TableNumber = 6,
            Time = 150,
            Target = 13,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H18, Hobby.H15, Hobby.H7, Hobby.H4, Hobby.H20, Hobby.H9 },
                new List<Hobby> { Hobby.H23, Hobby.H4, Hobby.H21, Hobby.H1, Hobby.H6, Hobby.H3, Hobby.H19, Hobby.H9 },
                new List<Hobby> { Hobby.H16, Hobby.H13, Hobby.H7, Hobby.H12, Hobby.H5, Hobby.H9 },
                new List<Hobby> { Hobby.H18, Hobby.H12, Hobby.H21, Hobby.H16, Hobby.H6, Hobby.H23, Hobby.H17 },
                new List<Hobby> { Hobby.H17, Hobby.H4, Hobby.H2, Hobby.H7, Hobby.H10 },
                new List<Hobby> { Hobby.H14, Hobby.H2, Hobby.H8, Hobby.H3, Hobby.H9, Hobby.H18 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H4, Hobby.H21, Hobby.H12, Hobby.H11, Hobby.H20, Hobby.H9, Hobby.H16 },
                new List<Hobby> { Hobby.H3, Hobby.H24, Hobby.H20 },
                new List<Hobby> { Hobby.H18, Hobby.H20, Hobby.H23, Hobby.H13, Hobby.H9 },
                new List<Hobby> { Hobby.H9, Hobby.H21, Hobby.H4, Hobby.H6, Hobby.H18, Hobby.H19, Hobby.H23 },
                new List<Hobby> { Hobby.H15, Hobby.H1, Hobby.H18 },
                new List<Hobby> { Hobby.H24, Hobby.H16, Hobby.H1, Hobby.H4, Hobby.H19, Hobby.H13, Hobby.H3, Hobby.H14 }
            },
            Сomplexity = 4
        };
    }
}