using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x6 = new Level
        {
            TableNumber = 5,
            Time = 120,
            Target = 10,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H22, Hobby.H9, Hobby.H14, Hobby.H2, Hobby.H16, Hobby.H1, Hobby.H23 },
                new List<Hobby> { Hobby.H7, Hobby.H12, Hobby.H4, Hobby.H9 },
                new List<Hobby> { Hobby.H8, Hobby.H15, Hobby.H13, Hobby.H1, Hobby.H10, Hobby.H7 },
                new List<Hobby> { Hobby.H11, Hobby.H7, Hobby.H16, Hobby.H14, Hobby.H13, Hobby.H19 },
                new List<Hobby> { Hobby.H22, Hobby.H15, Hobby.H24, Hobby.H14 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H4, Hobby.H19, Hobby.H2, Hobby.H8, Hobby.H20, Hobby.H11, Hobby.H23 },
                new List<Hobby> { Hobby.H9, Hobby.H24, Hobby.H14, Hobby.H8, Hobby.H11 },
                new List<Hobby> { Hobby.H18, Hobby.H15, Hobby.H16, Hobby.H2, Hobby.H3 },
                new List<Hobby> { Hobby.H10, Hobby.H17, Hobby.H23, Hobby.H6, Hobby.H2, Hobby.H13, Hobby.H11 },
                new List<Hobby> { Hobby.H4, Hobby.H14, Hobby.H7, Hobby.H5, Hobby.H3 }
            },
            Сomplexity = 6
        };
    }
}