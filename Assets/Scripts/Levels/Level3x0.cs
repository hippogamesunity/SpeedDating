using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level3x0 = new Level
        {
            TableNumber = 4,
            Time = 30,
            Target = 8,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Work, Hobby.Jewelry, Hobby.Drink, Hobby.Food, Hobby.Fishing },
                new List<Hobby> { Hobby.Singing, Hobby.Sex, Hobby.Cars, Hobby.Games, Hobby.Beauty, Hobby.Skate },
                new List<Hobby> { Hobby.Cars, Hobby.Archery, Hobby.Jewelry, Hobby.Guitar, Hobby.Football },
                new List<Hobby> { Hobby.Fishing, Hobby.Photo, Hobby.Singing, Hobby.Music, Hobby.Fashion, Hobby.Football }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Money, Hobby.Work, Hobby.Books, Hobby.Sex, Hobby.Archery, Hobby.Skate, Hobby.Animals, Hobby.Running },
                new List<Hobby> { Hobby.Music, Hobby.Guitar, Hobby.Drink, Hobby.Money, Hobby.Books, Hobby.Pictures, Hobby.Games },
                new List<Hobby> { Hobby.Games, Hobby.Work, Hobby.Football, Hobby.Sex, Hobby.Cars, Hobby.Beauty },
                new List<Hobby> { Hobby.Guitar, Hobby.Animals, Hobby.Food, Hobby.Drink, Hobby.Books, Hobby.Fishing }
            },
            Сomplexity = 0
        };
    }
}