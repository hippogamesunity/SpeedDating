using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level3x0 = new Level
        {
            TableNumber = 3,
            Time = 40,
            Target = 9,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H21, Hobby.H1, Hobby.H3, Hobby.H15, Hobby.H4, Hobby.H6 },
                new List<Hobby> { Hobby.H11, Hobby.H6, Hobby.H16, Hobby.H24, Hobby.H18 },
                new List<Hobby> { Hobby.H18, Hobby.H22, Hobby.H8, Hobby.H23, Hobby.H17 }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H3, Hobby.H15, Hobby.H21, Hobby.H9, Hobby.H22, Hobby.H23, Hobby.H14, Hobby.H12 },
                new List<Hobby> { Hobby.H8, Hobby.H23, Hobby.H11, Hobby.H17, Hobby.H16 },
                new List<Hobby> { Hobby.H7, Hobby.H18, Hobby.H11, Hobby.H16, Hobby.H23, Hobby.H2 }
            },
            Сomplexity = 0
        };
    }
}