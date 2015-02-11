using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static List<Level> MemoLevels
        {
            get
            {
                return new List<Level>
                {
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 10,
                        MemoizeTime = 5,
                        TableNumber = 2,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Football, Hobby.Cars },
                            new List<Hobby> { Hobby.Books, Hobby.Food, Hobby.Games, Hobby.Drink },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Football, Hobby.Books},
                            new List<Hobby> { Hobby.Books, Hobby.Food, Hobby.Games, Hobby.Pictures },
                        },
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 10,
                        MemoizeTime = 10,
                        TableNumber = 3,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Animals, Hobby.Skate, Hobby.Running, Hobby.Books },
                            new List<Hobby> { Hobby.Music, Hobby.Photo, Hobby.Archery, Hobby.Drink, Hobby.Animals },
                            new List<Hobby> { Hobby.Fashion, Hobby.Football, Hobby.Work, Hobby.Sex, Hobby.Music }
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Food, Hobby.Cars, Hobby.Books, Hobby.Music, Hobby.Archery, Hobby.Skate },
                            new List<Hobby> { Hobby.Beauty, Hobby.Fashion, Hobby.Animals, Hobby.Singing, Hobby.Football, Hobby.Photo },
                            new List<Hobby> { Hobby.Drink, Hobby.Skate, Hobby.Jewelry, Hobby.Beauty, Hobby.Singing, Hobby.Photo, Hobby.Fishing, Hobby.TV }
                        }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 10,
                        MemoizeTime = 10,
                        TableNumber = 4,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Photo, Hobby.Sex, Hobby.Food, Hobby.Animals, Hobby.Archery, Hobby.Money, Hobby.Flowers, Hobby.Work },
                            new List<Hobby> { Hobby.Photo, Hobby.Football, Hobby.Archery, Hobby.Games, Hobby.Drink, Hobby.Money, Hobby.Work, Hobby.TV },
                            new List<Hobby> { Hobby.Food, Hobby.Work, Hobby.Football },
                            new List<Hobby> { Hobby.Fishing, Hobby.Running, Hobby.Cars, Hobby.Drink, Hobby.Games, Hobby.Singing },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Food, Hobby.Fishing, Hobby.Cars, Hobby.Games, Hobby.Books, Hobby.Work, Hobby.Skate },
                            new List<Hobby> { Hobby.Jewelry, Hobby.Books, Hobby.Archery, Hobby.Skate, Hobby.Animals, Hobby.Sex, Hobby.Photo, Hobby.Work },
                            new List<Hobby> { Hobby.Photo, Hobby.Pictures, Hobby.Beauty, Hobby.Work, Hobby.Animals, Hobby.Sex, Hobby.Cars },
                            new List<Hobby> { Hobby.Pictures, Hobby.Fishing, Hobby.Games, Hobby.Photo },
                        }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 15,
                        MemoizeTime = 15,
                        TableNumber = 5,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Jewelry, Hobby.Sex, Hobby.Skate },
                            new List<Hobby> { Hobby.Guitar, Hobby.Archery, Hobby.Beauty, Hobby.Books, Hobby.Games, Hobby.TV, Hobby.Singing, Hobby.Money },
                            new List<Hobby> { Hobby.Sex, Hobby.Guitar, Hobby.Skate },
                            new List<Hobby> { Hobby.Cars, Hobby.Beauty, Hobby.Fashion, Hobby.Fishing, Hobby.Singing, Hobby.Work },
                            new List<Hobby> { Hobby.Flowers, Hobby.Singing, Hobby.Books, Hobby.Cars, Hobby.Photo, Hobby.Football },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Money, Hobby.Skate, Hobby.Singing, Hobby.Photo, Hobby.Archery, Hobby.Beauty, Hobby.Cars },
                            new List<Hobby> { Hobby.Music, Hobby.Skate, Hobby.TV, Hobby.Games, Hobby.Work, Hobby.Drink },
                            new List<Hobby> { Hobby.Jewelry, Hobby.Football, Hobby.Animals, Hobby.Fishing, Hobby.Music, Hobby.Fashion, Hobby.Flowers, Hobby.Work },
                            new List<Hobby> { Hobby.Games, Hobby.Pictures, Hobby.Singing, Hobby.Cars, Hobby.Drink, Hobby.Work, Hobby.Running },
                            new List<Hobby> { Hobby.Guitar, Hobby.TV, Hobby.Jewelry, Hobby.Food, Hobby.Football, Hobby.Singing },
                        }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 20,
                        TableNumber = 6,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Food, Hobby.Archery, Hobby.Animals, Hobby.Flowers, Hobby.Singing },
                            new List<Hobby> { Hobby.Music, Hobby.Skate, Hobby.Beauty, Hobby.Photo, Hobby.Cars, Hobby.Sex, Hobby.Archery, Hobby.Games },
                            new List<Hobby> { Hobby.Drink, Hobby.Running, Hobby.Money, Hobby.Beauty },
                            new List<Hobby> { Hobby.Animals, Hobby.Sex, Hobby.Money, Hobby.Food, Hobby.Fashion, Hobby.Music },
                            new List<Hobby> { Hobby.Photo, Hobby.Books, Hobby.Running, Hobby.Work, Hobby.Sex, Hobby.Fashion, Hobby.Singing, Hobby.Fishing },
                            new List<Hobby> { Hobby.Skate, Hobby.Drink, Hobby.Singing, Hobby.Football, Hobby.Fishing, Hobby.Pictures },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Flowers, Hobby.Food, Hobby.Skate, Hobby.Archery, Hobby.Sex, Hobby.Running, Hobby.Games },
                            new List<Hobby> { Hobby.Sex, Hobby.Archery, Hobby.Running, Hobby.Cars, Hobby.Books, Hobby.Jewelry, Hobby.Skate },
                            new List<Hobby> { Hobby.Drink, Hobby.Photo, Hobby.Animals, Hobby.Singing, Hobby.Fashion },
                            new List<Hobby> { Hobby.Food, Hobby.Games, Hobby.Fishing, Hobby.Guitar, Hobby.Running, Hobby.Music },
                            new List<Hobby> { Hobby.Flowers, Hobby.Photo, Hobby.Work, Hobby.Cars, Hobby.Jewelry, Hobby.Running, Hobby.Fishing, Hobby.Money },
                            new List<Hobby> { Hobby.Skate, Hobby.Fishing, Hobby.Music, Hobby.Beauty, Hobby.Drink },
                        },
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 25,
                        TableNumber = 7,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Books, Hobby.Work, Hobby.Money, Hobby.Drink },
                            new List<Hobby> { Hobby.Books, Hobby.Running, Hobby.Skate, Hobby.Drink, Hobby.Music, Hobby.Fishing, Hobby.Singing, Hobby.Food },
                            new List<Hobby> { Hobby.Guitar, Hobby.Fishing, Hobby.Drink, Hobby.Skate, Hobby.Jewelry },
                            new List<Hobby> { Hobby.Food, Hobby.Money, Hobby.Cars, Hobby.Singing, Hobby.TV, Hobby.Running, Hobby.Games, Hobby.Sex },
                            new List<Hobby> { Hobby.Skate, Hobby.Drink, Hobby.Work, Hobby.Food, Hobby.Cars, Hobby.Football },
                            new List<Hobby> { Hobby.Flowers, Hobby.Running, Hobby.Drink, Hobby.Sex, Hobby.Cars, Hobby.Animals },
                            new List<Hobby> { Hobby.Animals, Hobby.Cars, Hobby.Guitar },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Football, Hobby.Cars, Hobby.Flowers, Hobby.Work, Hobby.Jewelry },
                            new List<Hobby> { Hobby.Singing, Hobby.Archery, Hobby.Photo, Hobby.Animals, Hobby.Cars },
                            new List<Hobby> { Hobby.Pictures, Hobby.Food, Hobby.Books, Hobby.Beauty, Hobby.Football, Hobby.Skate, Hobby.Archery },
                            new List<Hobby> { Hobby.Cars, Hobby.Skate, Hobby.Fishing, Hobby.Work, Hobby.Beauty, Hobby.Food, Hobby.Guitar },
                            new List<Hobby> { Hobby.Singing, Hobby.Cars, Hobby.Books, Hobby.Archery },
                            new List<Hobby> { Hobby.Football, Hobby.Pictures, Hobby.Fishing, Hobby.Books },
                            new List<Hobby> { Hobby.Cars, Hobby.Guitar, Hobby.Skate, Hobby.Flowers, Hobby.Fashion, Hobby.Money, Hobby.Football, Hobby.Sex },
                        },
                        Formation = new List<List<int>> { new List<int> { 6, 1 }, new List<int> { 5, 2 }, new List<int> { 4, 0 }, new List<int> { 3, 3 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 30,
                        TableNumber = 8,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Flowers, Hobby.Games, Hobby.Food, Hobby.Money, Hobby.Football, Hobby.Photo, Hobby.Work },
                            new List<Hobby> { Hobby.Flowers, Hobby.Guitar, Hobby.Money, Hobby.Games, Hobby.Cars, Hobby.Animals },
                            new List<Hobby> { Hobby.Books, Hobby.Beauty, Hobby.Food, Hobby.Fashion, Hobby.Sex, Hobby.Music },
                            new List<Hobby> { Hobby.Fashion, Hobby.TV, Hobby.Money, Hobby.Animals, Hobby.Flowers, Hobby.Books, Hobby.Games, Hobby.Pictures },
                            new List<Hobby> { Hobby.Music, Hobby.Singing, Hobby.Animals },
                            new List<Hobby> { Hobby.Books, Hobby.Running, Hobby.Photo, Hobby.Fashion },
                            new List<Hobby> { Hobby.Animals, Hobby.Flowers, Hobby.Photo, Hobby.Skate, Hobby.Drink },
                            new List<Hobby> { Hobby.Fashion, Hobby.Sex, Hobby.Fishing, Hobby.Drink, Hobby.Cars, Hobby.Photo },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.Running, Hobby.Drink, Hobby.Guitar, Hobby.Food, Hobby.Archery, Hobby.Fashion, Hobby.TV, Hobby.Work },
                            new List<Hobby> { Hobby.Football, Hobby.Jewelry, Hobby.Fashion, Hobby.Photo, Hobby.Cars, Hobby.Skate, Hobby.Books },
                            new List<Hobby> { Hobby.Guitar, Hobby.Drink, Hobby.Jewelry, Hobby.Music, Hobby.Work },
                            new List<Hobby> { Hobby.Food, Hobby.Animals, Hobby.Jewelry, Hobby.Football, Hobby.Music },
                            new List<Hobby> { Hobby.Beauty, Hobby.Singing, Hobby.Guitar, Hobby.Games, Hobby.Flowers },
                            new List<Hobby> { Hobby.Beauty, Hobby.Drink, Hobby.Pictures, Hobby.Archery, Hobby.Money },
                            new List<Hobby> { Hobby.Running, Hobby.Cars, Hobby.Photo, Hobby.Music, Hobby.Fashion, Hobby.Sex },
                            new List<Hobby> { Hobby.Music, Hobby.Sex, Hobby.Football },
                        },
                        Formation = new List<List<int>> { new List<int> { 7, 3 }, new List<int> { 6, 7 }, new List<int> { 5, 4 }, new List<int> { 4, 0 }, new List<int> { 3, 2 }, new List<int> { 2, 5 }, new List<int> { 1, 1 }, new List<int> { 0, 6 } }
                    }
                };
            }
        }
    }
}