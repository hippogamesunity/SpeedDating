using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level3x2 = new Level
        {
            TableNumber = 3,
            Time = 40,
            Target = 6,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Animals, Hobby.Skate, Hobby.Running, Hobby.Books },
                new List<Hobby> { Hobby.Music, Hobby.Photo, Hobby.Archery, Hobby.Drink, Hobby.Animals },
                new List<Hobby> { Hobby.Fashion, Hobby.Football, Hobby.Work, Hobby.Sex, Hobby.Music }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Food, Hobby.Cars, Hobby.Books, Hobby.Music, Hobby.Archery, Hobby.Skate },
                new List<Hobby> { Hobby.Beauty, Hobby.Fashion, Hobby.Animals, Hobby.Singing, Hobby.Football, Hobby.Photo },
                new List<Hobby> { Hobby.Drink, Hobby.Skate, Hobby.Jewelry, Hobby.Beauty, Hobby.Singing, Hobby.Photo, Hobby.Fishing, Hobby.TV }
            },
            Сomplexity = 2
        };
    }
}