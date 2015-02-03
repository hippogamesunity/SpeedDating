using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level6x4b = new Level
        {
            TableNumber = 6,
            Time = 140,
            Target = 13,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Pictures, Hobby.Money, Hobby.Fashion, Hobby.Books, Hobby.Sex, Hobby.Flowers },
                new List<Hobby> { Hobby.TV, Hobby.Books, Hobby.Singing, Hobby.Animals, Hobby.Drink, Hobby.Beauty, Hobby.Running, Hobby.Flowers },
                new List<Hobby> { Hobby.Music, Hobby.Guitar, Hobby.Fashion, Hobby.Games, Hobby.Cars, Hobby.Flowers },
                new List<Hobby> { Hobby.Pictures, Hobby.Games, Hobby.Singing, Hobby.Music, Hobby.Drink, Hobby.TV, Hobby.Photo },
                new List<Hobby> { Hobby.Photo, Hobby.Books, Hobby.Archery, Hobby.Fashion, Hobby.Food },
                new List<Hobby> { Hobby.Jewelry, Hobby.Archery, Hobby.Fishing, Hobby.Beauty, Hobby.Flowers, Hobby.Pictures }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Books, Hobby.Singing, Hobby.Games, Hobby.Football, Hobby.Sex, Hobby.Flowers, Hobby.Music },
                new List<Hobby> { Hobby.Beauty, Hobby.Work, Hobby.Sex },
                new List<Hobby> { Hobby.Pictures, Hobby.Sex, Hobby.TV, Hobby.Guitar, Hobby.Flowers },
                new List<Hobby> { Hobby.Flowers, Hobby.Singing, Hobby.Books, Hobby.Drink, Hobby.Pictures, Hobby.Running, Hobby.TV },
                new List<Hobby> { Hobby.Money, Hobby.Animals, Hobby.Pictures },
                new List<Hobby> { Hobby.Work, Hobby.Music, Hobby.Animals, Hobby.Books, Hobby.Running, Hobby.Guitar, Hobby.Beauty, Hobby.Jewelry }
            },
            Сomplexity = 4
        };
    }
}