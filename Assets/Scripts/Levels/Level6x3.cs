using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x3 = new Level
        {
            TableNumber = 6,
            Time = 100,
            Target = 14,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Skate, Hobby.Football, Hobby.Jewelry, Hobby.Books, Hobby.Money, Hobby.Animals, Hobby.Fashion, Hobby.Food },
                new List<Hobby> { Hobby.Food, Hobby.Flowers, Hobby.Football, Hobby.Animals, Hobby.Pictures },
                new List<Hobby> { Hobby.Running, Hobby.Guitar, Hobby.Books, Hobby.Animals, Hobby.Singing, Hobby.Work },
                new List<Hobby> { Hobby.TV, Hobby.Fashion, Hobby.Pictures, Hobby.Animals },
                new List<Hobby> { Hobby.Work, Hobby.Sex, Hobby.Food, Hobby.TV, Hobby.Music, Hobby.Guitar, Hobby.Cars, Hobby.Animals },
                new List<Hobby> { Hobby.Photo, Hobby.Skate, Hobby.Beauty, Hobby.Archery, Hobby.Jewelry, Hobby.Music, Hobby.Fishing }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Running, Hobby.Pictures, Hobby.Flowers, Hobby.Guitar },
                new List<Hobby> { Hobby.Running, Hobby.Money, Hobby.Food },
                new List<Hobby> { Hobby.Games, Hobby.Pictures, Hobby.Football, Hobby.Cars },
                new List<Hobby> { Hobby.Cars, Hobby.Food, Hobby.Beauty, Hobby.Books, Hobby.Jewelry, Hobby.Pictures, Hobby.TV },
                new List<Hobby> { Hobby.Jewelry, Hobby.Fashion, Hobby.Money, Hobby.Sex, Hobby.Animals, Hobby.Flowers, Hobby.Skate, Hobby.Photo },
                new List<Hobby> { Hobby.Beauty, Hobby.Fashion, Hobby.Music, Hobby.Photo, Hobby.Cars, Hobby.Skate, Hobby.Drink, Hobby.Food }
            },
            Сomplexity = 3
        };
    }
}