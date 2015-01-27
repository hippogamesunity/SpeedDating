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
        public UISprite TimerProgress;
        public UITexture Background;
        public UILabel Current;
        public UILabel Target;
        public static int Level;
        private DateTime _timeout;

        public void Start()
        {
            GetComponent<Menu>().Open();
            //StartGame(3);
        }

        public void Update()
        {
            if (ViewBase.Current is Views.Game)
            {
                var timespan = _timeout - DateTime.Now;

                if (timespan.TotalSeconds > 0)
                {
                    Timer.SetText(Convert.ToString(Math.Round(timespan.TotalSeconds)));
                    TimerProgress.fillAmount = (float) timespan.TotalSeconds / GameData.Levels[Level].Time;

                    if (TimerProgress.fillAmount >= 0.5)
                    {
                        TimerProgress.color = Color.green;
                    }
                    else if (TimerProgress.fillAmount >= 0.25)
                    {
                        TimerProgress.color = Color.yellow;
                    }
                    else
                    {
                        TimerProgress.color = Color.red;
                    }
                }
                else
                {
                    CompleteGame();
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

            Current.SetText(busy ? "?" : Convert.ToString(CalcScore()));
        }

        private void BeginGame()
        {
            GetComponent<Views.Game>().Open();

            foreach (var table in FindObjectsOfType<Table>())
            {
                Destroy(table.gameObject);
            }

            GameData.Shuffle();

            var level = GameData.Levels[Level];
            var target = 0;
            var tables = level.Generator ? GenerateTables(level.TableNumber, out target, level.Target) : InitializeTables(level);

            Target.SetText(Convert.ToString(level.Generator ? target : level.Target));
            Current.SetText("?");

            _timeout = DateTime.Now.AddSeconds(level.Time);

            for (var i = 0; i < level.TableNumber; i++)
            {
                var table = PrefabsHelper.Instantiate(level.TableName, GameTransform);
                var characters = table.GetComponentsInChildren<Character>();

                Background.mainTexture = Resources.Load<Texture2D>("Images/Background/" + level.Background);

                characters[0].Initialize(tables[i][0]);
                characters[1].Initialize(tables[i][1]);

                table.transform.localPosition = level.TablePositions[i];
                table.transform.localScale = level.TableScale * Vector3.one;
            }
        }

        private static List<List<Person>> InitializeTables(Level level)
        {
            GameData.Shuffle();

            var tables = new List<List<Person>>();
            var boys = new List<Person>();
            var girls = new List<Person>();

            for (var i = 0; i < level.TableNumber; i++)
            {
                tables.Add(new List<Person>());
                boys.Add(new Person
                {
                    Name = GameData.GetNextMaleName(),
                    Image = GameData.GetNextMaleImage(),
                    Male = true,
                    Gay = level.MaleHobbies[i].Contains(Hobby.Gay),
                    Hobbies = level.MaleHobbies[i]
                });
                girls.Add(new Person
                {
                    Name = GameData.GetNextFemaleName(),
                    Image = GameData.GeNextFemaleImage(),
                    Male = false,
                    Gay = level.MaleHobbies[i].Contains(Hobby.Gay),
                    Hobbies = level.FemaleHobbies[i]
                });
            }

            if (level.Formation != null)
            {
                for (var i = 0; i < level.TableNumber; i++)
                {
                    tables[i] = new List<Person> { boys[level.Formation[i][0]], girls[level.Formation[i][1]] };
                }

                return Shuffle(tables);
            }

            for (var i = 0; i < level.TableNumber; i++)
            {
                tables[i] = new List<Person> { boys[i], girls[i] };
            }

            List<List<Person>> worst, best;
            int max;

            Analize(tables, out worst, out best, out max);

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
    }
}