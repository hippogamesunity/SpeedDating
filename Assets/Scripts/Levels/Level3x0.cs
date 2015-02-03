using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level3x0 = new Level
        {
            TableNumber = 3,
            Time = 60,
            Target = 9,
            TableScale = 1,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Singing, Hobby.Animals, Hobby.Beauty, Hobby.Money, Hobby.Books, Hobby.Drink },
                new List<Hobby> { Hobby.Football, Hobby.Drink, Hobby.Music, Hobby.Work, Hobby.Pictures },
                new List<Hobby> { Hobby.Pictures, Hobby.Skate, Hobby.Fishing, Hobby.TV, Hobby.Photo }
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Beauty, Hobby.Money, Hobby.Singing, Hobby.Flowers, Hobby.Skate, Hobby.TV, Hobby.Jewelry, Hobby.Games },
                new List<Hobby> { Hobby.Fishing, Hobby.TV, Hobby.Football, Hobby.Photo, Hobby.Music },
                new List<Hobby> { Hobby.Fashion, Hobby.Pictures, Hobby.Football, Hobby.Music, Hobby.TV, Hobby.Archery }
            },
            Сomplexity = 0
        };
    }
}