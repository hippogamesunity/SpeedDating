using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class Levels
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
                        new List<Hobby> { Hobby.H17, Hobby.H20, Hobby.H10, Hobby.H1, Hobby.H2, Hobby.H15, Hobby.H9, Hobby.H24 },
                        new List<Hobby> { Hobby.H17, Hobby.H11, Hobby.H2, Hobby.H12, Hobby.H6, Hobby.H15, Hobby.H24, Hobby.H23 },
                        new List<Hobby> { Hobby.H10, Hobby.H24, Hobby.H11 },
                        new List<Hobby> { Hobby.H8, Hobby.H19, Hobby.H5, Hobby.H6, Hobby.H12, Hobby.H21 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H10, Hobby.H8, Hobby.H5, Hobby.H12, Hobby.H4, Hobby.H24, Hobby.H22 },
                        new List<Hobby> { Hobby.H14, Hobby.H4, Hobby.H2, Hobby.H22, Hobby.H1, Hobby.H20, Hobby.H17, Hobby.H24 },
                        new List<Hobby> { Hobby.H17, Hobby.H18, Hobby.H3, Hobby.H24, Hobby.H1, Hobby.H20, Hobby.H5 },
                        new List<Hobby> { Hobby.H18, Hobby.H8, Hobby.H12, Hobby.H17 },
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
                        new List<Hobby> { Hobby.H7, Hobby.H24, Hobby.H8, Hobby.H17, Hobby.H21, Hobby.H1 },
                        new List<Hobby> { Hobby.H17, Hobby.H6, Hobby.H13, Hobby.H14 },
                        new List<Hobby> { Hobby.H24, Hobby.H14, Hobby.H11, Hobby.H5 },
                        new List<Hobby> { Hobby.H24, Hobby.H12, Hobby.H7, Hobby.H15, Hobby.H23, Hobby.H17, Hobby.H13 },
                        new List<Hobby> { Hobby.H18, Hobby.H22, Hobby.H10, Hobby.H5, Hobby.H2, Hobby.H9, Hobby.H19, Hobby.H20 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H24, Hobby.H5, Hobby.H13, Hobby.H7 },
                        new List<Hobby> { Hobby.H20, Hobby.H17, Hobby.H19, Hobby.H4, Hobby.H22 },
                        new List<Hobby> { Hobby.H13, Hobby.H7, Hobby.H20, Hobby.H16, Hobby.H17 },
                        new List<Hobby> { Hobby.H22, Hobby.H7, Hobby.H2, Hobby.H24, Hobby.H16, Hobby.H17, Hobby.H3 },
                        new List<Hobby> { Hobby.H6, Hobby.H3, Hobby.H2, Hobby.H12 },
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
                        new List<Hobby> { Hobby.H14, Hobby.H20, Hobby.H22 },
                        new List<Hobby> { Hobby.H13, Hobby.H2, Hobby.H3, Hobby.H4, Hobby.H12, Hobby.H23, Hobby.H21, Hobby.H15 },
                        new List<Hobby> { Hobby.H20, Hobby.H13, Hobby.H22 },
                        new List<Hobby> { Hobby.H5, Hobby.H3, Hobby.H7, Hobby.H8, Hobby.H21, Hobby.H24 },
                        new List<Hobby> { Hobby.H9, Hobby.H21, Hobby.H4, Hobby.H5, Hobby.H17, Hobby.H11 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H15, Hobby.H22, Hobby.H21, Hobby.H17, Hobby.H2, Hobby.H3, Hobby.H5 },
                        new List<Hobby> { Hobby.H16, Hobby.H22, Hobby.H23, Hobby.H12, Hobby.H24, Hobby.H6 },
                        new List<Hobby> { Hobby.H14, Hobby.H11, Hobby.H1, Hobby.H8, Hobby.H16, Hobby.H7, Hobby.H9, Hobby.H24 },
                        new List<Hobby> { Hobby.H12, Hobby.H18, Hobby.H21, Hobby.H5, Hobby.H6, Hobby.H24, Hobby.H19 },
                        new List<Hobby> { Hobby.H13, Hobby.H23, Hobby.H14, Hobby.H10, Hobby.H11, Hobby.H21 },
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
                        new List<Hobby> { Hobby.H15, Hobby.H17, Hobby.H21, Hobby.H23, Hobby.H13, Hobby.H16, Hobby.H9, Hobby.H10 },
                        new List<Hobby> { Hobby.H11, Hobby.H3, Hobby.H18, Hobby.H2, Hobby.H14, Hobby.H1, Hobby.H24 },
                        new List<Hobby> { Hobby.H3, Hobby.H18, Hobby.H17, Hobby.H21, Hobby.H4, Hobby.H9 },
                        new List<Hobby> { Hobby.H15, Hobby.H14, Hobby.H6, Hobby.H9, Hobby.H24 },
                        new List<Hobby> { Hobby.H11, Hobby.H8, Hobby.H19, Hobby.H2, Hobby.H17, Hobby.H7, Hobby.H6, Hobby.H15 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H1, Hobby.H3, Hobby.H5, Hobby.H15, Hobby.H18, Hobby.H19, Hobby.H23, Hobby.H7 },
                        new List<Hobby> { Hobby.H21, Hobby.H7, Hobby.H13, Hobby.H22, Hobby.H19, Hobby.H5 },
                        new List<Hobby> { Hobby.H1, Hobby.H15, Hobby.H24, Hobby.H3, Hobby.H4, Hobby.H6, Hobby.H10 },
                        new List<Hobby> { Hobby.H2, Hobby.H3, Hobby.H17, Hobby.H9, Hobby.H1, Hobby.H4, Hobby.H7, Hobby.H16 },
                        new List<Hobby> { Hobby.H3, Hobby.H6, Hobby.H20, Hobby.H22, Hobby.H19 },
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
                        new List<Hobby> { Hobby.H6, Hobby.H18, Hobby.H13, Hobby.H10, Hobby.H24, Hobby.H19 },
                        new List<Hobby> { Hobby.H19, Hobby.H11, Hobby.H15, Hobby.H17, Hobby.H12, Hobby.H2 },
                        new List<Hobby> { Hobby.H16, Hobby.H13, Hobby.H21, Hobby.H3, Hobby.H14, Hobby.H23, Hobby.H8 },
                        new List<Hobby> { Hobby.H1, Hobby.H5, Hobby.H18, Hobby.H6, Hobby.H22, Hobby.H16, Hobby.H11, Hobby.H14 },
                        new List<Hobby> { Hobby.H12, Hobby.H5, Hobby.H15, Hobby.H22, Hobby.H23, Hobby.H14 },
                        new List<Hobby> { Hobby.H8, Hobby.H14, Hobby.H23, Hobby.H13, Hobby.H21, Hobby.H1, Hobby.H12 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H1, Hobby.H20, Hobby.H7, Hobby.H16, Hobby.H4, Hobby.H13, Hobby.H14 },
                        new List<Hobby> { Hobby.H10, Hobby.H9, Hobby.H15 },
                        new List<Hobby> { Hobby.H17, Hobby.H3, Hobby.H1, Hobby.H16, Hobby.H19, Hobby.H12, Hobby.H4, Hobby.H9 },
                        new List<Hobby> { Hobby.H11, Hobby.H5, Hobby.H17, Hobby.H4, Hobby.H9 },
                        new List<Hobby> { Hobby.H23, Hobby.H24, Hobby.H11 },
                        new List<Hobby> { Hobby.H20, Hobby.H23, Hobby.H2, Hobby.H14, Hobby.H16 },
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
                        new List<Hobby> { Hobby.H15, Hobby.H12, Hobby.H24, Hobby.H4, Hobby.H14, Hobby.H6, Hobby.H21, Hobby.H13 },
                        new List<Hobby> { Hobby.H22, Hobby.H18, Hobby.H20, Hobby.H4, Hobby.H6, Hobby.H10, Hobby.H15 },
                        new List<Hobby> { Hobby.H22, Hobby.H6, Hobby.H23, Hobby.H17, Hobby.H18, Hobby.H5 },
                        new List<Hobby> { Hobby.H19, Hobby.H20, Hobby.H11, Hobby.H12, Hobby.H2, Hobby.H14, Hobby.H10, Hobby.H24 },
                        new List<Hobby> { Hobby.H11, Hobby.H17, Hobby.H13, Hobby.H16, Hobby.H21, Hobby.H14, Hobby.H7, Hobby.H20 },
                        new List<Hobby> { Hobby.H19, Hobby.H13, Hobby.H14, Hobby.H2 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H17, Hobby.H18, Hobby.H14, Hobby.H21, Hobby.H15, Hobby.H7, Hobby.H9, Hobby.H3 },
                        new List<Hobby> { Hobby.H1, Hobby.H8, Hobby.H10, Hobby.H13, Hobby.H23 },
                        new List<Hobby> { Hobby.H22, Hobby.H3, Hobby.H9, Hobby.H4, Hobby.H18 },
                        new List<Hobby> { Hobby.H21, Hobby.H15, Hobby.H3, Hobby.H1, Hobby.H4, Hobby.H16, Hobby.H19, Hobby.H20 },
                        new List<Hobby> { Hobby.H15, Hobby.H11, Hobby.H8, Hobby.H7, Hobby.H12, Hobby.H4, Hobby.H19 },
                        new List<Hobby> { Hobby.H11, Hobby.H5, Hobby.H20, Hobby.H7, Hobby.H4, Hobby.H16, Hobby.H9, Hobby.H1 },
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
                        new List<Hobby> { Hobby.H10, Hobby.H2, Hobby.H1, Hobby.H9, Hobby.H21 },
                        new List<Hobby> { Hobby.H16, Hobby.H22, Hobby.H3, Hobby.H17, Hobby.H5, Hobby.H20, Hobby.H2, Hobby.H12 },
                        new List<Hobby> { Hobby.H6, Hobby.H19, Hobby.H15, Hobby.H3 },
                        new List<Hobby> { Hobby.H1, Hobby.H20, Hobby.H15, Hobby.H10, Hobby.H7, Hobby.H16 },
                        new List<Hobby> { Hobby.H17, Hobby.H4, Hobby.H19, Hobby.H24, Hobby.H20, Hobby.H7, Hobby.H21, Hobby.H8 },
                        new List<Hobby> { Hobby.H22, Hobby.H6, Hobby.H21, Hobby.H11, Hobby.H8, Hobby.H18 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H9, Hobby.H10, Hobby.H22, Hobby.H2, Hobby.H20, Hobby.H19, Hobby.H12 },
                        new List<Hobby> { Hobby.H20, Hobby.H2, Hobby.H19, Hobby.H5, Hobby.H4, Hobby.H14, Hobby.H22 },
                        new List<Hobby> { Hobby.H6, Hobby.H17, Hobby.H1, Hobby.H21, Hobby.H7 },
                        new List<Hobby> { Hobby.H10, Hobby.H12, Hobby.H8, Hobby.H13, Hobby.H19, Hobby.H16 },
                        new List<Hobby> { Hobby.H9, Hobby.H17, Hobby.H24, Hobby.H5, Hobby.H14, Hobby.H19, Hobby.H8, Hobby.H15 },
                        new List<Hobby> { Hobby.H22, Hobby.H8, Hobby.H16, Hobby.H3, Hobby.H6 },
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
                        new List<Hobby> { Hobby.H11, Hobby.H8, Hobby.H24, Hobby.H21, Hobby.H13, Hobby.H2 },
                        new List<Hobby> { Hobby.H16, Hobby.H21, Hobby.H14, Hobby.H18, Hobby.H23, Hobby.H20, Hobby.H12, Hobby.H2 },
                        new List<Hobby> { Hobby.H9, Hobby.H6, Hobby.H24, Hobby.H5, Hobby.H22, Hobby.H2 },
                        new List<Hobby> { Hobby.H11, Hobby.H5, Hobby.H14, Hobby.H9, Hobby.H23, Hobby.H16, Hobby.H10 },
                        new List<Hobby> { Hobby.H10, Hobby.H21, Hobby.H19, Hobby.H24, Hobby.H3 },
                        new List<Hobby> { Hobby.H7, Hobby.H19, Hobby.H1, Hobby.H20, Hobby.H2, Hobby.H11 }
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H21, Hobby.H14, Hobby.H5, Hobby.H4, Hobby.H13, Hobby.H2, Hobby.H9 },
                        new List<Hobby> { Hobby.H20, Hobby.H17, Hobby.H13 },
                        new List<Hobby> { Hobby.H11, Hobby.H13, Hobby.H16, Hobby.H6, Hobby.H2 },
                        new List<Hobby> { Hobby.H2, Hobby.H14, Hobby.H21, Hobby.H23, Hobby.H11, Hobby.H12, Hobby.H16 },
                        new List<Hobby> { Hobby.H8, Hobby.H18, Hobby.H11 },
                        new List<Hobby> { Hobby.H17, Hobby.H9, Hobby.H18, Hobby.H21, Hobby.H12, Hobby.H6, Hobby.H20, Hobby.H7 }
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
                        new List<Hobby> { Hobby.H8, Hobby.H22, Hobby.H24, Hobby.H12, Hobby.H3, Hobby.H17, Hobby.H23, Hobby.H1 },
                        new List<Hobby> { Hobby.H5, Hobby.H16, Hobby.H10, Hobby.H19, Hobby.H11 },
                        new List<Hobby> { Hobby.H22, Hobby.H1, Hobby.H4, Hobby.H19, Hobby.H21 },
                        new List<Hobby> { Hobby.H23, Hobby.H10, Hobby.H18, Hobby.H6 },
                        new List<Hobby> { Hobby.H4, Hobby.H10, Hobby.H11, Hobby.H23, Hobby.H1, Hobby.H18 },
                        new List<Hobby> { Hobby.H15, Hobby.H9, Hobby.H22, Hobby.H8, Hobby.H12, Hobby.H4, Hobby.H10, Hobby.H20 },
                        new List<Hobby> { Hobby.H14, Hobby.H21, Hobby.H23, Hobby.H2, Hobby.H19 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H8, Hobby.H14, Hobby.H12, Hobby.H3, Hobby.H7, Hobby.H6, Hobby.H4, Hobby.H24 },
                        new List<Hobby> { Hobby.H2, Hobby.H23, Hobby.H14, Hobby.H19, Hobby.H17 },
                        new List<Hobby> { Hobby.H1, Hobby.H18, Hobby.H8 },
                        new List<Hobby> { Hobby.H9, Hobby.H16, Hobby.H11, Hobby.H5, Hobby.H21, Hobby.H24, Hobby.H12 },
                        new List<Hobby> { Hobby.H7, Hobby.H24, Hobby.H16, Hobby.H1, Hobby.H17, Hobby.H9, Hobby.H10 },
                        new List<Hobby> { Hobby.H18, Hobby.H16, Hobby.H1, Hobby.H7 },
                        new List<Hobby> { Hobby.H12, Hobby.H13, Hobby.H1 },
                        },
                        Сomplexity = 1,
                        Formation = new List<List<int>> { new List<int> { 6, 4 }, new List<int> { 5, 1 }, new List<int> { 4, 3 }, new List<int> { 3, 6 }, new List<int> { 2, 2 }, new List<int> { 1, 0 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 220,
                        Target = 19,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H4, Hobby.H6, Hobby.H3, Hobby.H2 },
                        new List<Hobby> { Hobby.H5, Hobby.H23, Hobby.H9, Hobby.H20, Hobby.H7, Hobby.H10, Hobby.H8 },
                        new List<Hobby> { Hobby.H5, Hobby.H2, Hobby.H18, Hobby.H14, Hobby.H22 },
                        new List<Hobby> { Hobby.H18, Hobby.H11, Hobby.H17, Hobby.H10, Hobby.H22, Hobby.H13, Hobby.H15, Hobby.H19 },
                        new List<Hobby> { Hobby.H15, Hobby.H2, Hobby.H16, Hobby.H8, Hobby.H21, Hobby.H11, Hobby.H22, Hobby.H9 },
                        new List<Hobby> { Hobby.H23, Hobby.H8, Hobby.H10, Hobby.H24, Hobby.H1, Hobby.H13, Hobby.H3, Hobby.H19 },
                        new List<Hobby> { Hobby.H20, Hobby.H19, Hobby.H13, Hobby.H2, Hobby.H16, Hobby.H10, Hobby.H18, Hobby.H21 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H13, Hobby.H18, Hobby.H21, Hobby.H20 },
                        new List<Hobby> { Hobby.H3, Hobby.H24, Hobby.H6, Hobby.H10, Hobby.H1, Hobby.H14 },
                        new List<Hobby> { Hobby.H18, Hobby.H5, Hobby.H10, Hobby.H20, Hobby.H11 },
                        new List<Hobby> { Hobby.H4, Hobby.H6, Hobby.H3, Hobby.H21 },
                        new List<Hobby> { Hobby.H21, Hobby.H1, Hobby.H14, Hobby.H24, Hobby.H7, Hobby.H3, Hobby.H10, Hobby.H4 },
                        new List<Hobby> { Hobby.H5, Hobby.H1, Hobby.H9, Hobby.H19, Hobby.H14, Hobby.H11, Hobby.H16 },
                        new List<Hobby> { Hobby.H15, Hobby.H11, Hobby.H18, Hobby.H24 },
                        },
                        Сomplexity = 2,
                        Formation = new List<List<int>> { new List<int> { 0, 0 }, new List<int> { 1, 6 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 1 }, new List<int> { 5, 2 }, new List<int> { 6, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 200,
                        Target = 17,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H4, Hobby.H24, Hobby.H15, Hobby.H6 },
                        new List<Hobby> { Hobby.H4, Hobby.H19, Hobby.H22, Hobby.H6, Hobby.H16, Hobby.H8, Hobby.H21, Hobby.H10 },
                        new List<Hobby> { Hobby.H13, Hobby.H8, Hobby.H6, Hobby.H22, Hobby.H14 },
                        new List<Hobby> { Hobby.H10, Hobby.H15, Hobby.H5, Hobby.H21, Hobby.H23, Hobby.H19, Hobby.H12, Hobby.H20 },
                        new List<Hobby> { Hobby.H22, Hobby.H6, Hobby.H24, Hobby.H10, Hobby.H5, Hobby.H11 },
                        new List<Hobby> { Hobby.H9, Hobby.H19, Hobby.H6, Hobby.H20, Hobby.H5, Hobby.H1 },
                        new List<Hobby> { Hobby.H1, Hobby.H5, Hobby.H13 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H11, Hobby.H5, Hobby.H9, Hobby.H24, Hobby.H14 },
                        new List<Hobby> { Hobby.H21, Hobby.H2, Hobby.H17, Hobby.H1, Hobby.H5 },
                        new List<Hobby> { Hobby.H18, Hobby.H10, Hobby.H4, Hobby.H3, Hobby.H11, Hobby.H22, Hobby.H2 },
                        new List<Hobby> { Hobby.H5, Hobby.H22, Hobby.H8, Hobby.H24, Hobby.H3, Hobby.H10, Hobby.H13 },
                        new List<Hobby> { Hobby.H21, Hobby.H5, Hobby.H4, Hobby.H2 },
                        new List<Hobby> { Hobby.H11, Hobby.H18, Hobby.H8, Hobby.H4 },
                        new List<Hobby> { Hobby.H5, Hobby.H13, Hobby.H22, Hobby.H9, Hobby.H7, Hobby.H15, Hobby.H11, Hobby.H20 },
                        },
                        Сomplexity = 5,
                        Formation = new List<List<int>> { new List<int> { 6, 1 }, new List<int> { 5, 2 }, new List<int> { 4, 0 }, new List<int> { 3, 3 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 180,
                        Target = 16,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H18, Hobby.H13, Hobby.H11, Hobby.H6, Hobby.H21, Hobby.H12, Hobby.H23 },
                        new List<Hobby> { Hobby.H15, Hobby.H23, Hobby.H5, Hobby.H11, Hobby.H6, Hobby.H9 },
                        new List<Hobby> { Hobby.H15, Hobby.H11, Hobby.H12, Hobby.H21, Hobby.H10, Hobby.H1 },
                        new List<Hobby> { Hobby.H23, Hobby.H12, Hobby.H15, Hobby.H10, Hobby.H19, Hobby.H4, Hobby.H3 },
                        new List<Hobby> { Hobby.H23, Hobby.H24, Hobby.H22, Hobby.H19, Hobby.H14, Hobby.H20, Hobby.H12 },
                        new List<Hobby> { Hobby.H21, Hobby.H6, Hobby.H20 },
                        new List<Hobby> { Hobby.H18, Hobby.H13, Hobby.H3, Hobby.H14, Hobby.H9, Hobby.H22 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H12, Hobby.H2, Hobby.H1 },
                        new List<Hobby> { Hobby.H16, Hobby.H9, Hobby.H7, Hobby.H22, Hobby.H21, Hobby.H5, Hobby.H3 },
                        new List<Hobby> { Hobby.H13, Hobby.H23, Hobby.H5, Hobby.H1, Hobby.H15, Hobby.H3, Hobby.H12 },
                        new List<Hobby> { Hobby.H18, Hobby.H23, Hobby.H13, Hobby.H12, Hobby.H15, Hobby.H14 },
                        new List<Hobby> { Hobby.H2, Hobby.H17, Hobby.H5 },
                        new List<Hobby> { Hobby.H14, Hobby.H11, Hobby.H16, Hobby.H22 },
                        new List<Hobby> { Hobby.H3, Hobby.H13, Hobby.H10, Hobby.H14, Hobby.H16, Hobby.H23 },
                        },
                        Сomplexity = 7,
                        Formation = new List<List<int>> { new List<int> { 6, 0 }, new List<int> { 5, 2 }, new List<int> { 4, 4 }, new List<int> { 3, 5 }, new List<int> { 2, 3 }, new List<int> { 1, 6 }, new List<int> { 0, 1 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 7,
                        Time = 160,
                        Target = 19,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H12, Hobby.H3, Hobby.H23, Hobby.H7 },
                        new List<Hobby> { Hobby.H3, Hobby.H14, Hobby.H10, Hobby.H21, Hobby.H12, Hobby.H1, Hobby.H16 },
                        new List<Hobby> { Hobby.H14, Hobby.H17, Hobby.H18, Hobby.H12, Hobby.H22 },
                        new List<Hobby> { Hobby.H2, Hobby.H21, Hobby.H20, Hobby.H1, Hobby.H13, Hobby.H7, Hobby.H15 },
                        new List<Hobby> { Hobby.H4, Hobby.H8, Hobby.H21, Hobby.H22, Hobby.H24 },
                        new List<Hobby> { Hobby.H21, Hobby.H18, Hobby.H9 },
                        new List<Hobby> { Hobby.H21, Hobby.H15, Hobby.H8, Hobby.H4, Hobby.H11, Hobby.H1, Hobby.H7, Hobby.H22 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H13, Hobby.H8, Hobby.H17, Hobby.H1, Hobby.H23, Hobby.H2 },
                        new List<Hobby> { Hobby.H15, Hobby.H4, Hobby.H19, Hobby.H7, Hobby.H21 },
                        new List<Hobby> { Hobby.H1, Hobby.H4, Hobby.H11, Hobby.H3, Hobby.H6, Hobby.H14, Hobby.H13, Hobby.H8 },
                        new List<Hobby> { Hobby.H2, Hobby.H3, Hobby.H12, Hobby.H18 },
                        new List<Hobby> { Hobby.H14, Hobby.H23, Hobby.H18, Hobby.H8, Hobby.H22, Hobby.H6, Hobby.H17, Hobby.H10 },
                        new List<Hobby> { Hobby.H4, Hobby.H12, Hobby.H17, Hobby.H3, Hobby.H21, Hobby.H6, Hobby.H22, Hobby.H8 },
                        new List<Hobby> { Hobby.H15, Hobby.H5, Hobby.H12, Hobby.H24, Hobby.H21, Hobby.H9, Hobby.H8, Hobby.H13 },
                        },
                        Сomplexity = 8,
                        Formation = new List<List<int>> { new List<int> { 6, 3 }, new List<int> { 5, 5 }, new List<int> { 4, 0 }, new List<int> { 3, 4 }, new List<int> { 2, 2 }, new List<int> { 1, 1 }, new List<int> { 0, 6 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 8,
                        Time = 300,
                        Target = 18,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H9, Hobby.H12, Hobby.H10, Hobby.H15, Hobby.H11, Hobby.H17, Hobby.H24 },
                        new List<Hobby> { Hobby.H9, Hobby.H13, Hobby.H15, Hobby.H12, Hobby.H5, Hobby.H1 },
                        new List<Hobby> { Hobby.H4, Hobby.H3, Hobby.H10, Hobby.H7, Hobby.H20, Hobby.H16 },
                        new List<Hobby> { Hobby.H7, Hobby.H23, Hobby.H15, Hobby.H1, Hobby.H9, Hobby.H4, Hobby.H12, Hobby.H18 },
                        new List<Hobby> { Hobby.H16, Hobby.H21, Hobby.H1 },
                        new List<Hobby> { Hobby.H4, Hobby.H19, Hobby.H17, Hobby.H7 },
                        new List<Hobby> { Hobby.H1, Hobby.H9, Hobby.H17, Hobby.H22, Hobby.H6 },
                        new List<Hobby> { Hobby.H7, Hobby.H20, Hobby.H8, Hobby.H6, Hobby.H5, Hobby.H17 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H19, Hobby.H6, Hobby.H13, Hobby.H10, Hobby.H2, Hobby.H7, Hobby.H23, Hobby.H24 },
                        new List<Hobby> { Hobby.H11, Hobby.H14, Hobby.H7, Hobby.H17, Hobby.H5, Hobby.H22, Hobby.H4 },
                        new List<Hobby> { Hobby.H13, Hobby.H6, Hobby.H14, Hobby.H16, Hobby.H24 },
                        new List<Hobby> { Hobby.H10, Hobby.H1, Hobby.H14, Hobby.H11, Hobby.H16 },
                        new List<Hobby> { Hobby.H3, Hobby.H21, Hobby.H13, Hobby.H12, Hobby.H9 },
                        new List<Hobby> { Hobby.H3, Hobby.H6, Hobby.H18, Hobby.H2, Hobby.H15 },
                        new List<Hobby> { Hobby.H19, Hobby.H5, Hobby.H17, Hobby.H16, Hobby.H7, Hobby.H20 },
                        new List<Hobby> { Hobby.H16, Hobby.H20, Hobby.H11 },
                        },
                        Сomplexity = 1,
                        Formation = new List<List<int>> { new List<int> { 7, 3 }, new List<int> { 6, 7 }, new List<int> { 5, 4 }, new List<int> { 4, 0 }, new List<int> { 3, 2 }, new List<int> { 2, 5 }, new List<int> { 1, 1 }, new List<int> { 0, 6 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 8,
                        Time = 240,
                        Target = 22,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H2, Hobby.H10, Hobby.H12, Hobby.H7, Hobby.H13, Hobby.H3, Hobby.H17, Hobby.H6 },
                        new List<Hobby> { Hobby.H23, Hobby.H16, Hobby.H21 },
                        new List<Hobby> { Hobby.H20, Hobby.H11, Hobby.H15, Hobby.H14, Hobby.H3, Hobby.H17, Hobby.H7 },
                        new List<Hobby> { Hobby.H15, Hobby.H13, Hobby.H8, Hobby.H21, Hobby.H9, Hobby.H3, Hobby.H10 },
                        new List<Hobby> { Hobby.H4, Hobby.H12, Hobby.H15, Hobby.H11, Hobby.H18, Hobby.H6, Hobby.H16 },
                        new List<Hobby> { Hobby.H2, Hobby.H10, Hobby.H18, Hobby.H19, Hobby.H17, Hobby.H15, Hobby.H12 },
                        new List<Hobby> { Hobby.H24, Hobby.H9, Hobby.H18, Hobby.H22, Hobby.H7, Hobby.H2 },
                        new List<Hobby> { Hobby.H11, Hobby.H14, Hobby.H10, Hobby.H16, Hobby.H17, Hobby.H9, Hobby.H1, Hobby.H12 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H17, Hobby.H2, Hobby.H12, Hobby.H23, Hobby.H11, Hobby.H15, Hobby.H20 },
                        new List<Hobby> { Hobby.H18, Hobby.H7, Hobby.H2, Hobby.H5, Hobby.H1, Hobby.H16 },
                        new List<Hobby> { Hobby.H7, Hobby.H8, Hobby.H17, Hobby.H20, Hobby.H13 },
                        new List<Hobby> { Hobby.H4, Hobby.H19, Hobby.H15, Hobby.H1, Hobby.H13 },
                        new List<Hobby> { Hobby.H11, Hobby.H9, Hobby.H12, Hobby.H19, Hobby.H13 },
                        new List<Hobby> { Hobby.H22, Hobby.H5, Hobby.H17, Hobby.H23, Hobby.H18, Hobby.H11, Hobby.H9, Hobby.H16 },
                        new List<Hobby> { Hobby.H17, Hobby.H12, Hobby.H10, Hobby.H7, Hobby.H3, Hobby.H8, Hobby.H20, Hobby.H19 },
                        new List<Hobby> { Hobby.H18, Hobby.H7, Hobby.H20, Hobby.H21, Hobby.H22, Hobby.H15, Hobby.H2 },
                        },
                        Сomplexity = 6,
                        Formation = new List<List<int>> { new List<int> { 7, 7 }, new List<int> { 6, 0 }, new List<int> { 5, 5 }, new List<int> { 4, 2 }, new List<int> { 3, 1 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 3 } }
                    },
                    new Level
                    {
                        Type = LevelType.Hard,
                        TableNumber = 8,
                        Time = 200,
                        Target = 22,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H14, Hobby.H8, Hobby.H18, Hobby.H21, Hobby.H20, Hobby.H4, Hobby.H5, Hobby.H19 },
                        new List<Hobby> { Hobby.H18, Hobby.H9, Hobby.H13, Hobby.H2, Hobby.H10, Hobby.H4 },
                        new List<Hobby> { Hobby.H4, Hobby.H9, Hobby.H5, Hobby.H15, Hobby.H6, Hobby.H18, Hobby.H14 },
                        new List<Hobby> { Hobby.H7, Hobby.H5, Hobby.H1, Hobby.H18 },
                        new List<Hobby> { Hobby.H7, Hobby.H14, Hobby.H8 },
                        new List<Hobby> { Hobby.H18, Hobby.H17, Hobby.H3, Hobby.H1, Hobby.H13, Hobby.H10, Hobby.H9, Hobby.H7 },
                        new List<Hobby> { Hobby.H17, Hobby.H15, Hobby.H3, Hobby.H9, Hobby.H22, Hobby.H4, Hobby.H1, Hobby.H18 },
                        new List<Hobby> { Hobby.H11, Hobby.H13, Hobby.H16, Hobby.H8, Hobby.H18, Hobby.H3, Hobby.H6 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H20, Hobby.H7, Hobby.H4, Hobby.H3, Hobby.H21, Hobby.H15, Hobby.H24 },
                        new List<Hobby> { Hobby.H22, Hobby.H1, Hobby.H21, Hobby.H18, Hobby.H2, Hobby.H7, Hobby.H10, Hobby.H8 },
                        new List<Hobby> { Hobby.H10, Hobby.H18, Hobby.H9, Hobby.H15, Hobby.H21, Hobby.H16, Hobby.H14 },
                        new List<Hobby> { Hobby.H7, Hobby.H10, Hobby.H2 },
                        new List<Hobby> { Hobby.H3, Hobby.H7, Hobby.H6, Hobby.H11, Hobby.H2, Hobby.H10, Hobby.H24 },
                        new List<Hobby> { Hobby.H12, Hobby.H14, Hobby.H6, Hobby.H3, Hobby.H4, Hobby.H21, Hobby.H23, Hobby.H1 },
                        new List<Hobby> { Hobby.H8, Hobby.H3, Hobby.H5, Hobby.H14, Hobby.H4 },
                        new List<Hobby> { Hobby.H5, Hobby.H19, Hobby.H2, Hobby.H14, Hobby.H18 },
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