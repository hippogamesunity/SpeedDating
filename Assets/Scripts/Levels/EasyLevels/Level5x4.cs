using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level5x4 = new Level
        {
            TableNumber = 5,
            Time = 120,
            Target = 9,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Work, Hobby.Animals, Hobby.Fishing },
                new List<Hobby> { Hobby.Guitar, Hobby.Games, Hobby.Skate, Hobby.Photo, Hobby.Jewelry, Hobby.Pictures, Hobby.Sex },
                new List<Hobby> { Hobby.Money, Hobby.Animals, Hobby.Archery, Hobby.Jewelry, Hobby.Fishing, Hobby.TV, Hobby.Running, Hobby.Photo },
                new List<Hobby> { Hobby.Flowers, Hobby.Games, Hobby.Animals },
                new List<Hobby> { Hobby.Books, Hobby.Money, Hobby.Guitar, Hobby.Jewelry, Hobby.TV }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.TV, Hobby.Food, Hobby.Animals, Hobby.Guitar },
                new List<Hobby> { Hobby.Games, Hobby.Sex, Hobby.Music },
                new List<Hobby> { Hobby.Food, Hobby.Games, Hobby.Cars, Hobby.Running, Hobby.Books, Hobby.Beauty, Hobby.Jewelry },
                new List<Hobby> { Hobby.Books, Hobby.Games, Hobby.Sex, Hobby.Beauty, Hobby.Animals, Hobby.Singing },
                new List<Hobby> { Hobby.TV, Hobby.Music, Hobby.Money }
            },
            Сomplexity = 4
        };
    }
}