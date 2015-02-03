using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x1 = new Level
        {
            TableNumber = 5,
            Time = 80,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Singing, Hobby.Animals, Hobby.Skate, Hobby.Sex },
                new List<Hobby> { Hobby.Music, Hobby.Guitar, Hobby.Fishing, Hobby.Running, Hobby.Football },
                new List<Hobby> { Hobby.Flowers, Hobby.Animals, Hobby.Beauty, Hobby.Sex, Hobby.Drink },
                new List<Hobby> { Hobby.Flowers, Hobby.Animals, Hobby.Music, Hobby.Jewelry, Hobby.Fishing, Hobby.Fashion },
                new List<Hobby> { Hobby.Food, Hobby.Work, Hobby.Singing, Hobby.Sex, Hobby.Skate, Hobby.Cars, Hobby.Games, Hobby.Books }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Archery, Hobby.TV, Hobby.Jewelry, Hobby.Singing, Hobby.Games },
                new List<Hobby> { Hobby.Sex, Hobby.Money, Hobby.Guitar, Hobby.Animals },
                new List<Hobby> { Hobby.Drink, Hobby.Music, Hobby.Money, Hobby.Fishing, Hobby.Fashion, Hobby.Running },
                new List<Hobby> { Hobby.Cars, Hobby.Work, Hobby.Games, Hobby.Archery, Hobby.Money, Hobby.Guitar, Hobby.Football },
                new List<Hobby> { Hobby.Singing, Hobby.Guitar, Hobby.Music, Hobby.Flowers, Hobby.Animals, Hobby.Photo, Hobby.Pictures, Hobby.Fashion }
            },
            Сomplexity = 1
        };
    }
}