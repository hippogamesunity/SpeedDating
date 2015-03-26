using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x4 = new Level
        {
            TableNumber = 5,
            Time = 60,
            Target = 9,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H24, Hobby.H1, Hobby.H8 },
                new List<Hobby> { Hobby.H13, Hobby.H12, Hobby.H22, Hobby.H17, Hobby.H14, Hobby.H18, Hobby.H20 },
                new List<Hobby> { Hobby.H15, Hobby.H1, Hobby.H2, Hobby.H14, Hobby.H8, Hobby.H23, Hobby.H19, Hobby.H17 },
                new List<Hobby> { Hobby.H9, Hobby.H12, Hobby.H1 },
                new List<Hobby> { Hobby.H4, Hobby.H15, Hobby.H13, Hobby.H14, Hobby.H23 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H23, Hobby.H10, Hobby.H1, Hobby.H13 },
                new List<Hobby> { Hobby.H12, Hobby.H20, Hobby.H16 },
                new List<Hobby> { Hobby.H10, Hobby.H12, Hobby.H5, Hobby.H19, Hobby.H4, Hobby.H3, Hobby.H14 },
                new List<Hobby> { Hobby.H4, Hobby.H12, Hobby.H20, Hobby.H3, Hobby.H1, Hobby.H21 },
                new List<Hobby> { Hobby.H23, Hobby.H16, Hobby.H15 }
            },
            Сomplexity = 4
        };
    }
}