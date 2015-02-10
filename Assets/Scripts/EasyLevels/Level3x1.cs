using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level3x1 = new Level
        {
            TableNumber = 3,
            Time = 40,
            Target = 8,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Books, Hobby.Music, Hobby.Flowers, Hobby.Work, Hobby.Money, Hobby.Running, Hobby.Pictures, Hobby.Sex },
                new List<Hobby> { Hobby.Photo, Hobby.Work, Hobby.Drink, Hobby.Money, Hobby.Jewelry, Hobby.Music, Hobby.Food, Hobby.TV },
                new List<Hobby> { Hobby.Running, Hobby.Guitar, Hobby.Games, Hobby.Fashion, Hobby.Football, Hobby.Animals, Hobby.Food }

            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Cars, Hobby.Food, Hobby.Games, Hobby.Beauty, Hobby.Fishing, Hobby.Sex, Hobby.Football, Hobby.Drink },
                new List<Hobby> { Hobby.Music, Hobby.Games, Hobby.TV, Hobby.Archery, Hobby.Beauty, Hobby.Guitar, Hobby.Football },
                new List<Hobby> { Hobby.Drink, Hobby.Sex, Hobby.Money, Hobby.Photo, Hobby.Beauty, Hobby.Games, Hobby.Flowers, Hobby.Football }
            },
            Сomplexity = 1
        };
    }
}