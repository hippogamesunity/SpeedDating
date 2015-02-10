using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x5a = new Level
        {
            TableNumber = 5,
            Time = 120,
            Target = 14,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Archery, Hobby.Beauty, Hobby.Fishing, Hobby.Cars, Hobby.Fashion, Hobby.Guitar },
                new List<Hobby> { Hobby.Fishing, Hobby.Fashion, Hobby.Work, Hobby.Money, Hobby.Running, Hobby.Pictures, Hobby.Flowers, Hobby.Beauty },
                new List<Hobby> { Hobby.Archery, Hobby.Fashion, Hobby.Books, Hobby.TV },
                new List<Hobby> { Hobby.Fashion, Hobby.Archery, Hobby.Sex, Hobby.Beauty, Hobby.TV },
                new List<Hobby> { Hobby.Running, Hobby.Sex, Hobby.Archery, Hobby.Beauty, Hobby.Cars, Hobby.Food, Hobby.Flowers, Hobby.Animals }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Guitar, Hobby.Football, Hobby.Fishing, Hobby.Animals, Hobby.Money, Hobby.Flowers, Hobby.Cars, Hobby.Games },
                new List<Hobby> { Hobby.Archery, Hobby.Beauty, Hobby.Music, Hobby.Flowers, Hobby.Food },
                new List<Hobby> { Hobby.Music, Hobby.Beauty, Hobby.TV, Hobby.Food, Hobby.Photo, Hobby.Singing, Hobby.Sex },
                new List<Hobby> { Hobby.Singing, Hobby.Money, Hobby.Fishing },
                new List<Hobby> { Hobby.Fishing, Hobby.Beauty, Hobby.Skate, Hobby.Books, Hobby.Archery, Hobby.TV }
            },
            Сomplexity = 5
        };
    }
}