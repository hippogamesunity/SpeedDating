using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x5b = new Level
        {
            TableNumber = 5,
            Time = 120,
            Target = 13,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Games, Hobby.Animals, Hobby.Archery, Hobby.Skate, Hobby.Guitar, Hobby.Running, Hobby.Flowers },
                new List<Hobby> { Hobby.Singing, Hobby.Fashion, Hobby.Flowers, Hobby.Cars, Hobby.Work },
                new List<Hobby> { Hobby.Games, Hobby.Pictures, Hobby.Work, Hobby.Guitar, Hobby.Fishing },
                new List<Hobby> { Hobby.Food, Hobby.Skate, Hobby.Music, Hobby.Drink, Hobby.Archery, Hobby.Sex, Hobby.Singing, Hobby.Guitar },
                new List<Hobby> { Hobby.Books, Hobby.Football, Hobby.Drink, Hobby.Pictures, Hobby.Photo, Hobby.Skate, Hobby.Flowers, Hobby.Games }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Games, Hobby.Sex, Hobby.Flowers, Hobby.Pictures, Hobby.Fishing },
                new List<Hobby> { Hobby.Food, Hobby.Football, Hobby.Skate, Hobby.Jewelry, Hobby.Archery, Hobby.Beauty, Hobby.Drink },
                new List<Hobby> { Hobby.TV, Hobby.Games, Hobby.Guitar, Hobby.Music },
                new List<Hobby> { Hobby.Animals, Hobby.Food, Hobby.Sex, Hobby.Singing, Hobby.Money, Hobby.Books },
                new List<Hobby> { Hobby.Drink, Hobby.Flowers, Hobby.Animals, Hobby.Skate, Hobby.Singing, Hobby.Guitar, Hobby.Music, Hobby.Beauty }
            },
            Сomplexity = 5
        };
    }
}