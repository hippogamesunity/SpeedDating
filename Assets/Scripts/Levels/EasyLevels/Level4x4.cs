using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x4 = new Level
        {
            TableNumber = 4,
            Time = 80,
            Target = 8,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H15, Hobby.H24, Hobby.H12 },
                new List<Hobby> { Hobby.H5, Hobby.H17, Hobby.H22, Hobby.H12, Hobby.H13, Hobby.H23, Hobby.H14, Hobby.H9 },
                new List<Hobby> { Hobby.H3, Hobby.H1, Hobby.H11, Hobby.H22, Hobby.H13 },
                new List<Hobby> { Hobby.H17, Hobby.H24, Hobby.H8, Hobby.H20, Hobby.H3 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H17, Hobby.H2, Hobby.H1, Hobby.H12, Hobby.H24, Hobby.H21 },
                new List<Hobby> { Hobby.H11, Hobby.H5, Hobby.H17 },
                new List<Hobby> { Hobby.H14, Hobby.H12, Hobby.H21, Hobby.H15 },
                new List<Hobby> { Hobby.H1, Hobby.H14, Hobby.H8, Hobby.H3, Hobby.H21, Hobby.H15, Hobby.H16 }
            },
            Сomplexity = 4
        };
    }
}