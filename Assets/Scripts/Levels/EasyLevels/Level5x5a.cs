using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x5a = new Level
        {
            TableNumber = 5,
            Time = 120,
            Target = 14,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H2, Hobby.H3, Hobby.H8, Hobby.H5, Hobby.H7, Hobby.H13 },
                new List<Hobby> { Hobby.H8, Hobby.H7, Hobby.H24, Hobby.H15, Hobby.H19, Hobby.H18, Hobby.H9, Hobby.H3 },
                new List<Hobby> { Hobby.H2, Hobby.H7, Hobby.H4, Hobby.H23 },
                new List<Hobby> { Hobby.H7, Hobby.H2, Hobby.H20, Hobby.H3, Hobby.H23 },
                new List<Hobby> { Hobby.H19, Hobby.H20, Hobby.H2, Hobby.H3, Hobby.H5, Hobby.H10, Hobby.H9, Hobby.H1 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H13, Hobby.H11, Hobby.H8, Hobby.H1, Hobby.H15, Hobby.H9, Hobby.H5, Hobby.H12 },
                new List<Hobby> { Hobby.H2, Hobby.H3, Hobby.H16, Hobby.H9, Hobby.H10 },
                new List<Hobby> { Hobby.H16, Hobby.H3, Hobby.H23, Hobby.H10, Hobby.H17, Hobby.H21, Hobby.H20 },
                new List<Hobby> { Hobby.H21, Hobby.H15, Hobby.H8 },
                new List<Hobby> { Hobby.H8, Hobby.H3, Hobby.H22, Hobby.H4, Hobby.H2, Hobby.H23 }
            },
            Сomplexity = 5
        };
    }
}