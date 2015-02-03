using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x0 = new Level
        {
            TableNumber = 5,
            Time = 80,
            Target = 12,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Fishing, Hobby.Fashion, Hobby.Games, Hobby.Animals, Hobby.Pictures },
                new List<Hobby> { Hobby.Money, Hobby.Pictures, Hobby.Beauty, Hobby.Music, Hobby.Animals, Hobby.Archery, Hobby.Drink },
                new List<Hobby> { Hobby.Books, Hobby.Money, Hobby.Games, Hobby.Football },
                new List<Hobby> { Hobby.TV, Hobby.Money, Hobby.Work, Hobby.Guitar, Hobby.Games, Hobby.Running, Hobby.Flowers },
                new List<Hobby> { Hobby.Skate, Hobby.Games, Hobby.Sex, Hobby.Food, Hobby.Drink, Hobby.TV, Hobby.Guitar, Hobby.Music }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Sex, Hobby.Fashion, Hobby.Fishing, Hobby.Guitar, Hobby.Archery, Hobby.Flowers },
                new List<Hobby> { Hobby.Fishing, Hobby.TV, Hobby.Jewelry, Hobby.Drink, Hobby.Skate },
                new List<Hobby> { Hobby.Flowers, Hobby.Books, Hobby.Animals, Hobby.Drink, Hobby.Cars, Hobby.Money },
                new List<Hobby> { Hobby.Beauty, Hobby.Singing, Hobby.Flowers, Hobby.Jewelry, Hobby.Food, Hobby.TV },
                new List<Hobby> { Hobby.Jewelry, Hobby.Guitar, Hobby.Money, Hobby.Football, Hobby.Pictures }
            },
            Сomplexity = 0
        };
    }
}