using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x3 = new Level
        {
            TableNumber = 4,
            Time = 60,
            Target = 11,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H11, Hobby.H7, Hobby.H14, Hobby.H16, Hobby.H15, Hobby.H2, Hobby.H19, Hobby.H21 },
                new List<Hobby> { Hobby.H9, Hobby.H24, Hobby.H1, Hobby.H20, Hobby.H18, Hobby.H15, Hobby.H16, Hobby.H8 },
                new List<Hobby> { Hobby.H5, Hobby.H15, Hobby.H1, Hobby.H12, Hobby.H24, Hobby.H2, Hobby.H14, Hobby.H10 },
                new List<Hobby> { Hobby.H5, Hobby.H18, Hobby.H23 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H14, Hobby.H23, Hobby.H9, Hobby.H1, Hobby.H3, Hobby.H10, Hobby.H6 },
                new List<Hobby> { Hobby.H21, Hobby.H10, Hobby.H14, Hobby.H15, Hobby.H18 },
                new List<Hobby> { Hobby.H14, Hobby.H2, Hobby.H18, Hobby.H1, Hobby.H8 },
                new List<Hobby> { Hobby.H14, Hobby.H22, Hobby.H17, Hobby.H9, Hobby.H5, Hobby.H6, Hobby.H10, Hobby.H18 }
            },
            Сomplexity = 3
        };
    }
}