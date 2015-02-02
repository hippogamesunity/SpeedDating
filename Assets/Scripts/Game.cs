using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Game : Script
    {
        public Transform GameTransform;
        public UILabel Timer;
        public UITexture Background;
        public UILabel Score;
        public static Level Level;

        private DateTime _timeout;
        private int _shifts;

        public void Start()
        {
            GetComponent<Menu>().Open();
            //StartGame(GameData.Levels.Count - 1);
        }

        public void Update()
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                GoBack();
            }

            if (ViewBase.Current is Views.Game)
            {
                if (Level.Type == LevelType.Time)
                {
                    var timespan = _timeout - DateTime.Now;

                    if (timespan.TotalSeconds > 0)
                    {
                        Timer.SetText(Convert.ToString(Math.Round(timespan.TotalSeconds)));
                        //TimerProgress.fillAmount = (float) timespan.TotalSeconds / Level.Time;
                    }
                    else
                    {
                        CompleteGame();
                    }
                }
                else
                {
                    var shiftsLeft = Level.Shifts - _shifts;

                    if (shiftsLeft >= 0)
                    {
                        Timer.SetText(Convert.ToString(shiftsLeft));
                        //TimerProgress.fillAmount = (float) shiftsLeft / Level.Shifts;
                    }
                }
            }
        }

        public static int CalcScore(List<List<Person>> tables)
        {
            var score = 0;

            foreach (var table in tables)
            {
                score += Table.GetSympathy(table[0], table[1]);
            }

            return score;
        }

        public static int CalcScore()
        {
            var tables = FindObjectsOfType<Table>().Select(i => i.GetComponentsInChildren<Character>().Select(j => j.Person).ToList()).ToList();

            return CalcScore(tables);
        }

        public void RefreshScore()
        {
            var busy = FindObjectsOfType<Character>().Any(i => i.Busy);

            Score.SetText("{0}/{1}", busy ? "?" : Convert.ToString(CalcScore()), Level.Target);
        }

        public bool CanShift()
        {
            return Level.Type == LevelType.Shifts
                ? Level.Shifts - _shifts > 0
                : (_timeout - DateTime.Now).TotalSeconds > 0;
        }

        private void BeginGame()
        {
            GetComponent<Views.Game>().Open();

            foreach (var table in FindObjectsOfType<Table>())
            {
                Destroy(table.gameObject);
            }

            GameData.Shuffle();

            var target = 0;
            var tables = Level.Generator ? GenerateTables(Level.TableNumber, out target, Level.Target, Level.Сomplexity) : InitializeTables(Level);

            Score.SetText("{0}/{1}", 0, Level.Target);

            _timeout = DateTime.Now.AddSeconds(Level.Time);
            _shifts = 0;

            RemoveUnusedHobbies(tables);

            for (var i = 0; i < Level.TableNumber; i++)
            {
                var table = PrefabsHelper.Instantiate(Level.TableName, GameTransform);
                var characters = table.GetComponentsInChildren<Character>();

                Background.mainTexture = Resources.Load<Texture2D>("Images/Background/" + Level.Background);

                characters[0].Initialize(tables[i][0]);
                characters[1].Initialize(tables[i][1]);

                table.transform.localPosition = GameData.TablePositions[Level.TableNumber][i];
                table.transform.localScale = Level.TableScale * Vector3.one;
            }
        }

        private static void RemoveUnusedHobbies(List<List<Person>> tables)
        {
            var hobbies = new List<Hobby>();

            foreach (var table in tables)
            {
                hobbies.AddRange(table[0].Hobbies);
                hobbies.AddRange(table[1].Hobbies);
            }

            foreach (var table in tables)
            {
                table[0].Hobbies.RemoveAll(i => hobbies.Count(j => j == i) == 1);
                table[1].Hobbies.RemoveAll(i => hobbies.Count(j => j == i) == 1);
            }
        }

        private static List<List<Person>> InitializeTables(Level level)
        {
            GameData.Shuffle();

            var tables = new List<List<Person>>();
            var boys = new List<Person>();
            var girls = new List<Person>();
            var hobbyShift = CRandom.GetRandom(0, 10);

            for (var i = 0; i < level.TableNumber; i++)
            {
                for (var j = 0; j < level.MaleHobbies[i].Count; j++)
                {
                    level.MaleHobbies[i][j] = (Hobby) IncMod((int) level.MaleHobbies[i][j], hobbyShift, GameData.Hobbies.Count);
                }

                for (var j = 0; j < level.FemaleHobbies[i].Count; j++)
                {
                    level.FemaleHobbies[i][j] = (Hobby) IncMod((int) level.FemaleHobbies[i][j], hobbyShift, GameData.Hobbies.Count);
                }

                tables.Add(new List<Person>());
                boys.Add(new Person
                {
                    Name = GameData.GetNextMaleName(level.JapanNames),
                    Image = GameData.GetNextMaleImage(),
                    Male = true,
                    Hobbies = level.MaleHobbies[i]
                });
                girls.Add(new Person
                {
                    Name = GameData.GetNextFemaleName(level.JapanNames),
                    Image = GameData.GeNextFemaleImage(),
                    Male = false,
                    Hobbies = level.FemaleHobbies[i]
                });
            }

            for (var i = 0; i < level.TableNumber; i++)
            {
                tables[i] = new List<Person> { boys[i], girls[i] };
            }

            List<List<Person>> worst, best;
            int max, complexity;

            Analize(tables, out worst, out best, out max, out complexity);

            return Shuffle(worst);
        }

        private static List<List<Person>> Shuffle(List<List<Person>> tables)
        {
            foreach (var table in tables)
            {
                if (CRandom.Chance(0.5f))
                {
                    table.Reverse();
                }
            }

            return tables.Shuffle();
        }

        private static int IncMod(int source, int value, int mod)
        {
            if (source >= mod) throw new ArgumentException();

            var result = source + value;

            if (result >= mod)
            {
                result -= mod;
            }

            return result;
        }
    }
}