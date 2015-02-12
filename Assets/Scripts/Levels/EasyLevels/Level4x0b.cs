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
                new List<Hobby> { Hobby.Animals, Hobby.Guitar, Hobby.Pictures, Hobby.Beauty, Hobby.Flowers, Hobby.Fashion, Hobby.Sex },
                new List<Hobby> { Hobby.Fishing, Hobby.Music, Hobby.Photo, Hobby.Money, Hobby.Work },
                new List<Hobby> { Hobby.Games, Hobby.Singing, Hobby.Cars, Hobby.Skate, Hobby.Guitar, Hobby.Sex },
                new List<Hobby> { Hobby.Books, Hobby.Beauty, Hobby.Sex, Hobby.Animals, Hobby.Fishing, Hobby.Games }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Games, Hobby.Fishing, Hobby.Books, Hobby.Singing, Hobby.Work, Hobby.Skate, Hobby.Football },
                new List<Hobby> { Hobby.Beauty, Hobby.Money, Hobby.Food, Hobby.Football, Hobby.TV, Hobby.Animals, Hobby.Guitar, Hobby.Books },
                new List<Hobby> { Hobby.Sex, Hobby.Fishing, Hobby.Guitar, Hobby.Singing, Hobby.Flowers },
                new List<Hobby> { Hobby.Jewelry, Hobby.Photo, Hobby.Fishing, Hobby.Money, Hobby.Animals }
            },
            Сomplexity = 0
        };
    }
}