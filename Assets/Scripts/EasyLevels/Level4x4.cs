using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level4x4 = new Level
        {
            TableNumber = 4,
            Time = 80,
            Target = 8,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Money, Hobby.Work, Hobby.Games },
                new List<Hobby> { Hobby.Cars, Hobby.Photo, Hobby.Skate, Hobby.Games, Hobby.Guitar, Hobby.TV, Hobby.Jewelry, Hobby.Flowers },
                new List<Hobby> { Hobby.Beauty, Hobby.Animals, Hobby.Football, Hobby.Skate, Hobby.Guitar },
                new List<Hobby> { Hobby.Photo, Hobby.Work, Hobby.Fishing, Hobby.Sex, Hobby.Beauty }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Photo, Hobby.Archery, Hobby.Animals, Hobby.Games, Hobby.Work, Hobby.Singing },
                new List<Hobby> { Hobby.Football, Hobby.Cars, Hobby.Photo },
                new List<Hobby> { Hobby.Jewelry, Hobby.Games, Hobby.Singing, Hobby.Money },
                new List<Hobby> { Hobby.Animals, Hobby.Jewelry, Hobby.Fishing, Hobby.Beauty, Hobby.Singing, Hobby.Money, Hobby.Music }
            },
            Сomplexity = 4
        };
    }
}