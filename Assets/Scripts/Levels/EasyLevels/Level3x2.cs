using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level3x2 = new Level
        {
            TableNumber = 3,
            Time = 40,
            Target = 6,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H1, Hobby.H22, Hobby.H19, Hobby.H4 },
                new List<Hobby> { Hobby.H16, Hobby.H17, Hobby.H2, Hobby.H6, Hobby.H1 },
                new List<Hobby> { Hobby.H7, Hobby.H11, Hobby.H24, Hobby.H20, Hobby.H16 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H10, Hobby.H5, Hobby.H4, Hobby.H16, Hobby.H2, Hobby.H22 },
                new List<Hobby> { Hobby.H3, Hobby.H7, Hobby.H1, Hobby.H21, Hobby.H11, Hobby.H17 },
                new List<Hobby> { Hobby.H6, Hobby.H22, Hobby.H14, Hobby.H3, Hobby.H21, Hobby.H17, Hobby.H8, Hobby.H23 }
            },
            Сomplexity = 2
        };
    }
}