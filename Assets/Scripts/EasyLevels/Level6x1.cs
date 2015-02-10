using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x1 = new Level
        {
            TableNumber = 6,
            Time = 80,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Archery, Hobby.Drink, Hobby.Jewelry, Hobby.Music },
                new List<Hobby> { Hobby.Beauty, Hobby.Jewelry, Hobby.Cars, Hobby.Animals, Hobby.Archery },
                new List<Hobby> { Hobby.Beauty, Hobby.Football, Hobby.Archery, Hobby.Fashion, Hobby.Running, Hobby.Pictures },
                new List<Hobby> { Hobby.Skate, Hobby.TV, Hobby.Music, Hobby.Football },
                new List<Hobby> { Hobby.Fishing, Hobby.Sex, Hobby.Photo, Hobby.Drink, Hobby.Skate, Hobby.Music },
                new List<Hobby> { Hobby.Fishing, Hobby.Pictures, Hobby.Drink }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Cars, Hobby.TV, Hobby.Jewelry, Hobby.Food, Hobby.Archery, Hobby.Music, Hobby.Guitar, Hobby.Running },
                new List<Hobby> { Hobby.Flowers, Hobby.Cars, Hobby.Money, Hobby.Running },
                new List<Hobby> { Hobby.Work, Hobby.Books, Hobby.Flowers, Hobby.Animals, Hobby.Jewelry, Hobby.Sex, Hobby.Fashion, Hobby.Archery },
                new List<Hobby> { Hobby.Photo, Hobby.TV, Hobby.Beauty, Hobby.Money, Hobby.Jewelry, Hobby.Drink, Hobby.Running, Hobby.Fishing },
                new List<Hobby> { Hobby.Guitar, Hobby.Archery, Hobby.Drink },
                new List<Hobby> { Hobby.Fashion, Hobby.Games, Hobby.Drink, Hobby.Food, Hobby.Work, Hobby.Money, Hobby.TV }
            },
            Сomplexity = 1
        };
    }
}