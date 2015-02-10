using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static List<Level> SwapLevels
        {
            get
            {
                return new List<Level>
                {
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 3,
                        Swaps = 2,
                        Target = 6,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Sex, Hobby.Money },
                        new List<Hobby> { Hobby.Beauty, Hobby.Food, Hobby.TV, Hobby.Skate, Hobby.Guitar, Hobby.Running, Hobby.Singing },
                        new List<Hobby> { Hobby.Fashion, Hobby.Football, Hobby.Fishing },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Food, Hobby.TV, Hobby.Guitar, Hobby.Books, Hobby.Beauty, Hobby.Work, Hobby.Drink },
                        new List<Hobby> { Hobby.Food, Hobby.Football, Hobby.Archery },
                        new List<Hobby> { Hobby.Photo, Hobby.Games, Hobby.Skate, Hobby.Running, Hobby.Animals, Hobby.Music, Hobby.Money, Hobby.Singing },
                        },
                        Сomplexity = 0
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 3,
                        Swaps = 10,
                        Target = 8,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Guitar, Hobby.Photo, Hobby.Music, Hobby.Work, Hobby.Food, Hobby.Flowers, Hobby.Drink, Hobby.Running },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Fashion, Hobby.Work },
                        new List<Hobby> { Hobby.Money, Hobby.Fashion, Hobby.Running, Hobby.Music, Hobby.Football, Hobby.Animals, Hobby.Work, Hobby.Fishing },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.TV, Hobby.Music, Hobby.Cars, Hobby.Running, Hobby.Flowers, Hobby.Beauty, Hobby.Football },
                        new List<Hobby> { Hobby.Flowers, Hobby.Fashion, Hobby.Skate, Hobby.Food, Hobby.Cars, Hobby.Games, Hobby.Guitar, Hobby.Sex },
                        new List<Hobby> { Hobby.Money, Hobby.Photo, Hobby.Games, Hobby.Jewelry, Hobby.Work, Hobby.Archery, Hobby.Books, Hobby.Guitar },
                        },
                        Сomplexity = 2
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 10,
                        Target = 10,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Photo, Hobby.Singing, Hobby.Games, Hobby.Running, Hobby.Drink, Hobby.Flowers, Hobby.Food, Hobby.Cars },
                        new List<Hobby> { Hobby.TV, Hobby.Singing, Hobby.Flowers, Hobby.Fashion, Hobby.Jewelry, Hobby.Animals },
                        new List<Hobby> { Hobby.Flowers, Hobby.Beauty, Hobby.Work, Hobby.Music, Hobby.Guitar },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Flowers, Hobby.Books, Hobby.Beauty, Hobby.Games, Hobby.Music, Hobby.Fashion },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Music, Hobby.Photo, Hobby.Jewelry, Hobby.Singing, Hobby.Running, Hobby.Sex, Hobby.Cars },
                        new List<Hobby> { Hobby.Archery, Hobby.Books, Hobby.Sex, Hobby.Drink, Hobby.Running, Hobby.Guitar, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Music, Hobby.Work, Hobby.Photo, Hobby.Guitar },
                        new List<Hobby> { Hobby.Pictures, Hobby.Beauty, Hobby.Running, Hobby.Animals, Hobby.Games, Hobby.Fashion },
                        },
                        Сomplexity = 0
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 10,
                        Target = 12,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Guitar, Hobby.Food, Hobby.Skate, Hobby.Books, Hobby.Work, Hobby.Fishing, Hobby.Money, Hobby.Football },
                        new List<Hobby> { Hobby.Money, Hobby.Food, Hobby.Guitar, Hobby.Football, Hobby.Fishing, Hobby.Sex },
                        new List<Hobby> { Hobby.Football, Hobby.Games, Hobby.Beauty, Hobby.Jewelry, Hobby.Singing, Hobby.Fashion, Hobby.Work },
                        new List<Hobby> { Hobby.Food, Hobby.Fashion, Hobby.Photo, Hobby.Work, Hobby.Pictures, Hobby.TV, Hobby.Guitar, Hobby.Jewelry },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.TV, Hobby.Photo, Hobby.Fashion, Hobby.Food, Hobby.Sex, Hobby.Flowers, Hobby.Guitar },
                        new List<Hobby> { Hobby.Pictures, Hobby.Fishing, Hobby.Drink, Hobby.Sex, Hobby.Jewelry, Hobby.Photo, Hobby.Music, Hobby.Fashion },
                        new List<Hobby> { Hobby.Singing, Hobby.Football, Hobby.Work },
                        new List<Hobby> { Hobby.Work, Hobby.Archery, Hobby.Books, Hobby.Jewelry, Hobby.Animals, Hobby.Money },
                        },
                        Сomplexity = 1
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 10,
                        Target = 9,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Football, Hobby.Jewelry, Hobby.Animals, Hobby.Archery, Hobby.Games, Hobby.Work, Hobby.Photo },
                        new List<Hobby> { Hobby.Flowers, Hobby.Fashion, Hobby.Music, Hobby.Football, Hobby.Sex, Hobby.Cars },
                        new List<Hobby> { Hobby.Football, Hobby.Running, Hobby.Skate, Hobby.Music, Hobby.Fishing },
                        new List<Hobby> { Hobby.Singing, Hobby.Skate, Hobby.TV, Hobby.Fashion, Hobby.Drink, Hobby.Games },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Skate, Hobby.Singing, Hobby.Games, Hobby.Guitar, Hobby.Animals, Hobby.Archery, Hobby.Beauty, Hobby.Football },
                        new List<Hobby> { Hobby.Guitar, Hobby.Football, Hobby.Food, Hobby.Sex },
                        new List<Hobby> { Hobby.Games, Hobby.Photo, Hobby.TV, Hobby.Cars, Hobby.Drink, Hobby.Pictures },
                        new List<Hobby> { Hobby.Guitar, Hobby.Animals, Hobby.TV, Hobby.Jewelry, Hobby.Flowers },
                        },
                        Сomplexity = 2
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 11,
                        Target = 9,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Archery, Hobby.Photo, Hobby.Football, Hobby.Singing, Hobby.Jewelry, Hobby.Cars },
                        new List<Hobby> { Hobby.Singing, Hobby.Archery, Hobby.Cars, Hobby.Jewelry, Hobby.Money, Hobby.Running, Hobby.TV, Hobby.Drink },
                        new List<Hobby> { Hobby.Drink, Hobby.Money, Hobby.Sex, Hobby.Archery, Hobby.Running, Hobby.Music, Hobby.Games },
                        new List<Hobby> { Hobby.Music, Hobby.Sex, Hobby.Beauty, Hobby.TV, Hobby.Food, Hobby.Running },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Flowers, Hobby.Sex, Hobby.Running, Hobby.Drink, Hobby.Guitar },
                        new List<Hobby> { Hobby.Flowers, Hobby.TV, Hobby.Books, Hobby.Cars, Hobby.Skate, Hobby.Beauty },
                        new List<Hobby> { Hobby.Photo, Hobby.Running, Hobby.Sex, Hobby.Jewelry, Hobby.Beauty, Hobby.Drink, Hobby.Cars, Hobby.Animals },
                        new List<Hobby> { Hobby.Beauty, Hobby.Books, Hobby.Food, Hobby.Money, Hobby.Skate, Hobby.TV },
                        },
                        Сomplexity = 3
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 10,
                        Target = 10,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Books, Hobby.Pictures, Hobby.Photo, Hobby.Food, Hobby.Drink, Hobby.Cars, Hobby.Games },
                        new List<Hobby> { Hobby.Money, Hobby.Fishing, Hobby.Archery, Hobby.Guitar },
                        new List<Hobby> { Hobby.Fashion, Hobby.Skate, Hobby.Fishing, Hobby.Books, Hobby.Music, Hobby.Guitar, Hobby.Games },
                        new List<Hobby> { Hobby.Football, Hobby.Jewelry, Hobby.Books, Hobby.Photo, Hobby.Pictures, Hobby.Guitar, Hobby.Fashion },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Games, Hobby.Books, Hobby.Pictures, Hobby.TV, Hobby.Food, Hobby.Fishing, Hobby.Guitar, Hobby.Flowers },
                        new List<Hobby> { Hobby.Animals, Hobby.Games, Hobby.Books, Hobby.Cars, Hobby.Archery, Hobby.Food, Hobby.Fashion },
                        new List<Hobby> { Hobby.Fashion, Hobby.Food, Hobby.TV, Hobby.Sex, Hobby.Jewelry, Hobby.Games, Hobby.Animals },
                        new List<Hobby> { Hobby.TV, Hobby.Sex, Hobby.Animals, Hobby.Cars, Hobby.Money, Hobby.Pictures, Hobby.Drink, Hobby.Books },
                        },
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 10,
                        Target = 14,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Books, Hobby.Work, Hobby.Football, Hobby.Fishing, Hobby.Cars, Hobby.Drink, Hobby.Singing, Hobby.Archery },
                        new List<Hobby> { Hobby.TV, Hobby.Fashion, Hobby.Beauty, Hobby.Jewelry, Hobby.Photo, Hobby.Flowers, Hobby.Games, Hobby.Football },
                        new List<Hobby> { Hobby.Games, Hobby.Books, Hobby.Fishing, Hobby.Running, Hobby.Fashion, Hobby.Drink },
                        new List<Hobby> { Hobby.Cars, Hobby.Singing, Hobby.Flowers, Hobby.Beauty, Hobby.Running, Hobby.Fashion, Hobby.Animals },
                        new List<Hobby> { Hobby.Archery, Hobby.TV, Hobby.Money, Hobby.Skate, Hobby.Jewelry, Hobby.Animals },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Singing, Hobby.Work, Hobby.Fishing, Hobby.Food, Hobby.Guitar, Hobby.TV },
                        new List<Hobby> { Hobby.Photo, Hobby.TV, Hobby.Flowers, Hobby.Archery, Hobby.Skate, Hobby.Food },
                        new List<Hobby> { Hobby.Sex, Hobby.Flowers, Hobby.Animals, Hobby.Jewelry, Hobby.Fishing, Hobby.Money, Hobby.Cars, Hobby.Skate },
                        new List<Hobby> { Hobby.Music, Hobby.Fishing, Hobby.Archery, Hobby.Games },
                        new List<Hobby> { Hobby.Archery, Hobby.Photo, Hobby.Running, Hobby.Money, Hobby.TV, Hobby.Fashion, Hobby.Cars, Hobby.Sex },
                        },
                        Сomplexity = 0
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 10,
                        Target = 12,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Sex, Hobby.Books, Hobby.TV },
                        new List<Hobby> { Hobby.Flowers, Hobby.Singing, Hobby.Running, Hobby.Sex, Hobby.Fashion, Hobby.Music, Hobby.TV, Hobby.Fishing },
                        new List<Hobby> { Hobby.Animals, Hobby.Jewelry, Hobby.Games, Hobby.Sex, Hobby.Running },
                        new List<Hobby> { Hobby.Fishing, Hobby.Flowers, Hobby.Games, Hobby.Cars, Hobby.Fashion, Hobby.TV, Hobby.Guitar, Hobby.Pictures },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Music, Hobby.Football, Hobby.Games, Hobby.Work, Hobby.Drink, Hobby.Cars, Hobby.Beauty },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Money, Hobby.Beauty, Hobby.Archery, Hobby.Pictures },
                        new List<Hobby> { Hobby.Beauty, Hobby.Fishing, Hobby.Singing, Hobby.Photo, Hobby.Games },
                        new List<Hobby> { Hobby.Games, Hobby.Running, Hobby.Jewelry, Hobby.Drink, Hobby.Food, Hobby.Beauty, Hobby.Music },
                        new List<Hobby> { Hobby.Games, Hobby.Flowers, Hobby.Football, Hobby.Drink },
                        new List<Hobby> { Hobby.Animals, Hobby.Sex, Hobby.TV, Hobby.Books, Hobby.Guitar },
                        },
                        Сomplexity = 1
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 10,
                        Target = 9,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Singing, Hobby.Running, Hobby.Fishing },
                        new List<Hobby> { Hobby.Money, Hobby.Fishing, Hobby.Pictures, Hobby.Jewelry, Hobby.Animals, Hobby.Books, Hobby.Football },
                        new List<Hobby> { Hobby.Money, Hobby.Archery, Hobby.Animals, Hobby.Skate, Hobby.Cars, Hobby.Running },
                        new List<Hobby> { Hobby.Fishing, Hobby.Money, Hobby.Singing },
                        new List<Hobby> { Hobby.Football, Hobby.TV, Hobby.Drink, Hobby.Money },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Work, Hobby.Cars, Hobby.Music, Hobby.Flowers, Hobby.Fishing, Hobby.TV },
                        new List<Hobby> { Hobby.Animals, Hobby.Flowers, Hobby.Jewelry, Hobby.Archery, Hobby.Food, Hobby.Music, Hobby.Games, Hobby.Drink },
                        new List<Hobby> { Hobby.Flowers, Hobby.Drink, Hobby.Jewelry, Hobby.Games, Hobby.Beauty, Hobby.Pictures },
                        new List<Hobby> { Hobby.Money, Hobby.Running, Hobby.Sex, Hobby.Pictures, Hobby.Football, Hobby.Drink, Hobby.Jewelry, Hobby.Animals },
                        new List<Hobby> { Hobby.Running, Hobby.Flowers, Hobby.Fashion, Hobby.Food, Hobby.Photo },
                        },
                        Сomplexity = 2
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 10,
                        Target = 15,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Sex, Hobby.Animals, Hobby.Guitar, Hobby.Money, Hobby.Photo, Hobby.Football },
                        new List<Hobby> { Hobby.Games, Hobby.Running, Hobby.Books, Hobby.Work, Hobby.Fishing, Hobby.Drink, Hobby.Photo },
                        new List<Hobby> { Hobby.TV, Hobby.Books, Hobby.Archery, Hobby.Skate, Hobby.Drink, Hobby.Fishing, Hobby.Jewelry, Hobby.Sex },
                        new List<Hobby> { Hobby.Photo, Hobby.Flowers, Hobby.Animals, Hobby.Music, Hobby.Beauty, Hobby.Books, Hobby.Games, Hobby.Skate },
                        new List<Hobby> { Hobby.Flowers, Hobby.Football, Hobby.Skate, Hobby.Fashion, Hobby.Running, Hobby.Food, Hobby.Pictures, Hobby.Archery },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Photo, Hobby.Guitar, Hobby.Books, Hobby.Drink, Hobby.Pictures, Hobby.Music },
                        new List<Hobby> { Hobby.Work, Hobby.Football, Hobby.Sex, Hobby.Fishing, Hobby.Animals, Hobby.Flowers, Hobby.TV, Hobby.Money },
                        new List<Hobby> { Hobby.Pictures, Hobby.Work, Hobby.Running, Hobby.Fishing },
                        new List<Hobby> { Hobby.Food, Hobby.TV, Hobby.Drink, Hobby.Beauty, Hobby.Football, Hobby.Archery },
                        new List<Hobby> { Hobby.Running, Hobby.Fishing, Hobby.Jewelry, Hobby.Archery, Hobby.Music },
                        },
                        Сomplexity = 3
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 10,
                        Target = 11,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Fashion, Hobby.Books, Hobby.Food, Hobby.Cars, Hobby.Guitar, Hobby.Football, Hobby.Flowers, Hobby.Music },
                        new List<Hobby> { Hobby.Singing, Hobby.Running, Hobby.Animals, Hobby.Games },
                        new List<Hobby> { Hobby.Beauty, Hobby.Money, Hobby.Work, Hobby.Food, Hobby.Fishing, Hobby.Guitar },
                        new List<Hobby> { Hobby.Skate, Hobby.Games, Hobby.Archery, Hobby.Guitar, Hobby.Pictures, Hobby.Photo },
                        new List<Hobby> { Hobby.Books, Hobby.Animals, Hobby.Running, Hobby.TV, Hobby.Games, Hobby.Drink },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Money, Hobby.Drink, Hobby.Jewelry, Hobby.Music, Hobby.Skate, Hobby.Running, Hobby.Flowers, Hobby.Football },
                        new List<Hobby> { Hobby.Work, Hobby.Fashion, Hobby.Pictures, Hobby.Flowers, Hobby.Beauty, Hobby.Games, Hobby.Food, Hobby.Football },
                        new List<Hobby> { Hobby.Guitar, Hobby.Singing, Hobby.Music, Hobby.Food, Hobby.Pictures, Hobby.Jewelry, Hobby.Photo, Hobby.Beauty },
                        new List<Hobby> { Hobby.Archery, Hobby.Food, Hobby.Cars },
                        new List<Hobby> { Hobby.Animals, Hobby.Guitar, Hobby.Sex, Hobby.Money },
                        },
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 10,
                        Target = 15,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Singing, Hobby.Games, Hobby.Fishing, Hobby.Running, Hobby.Cars, Hobby.Fashion, Hobby.Football },
                        new List<Hobby> { Hobby.Food, Hobby.Drink, Hobby.Archery, Hobby.Games, Hobby.Cars, Hobby.Pictures, Hobby.Money },
                        new List<Hobby> { Hobby.Flowers, Hobby.Singing, Hobby.Music, Hobby.Animals, Hobby.Money, Hobby.Archery, Hobby.Pictures, Hobby.Beauty },
                        new List<Hobby> { Hobby.Beauty, Hobby.Guitar, Hobby.Fishing, Hobby.Running, Hobby.Food, Hobby.Football, Hobby.Flowers },
                        new List<Hobby> { Hobby.Guitar, Hobby.Games, Hobby.Skate, Hobby.Football, Hobby.TV, Hobby.Work, Hobby.Pictures, Hobby.Cars },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Skate, Hobby.Singing, Hobby.Photo, Hobby.Football, Hobby.Cars, Hobby.Beauty, Hobby.Running },
                        new List<Hobby> { Hobby.Fashion, Hobby.Archery, Hobby.Football, Hobby.Running, Hobby.Photo, Hobby.Books },
                        new List<Hobby> { Hobby.Archery, Hobby.Food, Hobby.Money, Hobby.Books },
                        new List<Hobby> { Hobby.Beauty, Hobby.TV, Hobby.Drink, Hobby.Fishing, Hobby.Guitar, Hobby.Singing, Hobby.Football, Hobby.Food },
                        new List<Hobby> { Hobby.Drink, Hobby.Pictures, Hobby.Archery, Hobby.Cars, Hobby.Work, Hobby.Singing, Hobby.Guitar },
                        },
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 10,
                        Target = 14,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Sex, Hobby.Drink, Hobby.Music, Hobby.Pictures, Hobby.Jewelry, Hobby.Money },
                        new List<Hobby> { Hobby.Guitar, Hobby.Music, Hobby.Flowers, Hobby.Games, Hobby.Beauty, Hobby.Pictures, Hobby.TV },
                        new List<Hobby> { Hobby.Games, Hobby.Music, Hobby.Sex, Hobby.Drink, Hobby.Cars },
                        new List<Hobby> { Hobby.Money, Hobby.Games, Hobby.Food, Hobby.Football, Hobby.Animals, Hobby.Running, Hobby.TV },
                        new List<Hobby> { Hobby.Archery, Hobby.Money, Hobby.Music, Hobby.Cars, Hobby.Work, Hobby.Sex, Hobby.Running, Hobby.Singing },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Jewelry, Hobby.Games, Hobby.Beauty, Hobby.Drink, Hobby.Music, Hobby.Fashion },
                        new List<Hobby> { Hobby.Cars, Hobby.Work, Hobby.Games, Hobby.Food, Hobby.Money, Hobby.TV, Hobby.Running },
                        new List<Hobby> { Hobby.Beauty, Hobby.Animals, Hobby.Football },
                        new List<Hobby> { Hobby.TV, Hobby.Beauty, Hobby.Singing, Hobby.Food, Hobby.Football, Hobby.Music },
                        new List<Hobby> { Hobby.Cars, Hobby.Music, Hobby.Jewelry, Hobby.Skate, Hobby.Pictures, Hobby.Flowers },
                        },
                        Сomplexity = 5
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 6,
                        Swaps = 10,
                        Target = 14,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Running, Hobby.Drink, Hobby.Food, Hobby.Money, Hobby.Animals, Hobby.Skate, Hobby.Pictures, Hobby.Guitar },
                        new List<Hobby> { Hobby.Animals, Hobby.Money, Hobby.Singing, Hobby.Books },
                        new List<Hobby> { Hobby.Football, Hobby.Animals, Hobby.Guitar, Hobby.Fashion },
                        new List<Hobby> { Hobby.Fashion, Hobby.TV, Hobby.Fishing, Hobby.Music },
                        new List<Hobby> { Hobby.Running, Hobby.Money, Hobby.Flowers, Hobby.Photo, Hobby.Fishing, Hobby.Skate, Hobby.TV, Hobby.Cars },
                        new List<Hobby> { Hobby.Drink, Hobby.TV, Hobby.Fashion, Hobby.Singing, Hobby.Books, Hobby.Fishing, Hobby.Archery },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Cars, Hobby.Books, Hobby.Guitar, Hobby.Flowers, Hobby.Photo, Hobby.Fishing, Hobby.Fashion },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Books, Hobby.Singing, Hobby.Photo, Hobby.Animals, Hobby.Football, Hobby.Food, Hobby.Archery },
                        new List<Hobby> { Hobby.Cars, Hobby.Money, Hobby.Guitar, Hobby.Jewelry, Hobby.TV, Hobby.Fishing, Hobby.Fashion },
                        new List<Hobby> { Hobby.Music, Hobby.Books, Hobby.Football, Hobby.Skate, Hobby.Beauty },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Running, Hobby.Work },
                        new List<Hobby> { Hobby.Drink, Hobby.Cars, Hobby.Food, Hobby.Animals, Hobby.Archery },
                        },
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 6,
                        Swaps = 10,
                        Target = 18,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Work, Hobby.Photo, Hobby.Football, Hobby.Skate },
                        new List<Hobby> { Hobby.Fashion, Hobby.Food, Hobby.Sex, Hobby.Fishing, Hobby.Cars },
                        new List<Hobby> { Hobby.Cars, Hobby.Fashion, Hobby.Flowers, Hobby.Archery, Hobby.Singing },
                        new List<Hobby> { Hobby.Cars, Hobby.Animals, Hobby.Photo, Hobby.Fashion, Hobby.Running, Hobby.Music },
                        new List<Hobby> { Hobby.Beauty, Hobby.Sex, Hobby.Cars, Hobby.Football, Hobby.Music, Hobby.Money, Hobby.Skate },
                        new List<Hobby> { Hobby.Money, Hobby.Work, Hobby.Pictures, Hobby.Animals, Hobby.Running, Hobby.Fishing },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Skate, Hobby.Jewelry, Hobby.Flowers, Hobby.Photo, Hobby.Animals, Hobby.Work, Hobby.Singing },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Skate, Hobby.Books, Hobby.Work, Hobby.Archery, Hobby.Money, Hobby.Beauty, Hobby.Flowers },
                        new List<Hobby> { Hobby.Pictures, Hobby.Sex, Hobby.Work, Hobby.Money, Hobby.Archery, Hobby.Food, Hobby.Guitar, Hobby.Cars },
                        new List<Hobby> { Hobby.Guitar, Hobby.Books, Hobby.Music, Hobby.Fashion, Hobby.Fishing, Hobby.Photo, Hobby.Work },
                        new List<Hobby> { Hobby.Archery, Hobby.Running, Hobby.Flowers, Hobby.Books, Hobby.Fashion },
                        new List<Hobby> { Hobby.Work, Hobby.Singing, Hobby.Photo, Hobby.Fishing, Hobby.Games, Hobby.Pictures, Hobby.Food, Hobby.Archery },
                        },
                        Сomplexity = 2
                    }
                };
            }
        }
    }
}