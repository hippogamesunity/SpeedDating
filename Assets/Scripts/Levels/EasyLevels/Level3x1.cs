using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level3x1 = new Level
        {
            TableNumber = 3,
            Time = 40,
            Target = 8,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H4, Hobby.H16, Hobby.H9, Hobby.H24, Hobby.H15, Hobby.H19, Hobby.H18, Hobby.H20 },
                new List<Hobby> { Hobby.H17, Hobby.H24, Hobby.H6, Hobby.H15, Hobby.H14, Hobby.H16, Hobby.H10, Hobby.H23 },
                new List<Hobby> { Hobby.H19, Hobby.H13, Hobby.H12, Hobby.H7, Hobby.H11, Hobby.H1, Hobby.H10 }

            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H5, Hobby.H10, Hobby.H12, Hobby.H3, Hobby.H8, Hobby.H20, Hobby.H11, Hobby.H6 },
                new List<Hobby> { Hobby.H16, Hobby.H12, Hobby.H23, Hobby.H2, Hobby.H3, Hobby.H13, Hobby.H11 },
                new List<Hobby> { Hobby.H6, Hobby.H20, Hobby.H15, Hobby.H17, Hobby.H3, Hobby.H12, Hobby.H9, Hobby.H11 }
            },
            Сomplexity = 1
        };
    }
}