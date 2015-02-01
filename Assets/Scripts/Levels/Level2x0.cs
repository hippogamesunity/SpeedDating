using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static Level Level2x0 = new Level
        {
            TableNumber = 2,
            Time = 30,
            Target = 6,
            TableScale = 1,
            MaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Football, Hobby.Cars },
                new List<Hobby> { Hobby.Books, Hobby.Food, Hobby.Games, Hobby.Drink },
            },
            FemaleHobbies = new List<List<Hobby>>
            {
                new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Football, Hobby.Books},
                new List<Hobby> { Hobby.Books, Hobby.Food, Hobby.Games, Hobby.Pictures },
            }
        };
    }
}