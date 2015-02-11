using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static List<Level> HardLevels
        {
            get
            {
                return new List<Level>
                {
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 4,
                        Time = 120,
                        Target = 10,
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
                        },
                        Сomplexity = 2,
                        HideTarget = true
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 5,
                        Time = 120,
                        Target = 12,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Fashion, Hobby.Work, Hobby.Fishing, Hobby.Photo, Hobby.Singing, Hobby.Animals },
                        new List<Hobby> { Hobby.Photo, Hobby.Drink, Hobby.Guitar, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Work, Hobby.Jewelry, Hobby.Football, Hobby.Cars },
                        new List<Hobby> { Hobby.Work, Hobby.Games, Hobby.Fashion, Hobby.Money, Hobby.TV, Hobby.Photo, Hobby.Guitar },
                        new List<Hobby> { Hobby.Pictures, Hobby.Skate, Hobby.Food, Hobby.Cars, Hobby.Archery, Hobby.Flowers, Hobby.Running, Hobby.Sex },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Work, Hobby.Cars, Hobby.Guitar, Hobby.Fashion },
                        new List<Hobby> { Hobby.Sex, Hobby.Photo, Hobby.Running, Hobby.Books, Hobby.Skate },
                        new List<Hobby> { Hobby.Guitar, Hobby.Fashion, Hobby.Sex, Hobby.Music, Hobby.Photo },
                        new List<Hobby> { Hobby.Skate, Hobby.Fashion, Hobby.Archery, Hobby.Work, Hobby.Music, Hobby.Photo, Hobby.Beauty },
                        new List<Hobby> { Hobby.Drink, Hobby.Beauty, Hobby.Archery, Hobby.Games },
                        },
                        Сomplexity = 2,
                        HideTarget = true
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 5,
                        Time = 120,
                        Target = 11,
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
                        },
                        Сomplexity = 3,
                        HideTarget = true
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 5,
                        Time = 100,
                        Target = 13,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Money, Hobby.Photo, Hobby.Singing, Hobby.TV, Hobby.Guitar, Hobby.Music, Hobby.Flowers, Hobby.Food },
                        new List<Hobby> { Hobby.Football, Hobby.Beauty, Hobby.Pictures, Hobby.Archery, Hobby.Jewelry, Hobby.Animals, Hobby.Work },
                        new List<Hobby> { Hobby.Beauty, Hobby.Pictures, Hobby.Photo, Hobby.Singing, Hobby.Books, Hobby.Flowers },
                        new List<Hobby> { Hobby.Money, Hobby.Jewelry, Hobby.Drink, Hobby.Flowers, Hobby.Work },
                        new List<Hobby> { Hobby.Football, Hobby.Fishing, Hobby.Running, Hobby.Archery, Hobby.Photo, Hobby.Fashion, Hobby.Drink, Hobby.Money },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Animals, Hobby.Beauty, Hobby.Cars, Hobby.Money, Hobby.Pictures, Hobby.Running, Hobby.TV, Hobby.Fashion },
                        new List<Hobby> { Hobby.Singing, Hobby.Fashion, Hobby.Guitar, Hobby.Skate, Hobby.Running, Hobby.Cars },
                        new List<Hobby> { Hobby.Animals, Hobby.Money, Hobby.Work, Hobby.Beauty, Hobby.Books, Hobby.Drink, Hobby.Food },
                        new List<Hobby> { Hobby.Archery, Hobby.Beauty, Hobby.Photo, Hobby.Flowers, Hobby.Animals, Hobby.Books, Hobby.Fashion, Hobby.Music },
                        new List<Hobby> { Hobby.Beauty, Hobby.Drink, Hobby.Sex, Hobby.Skate, Hobby.Running },
                        },
                        Сomplexity = 5,
                        HideTarget = true
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 6,
                        Time = 180,
                        Target = 13,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Drink, Hobby.Pictures, Hobby.Guitar, Hobby.Food, Hobby.Work, Hobby.Running },
                        new List<Hobby> { Hobby.Running, Hobby.Football, Hobby.Money, Hobby.Photo, Hobby.Games, Hobby.Archery },
                        new List<Hobby> { Hobby.Music, Hobby.Guitar, Hobby.Singing, Hobby.Beauty, Hobby.Jewelry, Hobby.TV, Hobby.Fishing },
                        new List<Hobby> { Hobby.Animals, Hobby.Cars, Hobby.Pictures, Hobby.Drink, Hobby.Skate, Hobby.Music, Hobby.Football, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Games, Hobby.Cars, Hobby.Money, Hobby.Skate, Hobby.TV, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Fishing, Hobby.Jewelry, Hobby.TV, Hobby.Guitar, Hobby.Singing, Hobby.Animals, Hobby.Games },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Animals, Hobby.Sex, Hobby.Fashion, Hobby.Music, Hobby.Books, Hobby.Guitar, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Food, Hobby.Flowers, Hobby.Money },
                        new List<Hobby> { Hobby.Photo, Hobby.Beauty, Hobby.Animals, Hobby.Music, Hobby.Running, Hobby.Games, Hobby.Books, Hobby.Flowers },
                        new List<Hobby> { Hobby.Football, Hobby.Cars, Hobby.Photo, Hobby.Books, Hobby.Flowers },
                        new List<Hobby> { Hobby.TV, Hobby.Work, Hobby.Football },
                        new List<Hobby> { Hobby.Sex, Hobby.TV, Hobby.Archery, Hobby.Jewelry, Hobby.Music },
                        },
                        Сomplexity = 2
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 6,
                        Time = 180,
                        Target = 15,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Money, Hobby.Games, Hobby.Work, Hobby.Books, Hobby.Jewelry, Hobby.Drink, Hobby.Singing, Hobby.Guitar },
                        new List<Hobby> { Hobby.Skate, Hobby.Pictures, Hobby.Sex, Hobby.Books, Hobby.Drink, Hobby.Food, Hobby.Money },
                        new List<Hobby> { Hobby.Skate, Hobby.Drink, Hobby.TV, Hobby.Photo, Hobby.Pictures, Hobby.Cars },
                        new List<Hobby> { Hobby.Running, Hobby.Sex, Hobby.Football, Hobby.Games, Hobby.Archery, Hobby.Jewelry, Hobby.Food, Hobby.Work },
                        new List<Hobby> { Hobby.Football, Hobby.Photo, Hobby.Guitar, Hobby.Music, Hobby.Singing, Hobby.Jewelry, Hobby.Fashion, Hobby.Sex },
                        new List<Hobby> { Hobby.Running, Hobby.Guitar, Hobby.Jewelry, Hobby.Archery },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Photo, Hobby.Pictures, Hobby.Jewelry, Hobby.Singing, Hobby.Money, Hobby.Fashion, Hobby.Flowers, Hobby.Beauty },
                        new List<Hobby> { Hobby.Animals, Hobby.Fishing, Hobby.Food, Hobby.Guitar, Hobby.TV },
                        new List<Hobby> { Hobby.Skate, Hobby.Beauty, Hobby.Flowers, Hobby.Books, Hobby.Pictures },
                        new List<Hobby> { Hobby.Singing, Hobby.Money, Hobby.Beauty, Hobby.Animals, Hobby.Books, Hobby.Music, Hobby.Running, Hobby.Sex },
                        new List<Hobby> { Hobby.Money, Hobby.Football, Hobby.Fishing, Hobby.Fashion, Hobby.Games, Hobby.Books, Hobby.Running },
                        new List<Hobby> { Hobby.Football, Hobby.Cars, Hobby.Sex, Hobby.Fashion, Hobby.Books, Hobby.Music, Hobby.Flowers, Hobby.Animals },
                        },
                        Сomplexity = 3
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 6,
                        Time = 160,
                        Target = 16,
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
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
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
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 240,
                        Target = 16,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Fishing, Hobby.Skate, Hobby.Work, Hobby.Games, Hobby.Beauty, Hobby.Photo, Hobby.TV, Hobby.Animals },
                        new List<Hobby> { Hobby.Cars, Hobby.Music, Hobby.Food, Hobby.Running, Hobby.Football },
                        new List<Hobby> { Hobby.Skate, Hobby.Animals, Hobby.Books, Hobby.Running, Hobby.Singing },
                        new List<Hobby> { Hobby.TV, Hobby.Food, Hobby.Pictures, Hobby.Drink },
                        new List<Hobby> { Hobby.Books, Hobby.Food, Hobby.Football, Hobby.TV, Hobby.Animals, Hobby.Pictures },
                        new List<Hobby> { Hobby.Money, Hobby.Flowers, Hobby.Skate, Hobby.Fishing, Hobby.Games, Hobby.Books, Hobby.Food, Hobby.Sex },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Singing, Hobby.TV, Hobby.Archery, Hobby.Running },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Fishing, Hobby.Jewelry, Hobby.Games, Hobby.Beauty, Hobby.Fashion, Hobby.Drink, Hobby.Books, Hobby.Work },
                        new List<Hobby> { Hobby.Archery, Hobby.TV, Hobby.Jewelry, Hobby.Running, Hobby.Photo },
                        new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Fishing },
                        new List<Hobby> { Hobby.Flowers, Hobby.Music, Hobby.Football, Hobby.Cars, Hobby.Singing, Hobby.Work, Hobby.Games },
                        new List<Hobby> { Hobby.Fashion, Hobby.Work, Hobby.Music, Hobby.Animals, Hobby.Photo, Hobby.Flowers, Hobby.Food },
                        new List<Hobby> { Hobby.Pictures, Hobby.Music, Hobby.Animals, Hobby.Fashion },
                        new List<Hobby> { Hobby.Games, Hobby.Guitar, Hobby.Animals },
                        },
                        Сomplexity = 1,
                        Formation = new List<List<int>> {new List<int> { 6, 4 }, new List<int> { 5, 1 }, new List<int> { 4, 3 }, new List<int> { 3, 6 }, new List<int> { 2, 2 }, new List<int> { 1, 0 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 220,
                        Target = 19,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Books, Hobby.Drink, Hobby.Beauty, Hobby.Archery },
                        new List<Hobby> { Hobby.Cars, Hobby.TV, Hobby.Flowers, Hobby.Sex, Hobby.Fashion, Hobby.Food, Hobby.Fishing },
                        new List<Hobby> { Hobby.Cars, Hobby.Archery, Hobby.Pictures, Hobby.Jewelry, Hobby.Skate },
                        new List<Hobby> { Hobby.Pictures, Hobby.Football, Hobby.Photo, Hobby.Food, Hobby.Skate, Hobby.Guitar, Hobby.Money, Hobby.Running },
                        new List<Hobby> { Hobby.Money, Hobby.Archery, Hobby.Music, Hobby.Fishing, Hobby.Singing, Hobby.Football, Hobby.Skate, Hobby.Flowers },
                        new List<Hobby> { Hobby.TV, Hobby.Fishing, Hobby.Food, Hobby.Work, Hobby.Animals, Hobby.Guitar, Hobby.Beauty, Hobby.Running },
                        new List<Hobby> { Hobby.Sex, Hobby.Running, Hobby.Guitar, Hobby.Archery, Hobby.Music, Hobby.Food, Hobby.Pictures, Hobby.Singing },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Guitar, Hobby.Pictures, Hobby.Singing, Hobby.Sex },
                        new List<Hobby> { Hobby.Beauty, Hobby.Work, Hobby.Drink, Hobby.Food, Hobby.Animals, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Pictures, Hobby.Cars, Hobby.Food, Hobby.Sex, Hobby.Football },
                        new List<Hobby> { Hobby.Books, Hobby.Drink, Hobby.Beauty, Hobby.Singing },
                        new List<Hobby> { Hobby.Singing, Hobby.Animals, Hobby.Jewelry, Hobby.Work, Hobby.Fashion, Hobby.Beauty, Hobby.Food, Hobby.Books },
                        new List<Hobby> { Hobby.Cars, Hobby.Animals, Hobby.Flowers, Hobby.Running, Hobby.Jewelry, Hobby.Football, Hobby.Music },
                        new List<Hobby> { Hobby.Money, Hobby.Football, Hobby.Pictures, Hobby.Work },
                        },
                        Сomplexity = 2
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 200,
                        Target = 17,
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
                        Сomplexity = 5,
                        Formation = new List<List<int>> {new List<int> { 6, 1 }, new List<int> { 5, 2 }, new List<int> { 4, 0 }, new List<int> { 3, 3 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 180,
                        Target = 16,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Pictures, Hobby.Guitar, Hobby.Football, Hobby.Drink, Hobby.Singing, Hobby.Games, Hobby.TV },
                        new List<Hobby> { Hobby.Money, Hobby.TV, Hobby.Cars, Hobby.Football, Hobby.Drink, Hobby.Flowers },
                        new List<Hobby> { Hobby.Money, Hobby.Football, Hobby.Games, Hobby.Singing, Hobby.Food, Hobby.Animals },
                        new List<Hobby> { Hobby.TV, Hobby.Games, Hobby.Money, Hobby.Food, Hobby.Running, Hobby.Books, Hobby.Beauty },
                        new List<Hobby> { Hobby.TV, Hobby.Work, Hobby.Skate, Hobby.Running, Hobby.Jewelry, Hobby.Sex, Hobby.Games },
                        new List<Hobby> { Hobby.Singing, Hobby.Drink, Hobby.Sex },
                        new List<Hobby> { Hobby.Pictures, Hobby.Guitar, Hobby.Beauty, Hobby.Jewelry, Hobby.Flowers, Hobby.Skate },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Games, Hobby.Archery, Hobby.Animals },
                        new List<Hobby> { Hobby.Music, Hobby.Flowers, Hobby.Fashion, Hobby.Skate, Hobby.Singing, Hobby.Cars, Hobby.Beauty },
                        new List<Hobby> { Hobby.Guitar, Hobby.TV, Hobby.Cars, Hobby.Animals, Hobby.Money, Hobby.Beauty, Hobby.Games },
                        new List<Hobby> { Hobby.Pictures, Hobby.TV, Hobby.Guitar, Hobby.Games, Hobby.Money, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Archery, Hobby.Photo, Hobby.Cars },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Football, Hobby.Music, Hobby.Skate },
                        new List<Hobby> { Hobby.Beauty, Hobby.Guitar, Hobby.Food, Hobby.Jewelry, Hobby.Music, Hobby.TV },
                        },
                        Сomplexity = 7,
                        Formation = new List<List<int>> {new List<int> { 6, 0 }, new List<int> { 5, 2 }, new List<int> { 4, 4 }, new List<int> { 3, 5 }, new List<int> { 2, 3 }, new List<int> { 1, 6 }, new List<int> { 0, 1 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 160,
                        Target = 19,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Games, Hobby.Beauty, Hobby.TV, Hobby.Fashion },
                        new List<Hobby> { Hobby.Beauty, Hobby.Jewelry, Hobby.Food, Hobby.Singing, Hobby.Games, Hobby.Animals, Hobby.Music },
                        new List<Hobby> { Hobby.Jewelry, Hobby.Photo, Hobby.Pictures, Hobby.Games, Hobby.Skate },
                        new List<Hobby> { Hobby.Archery, Hobby.Singing, Hobby.Sex, Hobby.Animals, Hobby.Guitar, Hobby.Fashion, Hobby.Money },
                        new List<Hobby> { Hobby.Books, Hobby.Fishing, Hobby.Singing, Hobby.Skate, Hobby.Work },
                        new List<Hobby> { Hobby.Singing, Hobby.Pictures, Hobby.Flowers },
                        new List<Hobby> { Hobby.Singing, Hobby.Money, Hobby.Fishing, Hobby.Books, Hobby.Football, Hobby.Animals, Hobby.Fashion, Hobby.Skate },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Guitar, Hobby.Fishing, Hobby.Photo, Hobby.Animals, Hobby.TV, Hobby.Archery },
                        new List<Hobby> { Hobby.Money, Hobby.Books, Hobby.Running, Hobby.Fashion, Hobby.Singing },
                        new List<Hobby> { Hobby.Animals, Hobby.Books, Hobby.Football, Hobby.Beauty, Hobby.Drink, Hobby.Jewelry, Hobby.Guitar, Hobby.Fishing },
                        new List<Hobby> { Hobby.Archery, Hobby.Beauty, Hobby.Games, Hobby.Pictures },
                        new List<Hobby> { Hobby.Jewelry, Hobby.TV, Hobby.Pictures, Hobby.Fishing, Hobby.Skate, Hobby.Drink, Hobby.Photo, Hobby.Food },
                        new List<Hobby> { Hobby.Books, Hobby.Games, Hobby.Photo, Hobby.Beauty, Hobby.Singing, Hobby.Drink, Hobby.Skate, Hobby.Fishing },
                        new List<Hobby> { Hobby.Money, Hobby.Cars, Hobby.Games, Hobby.Work, Hobby.Singing, Hobby.Flowers, Hobby.Fishing, Hobby.Guitar },
                        },
                        Сomplexity = 8,
                        Formation = new List<List<int>> {new List<int> { 6, 3 }, new List<int> { 5, 5 }, new List<int> { 4, 0 }, new List<int> { 3, 4 }, new List<int> { 2, 2 }, new List<int> { 1, 1 }, new List<int> { 0, 6 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 8,
                        Time = 300,
                        Target = 18,
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
                        Сomplexity = 1,
                        Formation = new List<List<int>> {new List<int> { 7, 3 }, new List<int> { 6, 7 }, new List<int> { 5, 4 }, new List<int> { 4, 0 }, new List<int> { 3, 2 }, new List<int> { 2, 5 }, new List<int> { 1, 1 }, new List<int> { 0, 6 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 8,
                        Time = 240,
                        Target = 22,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Archery, Hobby.Food, Hobby.Games, Hobby.Fashion, Hobby.Guitar, Hobby.Beauty, Hobby.Photo, Hobby.Drink },
                        new List<Hobby> { Hobby.TV, Hobby.Music, Hobby.Singing },
                        new List<Hobby> { Hobby.Sex, Hobby.Football, Hobby.Money, Hobby.Jewelry, Hobby.Beauty, Hobby.Photo, Hobby.Fashion },
                        new List<Hobby> { Hobby.Money, Hobby.Guitar, Hobby.Fishing, Hobby.Singing, Hobby.Flowers, Hobby.Beauty, Hobby.Food },
                        new List<Hobby> { Hobby.Books, Hobby.Games, Hobby.Money, Hobby.Football, Hobby.Pictures, Hobby.Drink, Hobby.Music },
                        new List<Hobby> { Hobby.Archery, Hobby.Food, Hobby.Pictures, Hobby.Running, Hobby.Photo, Hobby.Money, Hobby.Games },
                        new List<Hobby> { Hobby.Work, Hobby.Flowers, Hobby.Pictures, Hobby.Skate, Hobby.Fashion, Hobby.Archery },
                        new List<Hobby> { Hobby.Football, Hobby.Jewelry, Hobby.Food, Hobby.Music, Hobby.Photo, Hobby.Flowers, Hobby.Animals, Hobby.Games },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Photo, Hobby.Archery, Hobby.Games, Hobby.TV, Hobby.Football, Hobby.Money, Hobby.Sex },
                        new List<Hobby> { Hobby.Pictures, Hobby.Fashion, Hobby.Archery, Hobby.Cars, Hobby.Animals, Hobby.Music },
                        new List<Hobby> { Hobby.Fashion, Hobby.Fishing, Hobby.Photo, Hobby.Sex, Hobby.Guitar },
                        new List<Hobby> { Hobby.Books, Hobby.Running, Hobby.Money, Hobby.Animals, Hobby.Guitar },
                        new List<Hobby> { Hobby.Football, Hobby.Flowers, Hobby.Games, Hobby.Running, Hobby.Guitar },
                        new List<Hobby> { Hobby.Skate, Hobby.Cars, Hobby.Photo, Hobby.TV, Hobby.Pictures, Hobby.Football, Hobby.Flowers, Hobby.Music },
                        new List<Hobby> { Hobby.Photo, Hobby.Games, Hobby.Food, Hobby.Fashion, Hobby.Beauty, Hobby.Fishing, Hobby.Sex, Hobby.Running },
                        new List<Hobby> { Hobby.Pictures, Hobby.Fashion, Hobby.Sex, Hobby.Singing, Hobby.Skate, Hobby.Money, Hobby.Archery },
                        },
                        Сomplexity = 6,
                        Formation = new List<List<int>> {new List<int> { 7, 7 }, new List<int> { 6, 0 }, new List<int> { 5, 5 }, new List<int> { 4, 2 }, new List<int> { 3, 1 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 3 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 8,
                        Time = 200,
                        Target = 22,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Jewelry, Hobby.Fishing, Hobby.Pictures, Hobby.Singing, Hobby.Sex, Hobby.Books, Hobby.Cars, Hobby.Running },
                        new List<Hobby> { Hobby.Pictures, Hobby.Flowers, Hobby.Guitar, Hobby.Archery, Hobby.Food, Hobby.Books },
                        new List<Hobby> { Hobby.Books, Hobby.Flowers, Hobby.Cars, Hobby.Money, Hobby.Drink, Hobby.Pictures, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Fashion, Hobby.Cars, Hobby.Animals, Hobby.Pictures },
                        new List<Hobby> { Hobby.Fashion, Hobby.Jewelry, Hobby.Fishing },
                        new List<Hobby> { Hobby.Pictures, Hobby.Photo, Hobby.Beauty, Hobby.Animals, Hobby.Guitar, Hobby.Food, Hobby.Flowers, Hobby.Fashion },
                        new List<Hobby> { Hobby.Photo, Hobby.Money, Hobby.Beauty, Hobby.Flowers, Hobby.Skate, Hobby.Books, Hobby.Animals, Hobby.Pictures },
                        new List<Hobby> { Hobby.Football, Hobby.Guitar, Hobby.Music, Hobby.Fishing, Hobby.Pictures, Hobby.Beauty, Hobby.Drink },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.Sex, Hobby.Fashion, Hobby.Books, Hobby.Beauty, Hobby.Singing, Hobby.Money, Hobby.Work },
                        new List<Hobby> { Hobby.Skate, Hobby.Animals, Hobby.Singing, Hobby.Pictures, Hobby.Archery, Hobby.Fashion, Hobby.Food, Hobby.Fishing },
                        new List<Hobby> { Hobby.Food, Hobby.Pictures, Hobby.Flowers, Hobby.Money, Hobby.Singing, Hobby.Music, Hobby.Jewelry },
                        new List<Hobby> { Hobby.Fashion, Hobby.Food, Hobby.Archery },
                        new List<Hobby> { Hobby.Beauty, Hobby.Fashion, Hobby.Drink, Hobby.Football, Hobby.Archery, Hobby.Food, Hobby.Work },
                        new List<Hobby> { Hobby.Games, Hobby.Jewelry, Hobby.Drink, Hobby.Beauty, Hobby.Books, Hobby.Singing, Hobby.TV, Hobby.Animals },
                        new List<Hobby> { Hobby.Fishing, Hobby.Beauty, Hobby.Cars, Hobby.Jewelry, Hobby.Books },
                        new List<Hobby> { Hobby.Cars, Hobby.Running, Hobby.Archery, Hobby.Jewelry, Hobby.Pictures },
                        },
                        Сomplexity = 10,
                        Formation = new List<List<int>> { new List<int> { 7, 0 }, new List<int> { 6, 3 }, new List<int> { 5, 7 }, new List<int> { 4, 2 }, new List<int> { 3, 5 }, new List<int> { 2, 1 }, new List<int> { 1, 6 }, new List<int> { 0, 4 } },
                        HideTarget = true
                    }
                };
            }
        }
    }
}