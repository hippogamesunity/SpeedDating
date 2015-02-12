using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x2 = new Level
        {
            TableNumber = 5,
            Time = 80,
            Target = 10,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Food, Hobby.Fishing, Hobby.Guitar, Hobby.Drink, Hobby.Money },
                new List<Hobby> { Hobby.Money, Hobby.Jewelry, Hobby.Running, Hobby.Games, Hobby.Music, Hobby.Singing },
                new List<Hobby> { Hobby.Flowers, Hobby.Sex, Hobby.Beauty, Hobby.Books, Hobby.TV, Hobby.Cars },
                new List<Hobby> { Hobby.Animals, Hobby.Fashion, Hobby.Photo, Hobby.Archery, Hobby.Fishing, Hobby.Singing, Hobby.Guitar },
                new List<Hobby> { Hobby.Running, Hobby.Fishing, Hobby.Games, Hobby.Archery, Hobby.Work, Hobby.Sex, Hobby.Flowers, Hobby.Guitar }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Work, Hobby.Skate, Hobby.Fashion, Hobby.Jewelry, Hobby.Archery, Hobby.Money, Hobby.Photo, Hobby.Food },
                new List<Hobby> { Hobby.Football, Hobby.Flowers, Hobby.Cars },
                new List<Hobby> { Hobby.Games, Hobby.Animals, Hobby.Pictures, Hobby.Food, Hobby.Sex, Hobby.Fashion, Hobby.Singing },
                new List<Hobby> { Hobby.Animals, Hobby.Sex, Hobby.Jewelry, Hobby.Photo, Hobby.Fashion, Hobby.TV },
                new List<Hobby> { Hobby.Books, Hobby.Cars, Hobby.Games }
            },
            Сomplexity = 2
        };
    }
}