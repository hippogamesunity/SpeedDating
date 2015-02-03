using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x3 = new Level
        {
            TableNumber = 4,
            Time = 60,
            Target = 11,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Football, Hobby.Fashion, Hobby.Jewelry, Hobby.Music, Hobby.Money, Hobby.Archery, Hobby.Running, Hobby.Singing },
                new List<Hobby> { Hobby.Flowers, Hobby.Work, Hobby.Animals, Hobby.Sex, Hobby.Pictures, Hobby.Money, Hobby.Music, Hobby.Fishing },
                new List<Hobby> { Hobby.Cars, Hobby.Money, Hobby.Animals, Hobby.Games, Hobby.Work, Hobby.Archery, Hobby.Jewelry, Hobby.Food },
                new List<Hobby> { Hobby.Cars, Hobby.Pictures, Hobby.TV }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Jewelry, Hobby.TV, Hobby.Flowers, Hobby.Animals, Hobby.Beauty, Hobby.Food, Hobby.Drink },
                new List<Hobby> { Hobby.Singing, Hobby.Food, Hobby.Jewelry, Hobby.Money, Hobby.Pictures },
                new List<Hobby> { Hobby.Jewelry, Hobby.Archery, Hobby.Pictures, Hobby.Animals, Hobby.Fishing },
                new List<Hobby> { Hobby.Jewelry, Hobby.Skate, Hobby.Photo, Hobby.Flowers, Hobby.Cars, Hobby.Drink, Hobby.Food, Hobby.Pictures }
            },
            Сomplexity = 3
        };
    }
}