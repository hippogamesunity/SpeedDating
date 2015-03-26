using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x2 = new Level
        {
            TableNumber = 5,
            Time = 60,
            Target = 10,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H10, Hobby.H8, Hobby.H13, Hobby.H6, Hobby.H15 },
                new List<Hobby> { Hobby.H15, Hobby.H14, Hobby.H19, Hobby.H12, Hobby.H16, Hobby.H21 },
                new List<Hobby> { Hobby.H9, Hobby.H20, Hobby.H3, Hobby.H4, Hobby.H23, Hobby.H5 },
                new List<Hobby> { Hobby.H1, Hobby.H7, Hobby.H17, Hobby.H2, Hobby.H8, Hobby.H21, Hobby.H13 },
                new List<Hobby> { Hobby.H19, Hobby.H8, Hobby.H12, Hobby.H2, Hobby.H24, Hobby.H20, Hobby.H9, Hobby.H13 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H24, Hobby.H22, Hobby.H7, Hobby.H14, Hobby.H2, Hobby.H15, Hobby.H17, Hobby.H10 },
                new List<Hobby> { Hobby.H11, Hobby.H9, Hobby.H5 },
                new List<Hobby> { Hobby.H12, Hobby.H1, Hobby.H18, Hobby.H10, Hobby.H20, Hobby.H7, Hobby.H21 },
                new List<Hobby> { Hobby.H1, Hobby.H20, Hobby.H14, Hobby.H17, Hobby.H7, Hobby.H23 },
                new List<Hobby> { Hobby.H4, Hobby.H5, Hobby.H12 }
            },
            Сomplexity = 2
        };
    }
}