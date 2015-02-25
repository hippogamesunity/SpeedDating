using System.Collections.Generic;

namespace Assets.Scripts
{
    public static partial class Levels
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
                        new List<Hobby> { Hobby.H1, Hobby.H18, Hobby.H20, Hobby.H15 },
                        new List<Hobby> { Hobby.H3, Hobby.H10, Hobby.H23, Hobby.H22, Hobby.H13, Hobby.H19, Hobby.H21 },
                        new List<Hobby> { Hobby.H7, Hobby.H11, Hobby.H8 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H10, Hobby.H23, Hobby.H13, Hobby.H4, Hobby.H3, Hobby.H24, Hobby.H6 },
                        new List<Hobby> { Hobby.H10, Hobby.H11, Hobby.H2 },
                        new List<Hobby> { Hobby.H17, Hobby.H12, Hobby.H22, Hobby.H19, Hobby.H1, Hobby.H16, Hobby.H15, Hobby.H21 },
                        },
                        Сomplexity = 0
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 3,
                        Swaps = 2,
                        Target = 8,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H13, Hobby.H17, Hobby.H16, Hobby.H24, Hobby.H10, Hobby.H9, Hobby.H6, Hobby.H19 },
                        new List<Hobby> { Hobby.H14, Hobby.H7, Hobby.H24 },
                        new List<Hobby> { Hobby.H15, Hobby.H7, Hobby.H19, Hobby.H16, Hobby.H11, Hobby.H1, Hobby.H24, Hobby.H8 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H23, Hobby.H16, Hobby.H5, Hobby.H19, Hobby.H9, Hobby.H3, Hobby.H11 },
                        new List<Hobby> { Hobby.H9, Hobby.H7, Hobby.H22, Hobby.H10, Hobby.H5, Hobby.H12, Hobby.H13, Hobby.H20 },
                        new List<Hobby> { Hobby.H15, Hobby.H17, Hobby.H12, Hobby.H14, Hobby.H24, Hobby.H2, Hobby.H4, Hobby.H13 },
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
                        new List<Hobby> { Hobby.H17, Hobby.H21, Hobby.H12, Hobby.H19, Hobby.H6, Hobby.H9, Hobby.H10, Hobby.H5 },
                        new List<Hobby> { Hobby.H23, Hobby.H21, Hobby.H9, Hobby.H7, Hobby.H14, Hobby.H1 },
                        new List<Hobby> { Hobby.H9, Hobby.H3, Hobby.H24, Hobby.H16, Hobby.H13 },
                        new List<Hobby> { Hobby.H14, Hobby.H9, Hobby.H4, Hobby.H3, Hobby.H12, Hobby.H16, Hobby.H7 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H16, Hobby.H17, Hobby.H14, Hobby.H21, Hobby.H19, Hobby.H20, Hobby.H5 },
                        new List<Hobby> { Hobby.H2, Hobby.H4, Hobby.H20, Hobby.H6, Hobby.H19, Hobby.H13, Hobby.H14 },
                        new List<Hobby> { Hobby.H16, Hobby.H24, Hobby.H17, Hobby.H13 },
                        new List<Hobby> { Hobby.H18, Hobby.H3, Hobby.H19, Hobby.H1, Hobby.H12, Hobby.H7 },
                        },
                        Сomplexity = 0
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 8,
                        Target = 12,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H13, Hobby.H10, Hobby.H22, Hobby.H4, Hobby.H24, Hobby.H8, Hobby.H15, Hobby.H11 },
                        new List<Hobby> { Hobby.H15, Hobby.H10, Hobby.H13, Hobby.H11, Hobby.H8, Hobby.H20 },
                        new List<Hobby> { Hobby.H11, Hobby.H12, Hobby.H3, Hobby.H14, Hobby.H21, Hobby.H7, Hobby.H24 },
                        new List<Hobby> { Hobby.H10, Hobby.H7, Hobby.H17, Hobby.H24, Hobby.H18, Hobby.H23, Hobby.H13, Hobby.H14 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H23, Hobby.H17, Hobby.H7, Hobby.H10, Hobby.H20, Hobby.H9, Hobby.H13 },
                        new List<Hobby> { Hobby.H18, Hobby.H8, Hobby.H6, Hobby.H20, Hobby.H14, Hobby.H17, Hobby.H16, Hobby.H7 },
                        new List<Hobby> { Hobby.H21, Hobby.H11, Hobby.H24 },
                        new List<Hobby> { Hobby.H24, Hobby.H2, Hobby.H4, Hobby.H14, Hobby.H1, Hobby.H15 },
                        },
                        Сomplexity = 1
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 7,
                        Target = 9,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H11, Hobby.H14, Hobby.H1, Hobby.H2, Hobby.H12, Hobby.H24, Hobby.H17 },
                        new List<Hobby> { Hobby.H9, Hobby.H7, Hobby.H16, Hobby.H11, Hobby.H20, Hobby.H5 },
                        new List<Hobby> { Hobby.H11, Hobby.H19, Hobby.H22, Hobby.H16, Hobby.H8 },
                        new List<Hobby> { Hobby.H21, Hobby.H22, Hobby.H23, Hobby.H7, Hobby.H6, Hobby.H12 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H22, Hobby.H21, Hobby.H12, Hobby.H13, Hobby.H1, Hobby.H2, Hobby.H3, Hobby.H11 },
                        new List<Hobby> { Hobby.H13, Hobby.H11, Hobby.H10, Hobby.H20 },
                        new List<Hobby> { Hobby.H12, Hobby.H17, Hobby.H23, Hobby.H5, Hobby.H6, Hobby.H18 },
                        new List<Hobby> { Hobby.H13, Hobby.H1, Hobby.H23, Hobby.H14, Hobby.H9 },
                        },
                        Сomplexity = 2
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 6,
                        Target = 11,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H2, Hobby.H17, Hobby.H11, Hobby.H21, Hobby.H14, Hobby.H5 },
                        new List<Hobby> { Hobby.H21, Hobby.H2, Hobby.H5, Hobby.H14, Hobby.H15, Hobby.H19, Hobby.H23, Hobby.H6 },
                        new List<Hobby> { Hobby.H6, Hobby.H15, Hobby.H20, Hobby.H2, Hobby.H19, Hobby.H16, Hobby.H12 },
                        new List<Hobby> { Hobby.H16, Hobby.H20, Hobby.H3, Hobby.H23, Hobby.H10, Hobby.H19 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H9, Hobby.H20, Hobby.H19, Hobby.H6, Hobby.H13 },
                        new List<Hobby> { Hobby.H9, Hobby.H23, Hobby.H4, Hobby.H5, Hobby.H22, Hobby.H3 },
                        new List<Hobby> { Hobby.H17, Hobby.H19, Hobby.H20, Hobby.H14, Hobby.H3, Hobby.H6, Hobby.H5, Hobby.H1 },
                        new List<Hobby> { Hobby.H3, Hobby.H4, Hobby.H10, Hobby.H15, Hobby.H22, Hobby.H23 },
                        },
                        Сomplexity = 3
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 4,
                        Swaps = 5,
                        Target = 10,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H4, Hobby.H18, Hobby.H17, Hobby.H10, Hobby.H6, Hobby.H5, Hobby.H12 },
                        new List<Hobby> { Hobby.H15, Hobby.H8, Hobby.H2, Hobby.H13 },
                        new List<Hobby> { Hobby.H7, Hobby.H22, Hobby.H8, Hobby.H4, Hobby.H16, Hobby.H13, Hobby.H12 },
                        new List<Hobby> { Hobby.H11, Hobby.H14, Hobby.H4, Hobby.H17, Hobby.H18, Hobby.H13, Hobby.H7 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H12, Hobby.H4, Hobby.H18, Hobby.H23, Hobby.H10, Hobby.H8, Hobby.H13, Hobby.H9 },
                        new List<Hobby> { Hobby.H1, Hobby.H12, Hobby.H4, Hobby.H5, Hobby.H2, Hobby.H10, Hobby.H7 },
                        new List<Hobby> { Hobby.H7, Hobby.H10, Hobby.H23, Hobby.H20, Hobby.H14, Hobby.H12, Hobby.H1 },
                        new List<Hobby> { Hobby.H23, Hobby.H20, Hobby.H1, Hobby.H5, Hobby.H15, Hobby.H18, Hobby.H6, Hobby.H4 },
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
                        new List<Hobby> { Hobby.H4, Hobby.H24, Hobby.H11, Hobby.H8, Hobby.H5, Hobby.H6, Hobby.H21, Hobby.H2 },
                        new List<Hobby> { Hobby.H23, Hobby.H7, Hobby.H3, Hobby.H14, Hobby.H17, Hobby.H9, Hobby.H12, Hobby.H11 },
                        new List<Hobby> { Hobby.H12, Hobby.H4, Hobby.H8, Hobby.H19, Hobby.H7, Hobby.H6 },
                        new List<Hobby> { Hobby.H5, Hobby.H21, Hobby.H9, Hobby.H3, Hobby.H19, Hobby.H7, Hobby.H1 },
                        new List<Hobby> { Hobby.H2, Hobby.H23, Hobby.H15, Hobby.H22, Hobby.H14, Hobby.H1 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H21, Hobby.H24, Hobby.H8, Hobby.H10, Hobby.H13, Hobby.H23 },
                        new List<Hobby> { Hobby.H17, Hobby.H23, Hobby.H9, Hobby.H2, Hobby.H22, Hobby.H10 },
                        new List<Hobby> { Hobby.H20, Hobby.H9, Hobby.H1, Hobby.H14, Hobby.H8, Hobby.H15, Hobby.H5, Hobby.H22 },
                        new List<Hobby> { Hobby.H16, Hobby.H8, Hobby.H2, Hobby.H12 },
                        new List<Hobby> { Hobby.H2, Hobby.H17, Hobby.H19, Hobby.H15, Hobby.H23, Hobby.H7, Hobby.H5, Hobby.H20 },
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
                        new List<Hobby> { Hobby.H20, Hobby.H4, Hobby.H23 },
                        new List<Hobby> { Hobby.H9, Hobby.H21, Hobby.H19, Hobby.H20, Hobby.H7, Hobby.H16, Hobby.H23, Hobby.H8 },
                        new List<Hobby> { Hobby.H1, Hobby.H14, Hobby.H12, Hobby.H20, Hobby.H19 },
                        new List<Hobby> { Hobby.H8, Hobby.H9, Hobby.H12, Hobby.H5, Hobby.H7, Hobby.H23, Hobby.H13, Hobby.H18 },
                        new List<Hobby> { Hobby.H14, Hobby.H16, Hobby.H11, Hobby.H12, Hobby.H24, Hobby.H6, Hobby.H5, Hobby.H3 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H15, Hobby.H3, Hobby.H2, Hobby.H18 },
                        new List<Hobby> { Hobby.H3, Hobby.H8, Hobby.H21, Hobby.H17, Hobby.H12 },
                        new List<Hobby> { Hobby.H12, Hobby.H19, Hobby.H14, Hobby.H6, Hobby.H10, Hobby.H3, Hobby.H16 },
                        new List<Hobby> { Hobby.H12, Hobby.H9, Hobby.H11, Hobby.H6 },
                        new List<Hobby> { Hobby.H1, Hobby.H20, Hobby.H23, Hobby.H4, Hobby.H13 },
                        },
                        Сomplexity = 1
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 12,
                        Target = 9,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H21, Hobby.H19, Hobby.H8 },
                        new List<Hobby> { Hobby.H15, Hobby.H8, Hobby.H18, Hobby.H14, Hobby.H1, Hobby.H4, Hobby.H11 },
                        new List<Hobby> { Hobby.H15, Hobby.H2, Hobby.H1, Hobby.H22, Hobby.H5, Hobby.H19 },
                        new List<Hobby> { Hobby.H8, Hobby.H15, Hobby.H21 },
                        new List<Hobby> { Hobby.H11, Hobby.H23, Hobby.H6, Hobby.H15 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H24, Hobby.H5, Hobby.H16, Hobby.H9, Hobby.H8, Hobby.H23 },
                        new List<Hobby> { Hobby.H1, Hobby.H9, Hobby.H14, Hobby.H2, Hobby.H10, Hobby.H16, Hobby.H12, Hobby.H6 },
                        new List<Hobby> { Hobby.H9, Hobby.H6, Hobby.H14, Hobby.H12, Hobby.H3, Hobby.H18 },
                        new List<Hobby> { Hobby.H15, Hobby.H19, Hobby.H20, Hobby.H18, Hobby.H11, Hobby.H6, Hobby.H14, Hobby.H1 },
                        new List<Hobby> { Hobby.H19, Hobby.H9, Hobby.H7, Hobby.H10, Hobby.H17 },
                        },
                        Сomplexity = 2
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 12,
                        Target = 15,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H20, Hobby.H1, Hobby.H13, Hobby.H15, Hobby.H17, Hobby.H11 },
                        new List<Hobby> { Hobby.H12, Hobby.H19, Hobby.H4, Hobby.H24, Hobby.H8, Hobby.H6, Hobby.H17 },
                        new List<Hobby> { Hobby.H23, Hobby.H4, Hobby.H2, Hobby.H22, Hobby.H6, Hobby.H8, Hobby.H14, Hobby.H20 },
                        new List<Hobby> { Hobby.H17, Hobby.H9, Hobby.H1, Hobby.H16, Hobby.H3, Hobby.H4, Hobby.H12, Hobby.H22 },
                        new List<Hobby> { Hobby.H9, Hobby.H11, Hobby.H22, Hobby.H7, Hobby.H19, Hobby.H10, Hobby.H18, Hobby.H2 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H17, Hobby.H13, Hobby.H4, Hobby.H6, Hobby.H18, Hobby.H16 },
                        new List<Hobby> { Hobby.H24, Hobby.H11, Hobby.H20, Hobby.H8, Hobby.H1, Hobby.H9, Hobby.H23, Hobby.H15 },
                        new List<Hobby> { Hobby.H18, Hobby.H24, Hobby.H19, Hobby.H8 },
                        new List<Hobby> { Hobby.H10, Hobby.H23, Hobby.H6, Hobby.H3, Hobby.H11, Hobby.H2 },
                        new List<Hobby> { Hobby.H19, Hobby.H8, Hobby.H14, Hobby.H2, Hobby.H16 },
                        },
                        Сomplexity = 3
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 12,
                        Target = 11,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H7, Hobby.H4, Hobby.H10, Hobby.H5, Hobby.H13, Hobby.H11, Hobby.H9, Hobby.H16 },
                        new List<Hobby> { Hobby.H21, Hobby.H19, Hobby.H1, Hobby.H12 },
                        new List<Hobby> { Hobby.H3, Hobby.H15, Hobby.H24, Hobby.H10, Hobby.H8, Hobby.H13 },
                        new List<Hobby> { Hobby.H22, Hobby.H12, Hobby.H2, Hobby.H13, Hobby.H18, Hobby.H17 },
                        new List<Hobby> { Hobby.H4, Hobby.H1, Hobby.H19, Hobby.H23, Hobby.H12, Hobby.H6 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H15, Hobby.H6, Hobby.H14, Hobby.H16, Hobby.H22, Hobby.H19, Hobby.H9, Hobby.H11 },
                        new List<Hobby> { Hobby.H24, Hobby.H7, Hobby.H18, Hobby.H9, Hobby.H3, Hobby.H12, Hobby.H10, Hobby.H11 },
                        new List<Hobby> { Hobby.H13, Hobby.H21, Hobby.H16, Hobby.H10, Hobby.H18, Hobby.H14, Hobby.H17, Hobby.H3 },
                        new List<Hobby> { Hobby.H2, Hobby.H10, Hobby.H5 },
                        new List<Hobby> { Hobby.H1, Hobby.H13, Hobby.H20, Hobby.H15 },
                        },
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 12,
                        Target = 15,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H21, Hobby.H12, Hobby.H8, Hobby.H19, Hobby.H5, Hobby.H7, Hobby.H11 },
                        new List<Hobby> { Hobby.H10, Hobby.H6, Hobby.H2, Hobby.H12, Hobby.H5, Hobby.H18, Hobby.H15 },
                        new List<Hobby> { Hobby.H9, Hobby.H21, Hobby.H16, Hobby.H1, Hobby.H15, Hobby.H2, Hobby.H18, Hobby.H3 },
                        new List<Hobby> { Hobby.H3, Hobby.H13, Hobby.H8, Hobby.H19, Hobby.H10, Hobby.H11, Hobby.H9 },
                        new List<Hobby> { Hobby.H13, Hobby.H12, Hobby.H22, Hobby.H11, Hobby.H23, Hobby.H24, Hobby.H18, Hobby.H5 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H22, Hobby.H21, Hobby.H17, Hobby.H11, Hobby.H5, Hobby.H3, Hobby.H19 },
                        new List<Hobby> { Hobby.H7, Hobby.H2, Hobby.H11, Hobby.H19, Hobby.H17, Hobby.H4 },
                        new List<Hobby> { Hobby.H2, Hobby.H10, Hobby.H15, Hobby.H4 },
                        new List<Hobby> { Hobby.H3, Hobby.H23, Hobby.H6, Hobby.H8, Hobby.H13, Hobby.H21, Hobby.H11, Hobby.H10 },
                        new List<Hobby> { Hobby.H6, Hobby.H18, Hobby.H2, Hobby.H5, Hobby.H24, Hobby.H21, Hobby.H13 },
                        },
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 5,
                        Swaps = 14,
                        Target = 14,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H20, Hobby.H6, Hobby.H16, Hobby.H18, Hobby.H14, Hobby.H15 },
                        new List<Hobby> { Hobby.H13, Hobby.H16, Hobby.H9, Hobby.H12, Hobby.H3, Hobby.H18, Hobby.H23 },
                        new List<Hobby> { Hobby.H12, Hobby.H16, Hobby.H20, Hobby.H6, Hobby.H5 },
                        new List<Hobby> { Hobby.H15, Hobby.H12, Hobby.H10, Hobby.H11, Hobby.H1, Hobby.H19, Hobby.H23 },
                        new List<Hobby> { Hobby.H2, Hobby.H15, Hobby.H16, Hobby.H5, Hobby.H24, Hobby.H20, Hobby.H19, Hobby.H21 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H14, Hobby.H12, Hobby.H3, Hobby.H6, Hobby.H16, Hobby.H7 },
                        new List<Hobby> { Hobby.H5, Hobby.H24, Hobby.H12, Hobby.H10, Hobby.H15, Hobby.H23, Hobby.H19 },
                        new List<Hobby> { Hobby.H3, Hobby.H1, Hobby.H11 },
                        new List<Hobby> { Hobby.H23, Hobby.H3, Hobby.H21, Hobby.H10, Hobby.H11, Hobby.H16 },
                        new List<Hobby> { Hobby.H5, Hobby.H16, Hobby.H14, Hobby.H22, Hobby.H18, Hobby.H9 },
                        },
                        Сomplexity = 5,
                        HideTarget = true,
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 6,
                        Swaps = 24,
                        Target = 14,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H19, Hobby.H6, Hobby.H10, Hobby.H15, Hobby.H1, Hobby.H22, Hobby.H18, Hobby.H13 },
                        new List<Hobby> { Hobby.H1, Hobby.H15, Hobby.H21, Hobby.H4 },
                        new List<Hobby> { Hobby.H11, Hobby.H1, Hobby.H13, Hobby.H7 },
                        new List<Hobby> { Hobby.H7, Hobby.H23, Hobby.H8, Hobby.H16 },
                        new List<Hobby> { Hobby.H19, Hobby.H15, Hobby.H9, Hobby.H17, Hobby.H8, Hobby.H22, Hobby.H23, Hobby.H5 },
                        new List<Hobby> { Hobby.H6, Hobby.H23, Hobby.H7, Hobby.H21, Hobby.H4, Hobby.H8, Hobby.H2 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H5, Hobby.H4, Hobby.H13, Hobby.H9, Hobby.H17, Hobby.H8, Hobby.H7 },
                        new List<Hobby> { Hobby.H14, Hobby.H4, Hobby.H21, Hobby.H17, Hobby.H1, Hobby.H11, Hobby.H10, Hobby.H2 },
                        new List<Hobby> { Hobby.H5, Hobby.H15, Hobby.H13, Hobby.H14, Hobby.H23, Hobby.H8, Hobby.H7 },
                        new List<Hobby> { Hobby.H16, Hobby.H4, Hobby.H11, Hobby.H22, Hobby.H3 },
                        new List<Hobby> { Hobby.H14, Hobby.H19, Hobby.H24 },
                        new List<Hobby> { Hobby.H6, Hobby.H5, Hobby.H10, Hobby.H1, Hobby.H2 },
                        },
                        Сomplexity = 4
                    },
                    new Level
                    {
                        Type = LevelType.Swap,
                        TableNumber = 6,
                        Swaps = 24,
                        Target = 18,
                        MaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H24, Hobby.H17, Hobby.H11, Hobby.H22 },
                        new List<Hobby> { Hobby.H7, Hobby.H10, Hobby.H20, Hobby.H8, Hobby.H5 },
                        new List<Hobby> { Hobby.H5, Hobby.H7, Hobby.H9, Hobby.H2, Hobby.H21 },
                        new List<Hobby> { Hobby.H5, Hobby.H1, Hobby.H17, Hobby.H7, Hobby.H19, Hobby.H16 },
                        new List<Hobby> { Hobby.H3, Hobby.H20, Hobby.H5, Hobby.H11, Hobby.H16, Hobby.H15, Hobby.H22 },
                        new List<Hobby> { Hobby.H15, Hobby.H24, Hobby.H18, Hobby.H1, Hobby.H19, Hobby.H8 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                        new List<Hobby> { Hobby.H22, Hobby.H14, Hobby.H9, Hobby.H17, Hobby.H1, Hobby.H24, Hobby.H21 },
                        new List<Hobby> { Hobby.H14, Hobby.H22, Hobby.H4, Hobby.H24, Hobby.H2, Hobby.H15, Hobby.H3, Hobby.H9 },
                        new List<Hobby> { Hobby.H18, Hobby.H20, Hobby.H24, Hobby.H15, Hobby.H2, Hobby.H10, Hobby.H13, Hobby.H5 },
                        new List<Hobby> { Hobby.H13, Hobby.H4, Hobby.H16, Hobby.H7, Hobby.H8, Hobby.H17, Hobby.H24 },
                        new List<Hobby> { Hobby.H2, Hobby.H19, Hobby.H9, Hobby.H4, Hobby.H7 },
                        new List<Hobby> { Hobby.H24, Hobby.H21, Hobby.H17, Hobby.H8, Hobby.H12, Hobby.H18, Hobby.H10, Hobby.H2 },
                        },
                        Сomplexity = 2,
                        HideTarget = true
                    }
                };
            }
        }
    }
}