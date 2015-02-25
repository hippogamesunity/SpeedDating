using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level2x0 = new Level
        {
            TableNumber = 2,
            Time = 30,
            Target = 6,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H1, Hobby.H18, Hobby.H11, Hobby.H5 },
                new List<Hobby> { Hobby.H4, Hobby.H10, Hobby.H12, Hobby.H6 },
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.H1, Hobby.H18, Hobby.H11, Hobby.H4},
                new List<Hobby> { Hobby.H4, Hobby.H10, Hobby.H12, Hobby.H18 },
            }
        };
    }
}