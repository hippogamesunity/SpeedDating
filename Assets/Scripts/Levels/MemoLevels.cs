using System.Collections.Generic;

namespace Assets.Scripts
{
    public partial class Levels
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
                        MemoizeTime = 10,
                        TableNumber = 2,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.H1, Hobby.H18, Hobby.H11, Hobby.H5 },
                            new List<Hobby> { Hobby.H4, Hobby.H10, Hobby.H12, Hobby.H6 },
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.H1, Hobby.H18, Hobby.H11, Hobby.H4},
                            new List<Hobby> { Hobby.H4, Hobby.H10, Hobby.H12, Hobby.H18 },
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
                            new List<Hobby> { Hobby.H1, Hobby.H22, Hobby.H19, Hobby.H4 },
                            new List<Hobby> { Hobby.H16, Hobby.H17, Hobby.H2, Hobby.H6, Hobby.H1 },
                            new List<Hobby> { Hobby.H7, Hobby.H11, Hobby.H24, Hobby.H20, Hobby.H16 }
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.H10, Hobby.H5, Hobby.H4, Hobby.H16, Hobby.H2, Hobby.H22 },
                            new List<Hobby> { Hobby.H3, Hobby.H7, Hobby.H1, Hobby.H21, Hobby.H11, Hobby.H17 },
                            new List<Hobby> { Hobby.H6, Hobby.H22, Hobby.H14, Hobby.H3, Hobby.H21, Hobby.H17, Hobby.H8, Hobby.H23 }
                        }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 10,
                        MemoizeTime = 10,
                        TableNumber = 3,
                        MaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.H1, Hobby.H22, Hobby.H19, Hobby.H4 },
                            new List<Hobby> { Hobby.H16, Hobby.H17, Hobby.H2, Hobby.H6, Hobby.H1 },
                            new List<Hobby> { Hobby.H7, Hobby.H11, Hobby.H24, Hobby.H20, Hobby.H16 }
                        },
                        FemaleHobbies = new List<List<Hobby>>
                        {
                            new List<Hobby> { Hobby.H10, Hobby.H5, Hobby.H4, Hobby.H16, Hobby.H2, Hobby.H22 },
                            new List<Hobby> { Hobby.H3, Hobby.H7, Hobby.H1, Hobby.H21, Hobby.H11, Hobby.H17 },
                            new List<Hobby> { Hobby.H6, Hobby.H22, Hobby.H14, Hobby.H3, Hobby.H21, Hobby.H17, Hobby.H8, Hobby.H23 }
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
                        }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 15,
                        MemoizeTime = 10,
                        TableNumber = 5,
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
                        }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 15,
                        TableNumber = 6,
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
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 10,
                        TableNumber = 6,
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
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 20,
                        TableNumber = 7,
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
                        Formation = new List<List<int>> { new List<int> { 6, 1 }, new List<int> { 5, 2 }, new List<int> { 4, 0 }, new List<int> { 3, 3 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 20,
                        TableNumber = 7,
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
                        Formation = new List<List<int>> { new List<int> { 6, 1 }, new List<int> { 5, 2 }, new List<int> { 4, 0 }, new List<int> { 3, 3 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 15,
                        TableNumber = 7,
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
                        Formation = new List<List<int>> { new List<int> { 6, 1 }, new List<int> { 5, 2 }, new List<int> { 4, 0 }, new List<int> { 3, 3 }, new List<int> { 2, 4 }, new List<int> { 1, 6 }, new List<int> { 0, 5 } }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 25,
                        TableNumber = 8,
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
                        Formation = new List<List<int>> { new List<int> { 7, 3 }, new List<int> { 6, 7 }, new List<int> { 5, 4 }, new List<int> { 4, 0 }, new List<int> { 3, 2 }, new List<int> { 2, 5 }, new List<int> { 1, 1 }, new List<int> { 0, 6 } }
                    },
                    new Level
                    {
                        Type = LevelType.Memo,
                        Time = 20,
                        MemoizeTime = 20,
                        TableNumber = 8,
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
                        Formation = new List<List<int>> { new List<int> { 7, 3 }, new List<int> { 6, 7 }, new List<int> { 5, 4 }, new List<int> { 4, 0 }, new List<int> { 3, 2 }, new List<int> { 2, 5 }, new List<int> { 1, 1 }, new List<int> { 0, 6 } }
                    }
                };
            }
        }
    }
}