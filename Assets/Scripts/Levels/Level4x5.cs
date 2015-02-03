using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x5 = new Level
        {
            TableNumber = 4,
            Time = 80,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Money, Hobby.Archery, Hobby.Animals, Hobby.Football, Hobby.Drink, Hobby.Pictures, Hobby.TV },
                new List<Hobby> { Hobby.Fashion, Hobby.Money, Hobby.Running, Hobby.Sex, Hobby.Flowers, Hobby.Photo, Hobby.Football },
                new List<Hobby> { Hobby.Jewelry, Hobby.Money, Hobby.Books, Hobby.Football, Hobby.Beauty, Hobby.Music, Hobby.Photo, Hobby.Drink },
                new List<Hobby> { Hobby.Fishing, Hobby.Beauty, Hobby.Food, Hobby.Photo, Hobby.Singing, Hobby.Animals, Hobby.Running }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.TV, Hobby.Money, Hobby.Cars, Hobby.Work, Hobby.Guitar, Hobby.Fishing, Hobby.Pictures },
                new List<Hobby> { Hobby.Photo, Hobby.Drink, Hobby.Pictures, Hobby.TV, Hobby.Singing, Hobby.Flowers, Hobby.Guitar, Hobby.Beauty },
                new List<Hobby> { Hobby.Books, Hobby.TV, Hobby.Drink, Hobby.Games, Hobby.Beauty, Hobby.Fashion, Hobby.Guitar },
                new List<Hobby> { Hobby.Books, Hobby.Photo, Hobby.Running, Hobby.TV, Hobby.Money, Hobby.Animals, Hobby.Pictures, Hobby.Guitar },
            },
            Сomplexity = 5
        };
    }
}