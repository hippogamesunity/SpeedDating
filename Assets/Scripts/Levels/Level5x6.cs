using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x6 = new Level
        {
            TableNumber = 5,
            Time = 120,
            Target = 10,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Skate, Hobby.Flowers, Hobby.Jewelry, Hobby.Archery, Hobby.Music, Hobby.Animals, Hobby.TV },
                new List<Hobby> { Hobby.Fashion, Hobby.Games, Hobby.Books, Hobby.Flowers },
                new List<Hobby> { Hobby.Fishing, Hobby.Money, Hobby.Guitar, Hobby.Animals, Hobby.Food, Hobby.Fashion },
                new List<Hobby> { Hobby.Football, Hobby.Fashion, Hobby.Music, Hobby.Jewelry, Hobby.Guitar, Hobby.Running },
                new List<Hobby> { Hobby.Skate, Hobby.Money, Hobby.Work, Hobby.Jewelry }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Books, Hobby.Running, Hobby.Archery, Hobby.Fishing, Hobby.Sex, Hobby.Football, Hobby.TV },
                new List<Hobby> { Hobby.Flowers, Hobby.Work, Hobby.Jewelry, Hobby.Fishing, Hobby.Football },
                new List<Hobby> { Hobby.Pictures, Hobby.Money, Hobby.Music, Hobby.Archery, Hobby.Beauty },
                new List<Hobby> { Hobby.Food, Hobby.Photo, Hobby.TV, Hobby.Drink, Hobby.Archery, Hobby.Guitar, Hobby.Football },
                new List<Hobby> { Hobby.Books, Hobby.Jewelry, Hobby.Fashion, Hobby.Cars, Hobby.Beauty }
            },
            Generator = true,
            Сomplexity = 6
        };
    }
}