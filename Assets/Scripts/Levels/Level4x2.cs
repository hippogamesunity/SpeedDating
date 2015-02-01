using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x2 = new Level
        {
            TableNumber = 4,
            Time = 60,
            Target = 10,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Pictures, Hobby.Singing, Hobby.Music, Hobby.Games, Hobby.Skate, Hobby.Food, Hobby.Football },
                new List<Hobby> { Hobby.Jewelry, Hobby.Photo, Hobby.Fishing, Hobby.Books, Hobby.Singing, Hobby.Beauty, Hobby.Sex },
                new List<Hobby> { Hobby.Food, Hobby.Fishing, Hobby.Singing, Hobby.Flowers, Hobby.TV },
                new List<Hobby> { Hobby.Drink, Hobby.Music, Hobby.Jewelry, Hobby.TV, Hobby.Sex, Hobby.Fashion, Hobby.Photo }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Games, Hobby.Singing, Hobby.Work, Hobby.Food, Hobby.Flowers, Hobby.Beauty, Hobby.Books },
                new List<Hobby> { Hobby.Skate, Hobby.Music, Hobby.Guitar, Hobby.Football },
                new List<Hobby> { Hobby.Books, Hobby.Football, Hobby.Cars, Hobby.Music, Hobby.Guitar, Hobby.Fishing },
                new List<Hobby> { Hobby.Work, Hobby.Sex, Hobby.Photo, Hobby.Fishing, Hobby.Games }
            },
            Сomplexity = 2
        };
    }
}