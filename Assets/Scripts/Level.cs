﻿using System.Collections.Generic;

namespace Assets.Scripts
{
    public class Level
    {
        public int Progress;
        public int TableNumber;
        public LevelType Type = LevelType.Time;
        public int Time;
        public int Swaps;
        public string TableName = "RestaurantTable";
        public string Background = "Paris";
        public int Target;
        public bool Generator;
        public float TableScale = 0.75f;
        public List<List<Hobby>> MaleHobbies;
        public List<List<Hobby>> FemaleHobbies;
        public List<List<int>> Formation;
        public bool JapanNames;
        public int Сomplexity = 0;
    }
}