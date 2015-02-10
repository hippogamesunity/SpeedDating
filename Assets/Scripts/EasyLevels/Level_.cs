using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level_ = new Level
        {
            TableNumber = 4,
            Time = 120,
            Target = 8,
            MaleHobbies = new List<List<Hobby>>
            {
            },
            FemaleHobbies = new List<List<Hobby>>
            {
            },
            Generator = true,
            Сomplexity = 0
        };
    }
}