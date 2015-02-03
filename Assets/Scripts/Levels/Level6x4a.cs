using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x4a = new Level
        {
            TableNumber = 6,
            Time = 140,
            Target = 11,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Fashion, Hobby.Beauty, Hobby.Cars, Hobby.Animals },
                new List<Hobby> { Hobby.Football, Hobby.Running, Hobby.Cars, Hobby.Drink, Hobby.Archery, Hobby.Games, Hobby.Pictures, Hobby.Flowers },
                new List<Hobby> { Hobby.Drink, Hobby.Photo, Hobby.Guitar, Hobby.Jewelry, Hobby.Running, Hobby.Sex, Hobby.Pictures },
                new List<Hobby> { Hobby.Beauty, Hobby.Jewelry, Hobby.Singing, Hobby.Flowers, Hobby.Animals },
                new List<Hobby> { Hobby.Work, Hobby.Sex, Hobby.Beauty, Hobby.Jewelry, Hobby.Football, Hobby.Drink, Hobby.Cars },
                new List<Hobby> { Hobby.Cars, Hobby.Photo, Hobby.Drink }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Singing, Hobby.Games, Hobby.Archery, Hobby.Photo },
                new List<Hobby> { Hobby.Fishing, Hobby.Pictures, Hobby.Drink },
                new List<Hobby> { Hobby.Photo, Hobby.Money, Hobby.Work, Hobby.Drink },
                new List<Hobby> { Hobby.Singing, Hobby.Drink, Hobby.Guitar, Hobby.Cars, Hobby.Books, Hobby.Music, Hobby.TV },
                new List<Hobby> { Hobby.TV, Hobby.Cars, Hobby.Guitar, Hobby.Music, Hobby.Beauty, Hobby.Money },
                new List<Hobby> { Hobby.Food, Hobby.Sex, Hobby.Fishing, Hobby.Running, Hobby.Flowers }
            },
            Сomplexity = 4
        };
    }
}