using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x3 = new Level
        {
            TableNumber = 5,
            Time = 80,
            Target = 10,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H10, Hobby.H12, Hobby.H24 },
                new List<Hobby> { Hobby.H10, Hobby.H16, Hobby.H12, Hobby.H17, Hobby.H1, Hobby.H20 },
                new List<Hobby> { Hobby.H11, Hobby.H18, Hobby.H17, Hobby.H3, Hobby.H15, Hobby.H19, Hobby.H20 },
                new List<Hobby> { Hobby.H20, Hobby.H15, Hobby.H9, Hobby.H8, Hobby.H11, Hobby.H23, Hobby.H18, Hobby.H3 },
                new List<Hobby> { Hobby.H17, Hobby.H18, Hobby.H22, Hobby.H21, Hobby.H24 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H19, Hobby.H9, Hobby.H7, Hobby.H16, Hobby.H4 },
                new List<Hobby> { Hobby.H16, Hobby.H12, Hobby.H8, Hobby.H18, Hobby.H22, Hobby.H24, Hobby.H10 },
                new List<Hobby> { Hobby.H18, Hobby.H20, Hobby.H23, Hobby.H22, Hobby.H8, Hobby.H16, Hobby.H19, Hobby.H14 },
                new List<Hobby> { Hobby.H23, Hobby.H21, Hobby.H14 },
                new List<Hobby> { Hobby.H14, Hobby.H15, Hobby.H23 }
            },
            Сomplexity = 3
        };
    }
}