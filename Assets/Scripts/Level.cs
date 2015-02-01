using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Level
    {
        public int Progress;
        public int TableNumber;
        public LevelType Type = LevelType.Time;
        public int Time = 120;
        public int Shifts;
        public string TableName = "BurgerKingTable";
        public string Background = "BurgerKing";
        public int Target;
        public bool Generator;
        public float TableScale = 0.75f;
        public List<Vector2> TablePositions;
        public List<List<Hobby>> MaleHobbies;
        public List<List<Hobby>> FemaleHobbies;
        public List<List<int>> Formation;
        public bool JapanNames;
    }
}