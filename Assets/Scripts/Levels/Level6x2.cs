using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x2 = new Level
        {
            TableNumber = 6,
            Time = 100,
            Target = 13,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Drink, Hobby.Singing, Hobby.Archery, Hobby.Work, Hobby.Music },
                new List<Hobby> { Hobby.Skate, Hobby.Games, Hobby.Beauty, Hobby.Singing },
                new List<Hobby> { Hobby.Music, Hobby.Singing, Hobby.Archery, Hobby.Games, Hobby.Books, Hobby.Fashion, Hobby.Food },
                new List<Hobby> { Hobby.Singing, Hobby.Pictures, Hobby.Guitar, Hobby.Photo, Hobby.Archery },
                new List<Hobby> { Hobby.Cars, Hobby.Jewelry, Hobby.Food },
                new List<Hobby> { Hobby.Work, Hobby.Fishing, Hobby.Singing, Hobby.Guitar, Hobby.Games }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Cars, Hobby.Pictures, Hobby.Books },
                new List<Hobby> { Hobby.Music, Hobby.Games, Hobby.Animals, Hobby.Skate, Hobby.Pictures, Hobby.Food, Hobby.Books },
                new List<Hobby> { Hobby.Jewelry, Hobby.Drink, Hobby.Photo, Hobby.Games },
                new List<Hobby> { Hobby.Football, Hobby.Food, Hobby.Running, Hobby.Archery, Hobby.Cars, Hobby.Photo, Hobby.Jewelry },
                new List<Hobby> { Hobby.Work, Hobby.Skate, Hobby.Books, Hobby.Games, Hobby.Singing, Hobby.Pictures, Hobby.Money },
                new List<Hobby> { Hobby.Pictures, Hobby.Food, Hobby.Games, Hobby.Skate, Hobby.Money, Hobby.Books, Hobby.Football, Hobby.TV }
            },
            Сomplexity = 2
        };
    }
}