using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x5 = new Level
        {
            TableNumber = 4,
            Time = 80,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H15, Hobby.H2, Hobby.H1, Hobby.H11, Hobby.H6, Hobby.H18, Hobby.H23 },
                new List<Hobby> { Hobby.H7, Hobby.H15, Hobby.H19, Hobby.H20, Hobby.H9, Hobby.H17, Hobby.H11 },
                new List<Hobby> { Hobby.H14, Hobby.H15, Hobby.H4, Hobby.H11, Hobby.H3, Hobby.H16, Hobby.H17, Hobby.H6 },
                new List<Hobby> { Hobby.H8, Hobby.H3, Hobby.H10, Hobby.H17, Hobby.H21, Hobby.H1, Hobby.H19 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H23, Hobby.H15, Hobby.H5, Hobby.H24, Hobby.H13, Hobby.H8, Hobby.H18 },
                new List<Hobby> { Hobby.H17, Hobby.H6, Hobby.H18, Hobby.H23, Hobby.H21, Hobby.H9, Hobby.H13, Hobby.H3 },
                new List<Hobby> { Hobby.H4, Hobby.H23, Hobby.H6, Hobby.H12, Hobby.H3, Hobby.H7, Hobby.H13 },
                new List<Hobby> { Hobby.H4, Hobby.H17, Hobby.H19, Hobby.H23, Hobby.H15, Hobby.H1, Hobby.H18, Hobby.H13 },
            },
            Сomplexity = 5
        };
    }
}