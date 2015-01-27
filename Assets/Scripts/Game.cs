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

        public void ShowLevels()
        {
            GetComponent<Levels>().Open();
        }

        public void StartGame(object level)
        {
            Level = int.Parse(level.ToString());
            GetComponent<Views.Game>().Open(BeginGame);
        }

        public void CompleteGame()
        {
            var level = GameData.Levels[Level];
            var scores = GetComponent<Score>();

            scores.Set(CalcScore(), level.Target, level.Time, (int) (_timeout - DateTime.Now).TotalSeconds);
            scores.Open();
        }

        public void BeginGame()
        {
            GetComponent<Views.Game>().Open();

            foreach (var table in FindObjectsOfType<Table>())
            {
                Destroy(table.gameObject);
            }
            
            GameData.Shuffle();

            var level = GameData.Levels[Level];
            var target = 0;
            var tables = level.Generator ? GenerateLevel(level.TableNumber, out target, level.Target) : InitializeLevel(level);

            Target.SetText(Convert.ToString(level.Generator ? target : level.Target));

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
                    GetComponent<Score>().Open();
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

        private static List<List<Person>> InitializeLevel(Level level)
        {
            GameData.Shuffle();

            var tables = new List<List<Person>>();

            for (var i = 0; i < level.TableNumber; i++)
            {
                var boy = new Person
                {
                    Name = GameData.GetNextMaleName(),
                    Image = GameData.GetNextMaleImage(),
                    Male = true,
                    Gay = level.MaleHobbies[i].Contains(Hobby.Gay),
                    Hobbies = level.MaleHobbies[i]
                };
                var girl = new Person
                {
                    Name = GameData.GetNextFemaleName(),
                    Image = GameData.GeNextFemaleImage(),
                    Male = false,
                    Gay = level.MaleHobbies[i].Contains(Hobby.Gay),
                    Hobbies = level.FemaleHobbies[i]
                };

                tables.Add(CRandom.Chance(0.5f) ? new List<Person> { boy, girl } : new List<Person> { girl, boy });
            }

            List<List<Person>> worst;
            List<List<Person>> best;
            int max;

            Analize(tables, out worst, out best, out max);

            return worst;
        }
    }
}