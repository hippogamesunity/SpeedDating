using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x0 = new Level
        {
            TableNumber = 6,
            Time = 60,
            Target = 14,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Fashion, Hobby.Sex, Hobby.Jewelry, Hobby.Pictures, Hobby.Games, Hobby.Books },
                new List<Hobby> { Hobby.Flowers, Hobby.Books, Hobby.TV, Hobby.Games, Hobby.Skate, Hobby.Fishing, Hobby.Cars, Hobby.Sex },
                new List<Hobby> { Hobby.Games, Hobby.Beauty, Hobby.Fashion, Hobby.Football, Hobby.Photo, Hobby.Guitar, Hobby.Fishing },
                new List<Hobby> { Hobby.Beauty, Hobby.Running, Hobby.Archery, Hobby.Sex, Hobby.Food },
                new List<Hobby> { Hobby.Archery, Hobby.Beauty, Hobby.Sex },
                new List<Hobby> { Hobby.Fishing, Hobby.Pictures, Hobby.Running, Hobby.Food, Hobby.Books, Hobby.Singing, Hobby.Jewelry }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Work, Hobby.Jewelry, Hobby.Archery, Hobby.Drink, Hobby.Beauty, Hobby.Food, Hobby.Games, Hobby.Flowers },
                new List<Hobby> { Hobby.Books, Hobby.Fishing, Hobby.Music, Hobby.Food, Hobby.Guitar, Hobby.Animals, Hobby.Skate },
                new List<Hobby> { Hobby.Games, Hobby.Food, Hobby.Singing, Hobby.Sex, Hobby.Books },
                new List<Hobby> { Hobby.Food, Hobby.Books, Hobby.Work, Hobby.Beauty, Hobby.Skate, Hobby.Money, Hobby.Fishing, Hobby.Animals },
                new List<Hobby> { Hobby.Jewelry, Hobby.Games, Hobby.Singing, Hobby.Cars },
                new List<Hobby> { Hobby.Animals, Hobby.Food, Hobby.Singing, Hobby.Music, Hobby.Skate, Hobby.Guitar, Hobby.Pictures, Hobby.Archery }
            },
            Сomplexity = 0
        };
    }
}