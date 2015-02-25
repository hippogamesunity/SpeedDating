using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x0b = new Level
        {
            TableNumber = 4,
            Time = 60,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H1, Hobby.H13, Hobby.H18, Hobby.H3, Hobby.H9, Hobby.H7, Hobby.H20 },
                new List<Hobby> { Hobby.H8, Hobby.H16, Hobby.H17, Hobby.H15, Hobby.H24 },
                new List<Hobby> { Hobby.H12, Hobby.H21, Hobby.H5, Hobby.H22, Hobby.H13, Hobby.H20 },
                new List<Hobby> { Hobby.H4, Hobby.H3, Hobby.H20, Hobby.H1, Hobby.H8, Hobby.H12 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H12, Hobby.H8, Hobby.H4, Hobby.H21, Hobby.H24, Hobby.H22, Hobby.H11 },
                new List<Hobby> { Hobby.H3, Hobby.H15, Hobby.H10, Hobby.H11, Hobby.H23, Hobby.H1, Hobby.H13, Hobby.H4 },
                new List<Hobby> { Hobby.H20, Hobby.H8, Hobby.H13, Hobby.H21, Hobby.H9 },
                new List<Hobby> { Hobby.H14, Hobby.H17, Hobby.H8, Hobby.H15, Hobby.H1 }
            },
            Сomplexity = 0
        };
    }
}