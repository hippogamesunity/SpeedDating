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
                new List<Hobby> { Hobby.Food, Hobby.Games, Hobby.Work },
                new List<Hobby> { Hobby.Food, Hobby.Music, Hobby.Games, Hobby.Photo, Hobby.Animals, Hobby.Sex },
                new List<Hobby> { Hobby.Football, Hobby.Pictures, Hobby.Photo, Hobby.Beauty, Hobby.Money, Hobby.Running, Hobby.Sex },
                new List<Hobby> { Hobby.Sex, Hobby.Money, Hobby.Flowers, Hobby.Fishing, Hobby.Football, Hobby.TV, Hobby.Pictures, Hobby.Beauty },
                new List<Hobby> { Hobby.Photo, Hobby.Pictures, Hobby.Skate, Hobby.Singing, Hobby.Work }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Running, Hobby.Flowers, Hobby.Fashion, Hobby.Music, Hobby.Books },
                new List<Hobby> { Hobby.Music, Hobby.Games, Hobby.Fishing, Hobby.Pictures, Hobby.Skate, Hobby.Work, Hobby.Food },
                new List<Hobby> { Hobby.Pictures, Hobby.Sex, Hobby.TV, Hobby.Skate, Hobby.Fishing, Hobby.Music, Hobby.Running, Hobby.Jewelry },
                new List<Hobby> { Hobby.TV, Hobby.Singing, Hobby.Jewelry },
                new List<Hobby> { Hobby.Jewelry, Hobby.Money, Hobby.TV }
            },
            Сomplexity = 3
        };
    }
}