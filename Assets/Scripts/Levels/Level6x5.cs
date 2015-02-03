using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x5 = new Level
        {
            TableNumber = 6,
            Time = 140,
            Target = 13,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Football, Hobby.Fishing, Hobby.Work, Hobby.Singing, Hobby.Guitar, Hobby.Archery },
                new List<Hobby> { Hobby.Music, Hobby.Singing, Hobby.Jewelry, Hobby.Pictures, Hobby.TV, Hobby.Sex, Hobby.Games, Hobby.Archery },
                new List<Hobby> { Hobby.Flowers, Hobby.Drink, Hobby.Work, Hobby.Cars, Hobby.Skate, Hobby.Archery },
                new List<Hobby> { Hobby.Football, Hobby.Cars, Hobby.Jewelry, Hobby.Flowers, Hobby.TV, Hobby.Music, Hobby.Food },
                new List<Hobby> { Hobby.Food, Hobby.Singing, Hobby.Running, Hobby.Work, Hobby.Beauty },
                new List<Hobby> { Hobby.Fashion, Hobby.Running, Hobby.Animals, Hobby.Sex, Hobby.Archery, Hobby.Football }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Singing, Hobby.Jewelry, Hobby.Cars, Hobby.Books, Hobby.Guitar, Hobby.Archery, Hobby.Flowers },
                new List<Hobby> { Hobby.Sex, Hobby.Photo, Hobby.Guitar },
                new List<Hobby> { Hobby.Football, Hobby.Guitar, Hobby.Music, Hobby.Drink, Hobby.Archery },
                new List<Hobby> { Hobby.Archery, Hobby.Jewelry, Hobby.Singing, Hobby.TV, Hobby.Football, Hobby.Games, Hobby.Music },
                new List<Hobby> { Hobby.Fishing, Hobby.Pictures, Hobby.Football },
                new List<Hobby> { Hobby.Photo, Hobby.Flowers, Hobby.Pictures, Hobby.Singing, Hobby.Games, Hobby.Drink, Hobby.Sex, Hobby.Fashion }
            },
            Сomplexity = 5
        };
    }
}