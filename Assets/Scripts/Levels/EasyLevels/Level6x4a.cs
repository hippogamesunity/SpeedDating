using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x4a = new Level
        {
            TableNumber = 6,
            Time = 180,
            Target = 11,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H7, Hobby.H3, Hobby.H5, Hobby.H1 },
                new List<Hobby> { Hobby.H11, Hobby.H19, Hobby.H5, Hobby.H6, Hobby.H2, Hobby.H12, Hobby.H18, Hobby.H9 },
                new List<Hobby> { Hobby.H6, Hobby.H17, Hobby.H13, Hobby.H14, Hobby.H19, Hobby.H20, Hobby.H18 },
                new List<Hobby> { Hobby.H3, Hobby.H14, Hobby.H21, Hobby.H9, Hobby.H1 },
                new List<Hobby> { Hobby.H24, Hobby.H20, Hobby.H3, Hobby.H14, Hobby.H11, Hobby.H6, Hobby.H5 },
                new List<Hobby> { Hobby.H5, Hobby.H17, Hobby.H6 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H21, Hobby.H12, Hobby.H2, Hobby.H17 },
                new List<Hobby> { Hobby.H8, Hobby.H18, Hobby.H6 },
                new List<Hobby> { Hobby.H17, Hobby.H15, Hobby.H24, Hobby.H6 },
                new List<Hobby> { Hobby.H21, Hobby.H6, Hobby.H13, Hobby.H5, Hobby.H4, Hobby.H16, Hobby.H23 },
                new List<Hobby> { Hobby.H23, Hobby.H5, Hobby.H13, Hobby.H16, Hobby.H3, Hobby.H15 },
                new List<Hobby> { Hobby.H10, Hobby.H20, Hobby.H8, Hobby.H19, Hobby.H9 }
            },
            Сomplexity = 4
        };
    }
}