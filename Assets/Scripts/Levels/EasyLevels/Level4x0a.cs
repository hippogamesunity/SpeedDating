using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x0a = new Level
        {
            TableNumber = 4,
            Time = 60,
            Target = 8,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H24, Hobby.H14, Hobby.H6, Hobby.H10, Hobby.H8 },
                new List<Hobby> { Hobby.H21, Hobby.H20, Hobby.H5, Hobby.H12, Hobby.H3, Hobby.H22 },
                new List<Hobby> { Hobby.H5, Hobby.H2, Hobby.H14, Hobby.H13, Hobby.H11 },
                new List<Hobby> { Hobby.H8, Hobby.H17, Hobby.H21, Hobby.H16, Hobby.H7, Hobby.H11 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H15, Hobby.H24, Hobby.H4, Hobby.H20, Hobby.H2, Hobby.H22, Hobby.H1, Hobby.H19 },
                new List<Hobby> { Hobby.H16, Hobby.H13, Hobby.H6, Hobby.H15, Hobby.H4, Hobby.H18, Hobby.H12 },
                new List<Hobby> { Hobby.H12, Hobby.H24, Hobby.H11, Hobby.H20, Hobby.H5, Hobby.H3 },
                new List<Hobby> { Hobby.H13, Hobby.H1, Hobby.H10, Hobby.H6, Hobby.H4, Hobby.H8 }
            },
            Сomplexity = 0
        };
    }
}