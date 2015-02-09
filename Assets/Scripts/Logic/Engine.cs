using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public partial class Engine : Script
    {
        public void Start()
        {
            DetectLanguage();
            GetComponent<Menu>().Open();
            //StartGame(GameData.Levels.Count - 1);
        }

        public void Update()
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                GoBack();
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

        public static bool CanShift
        {
            get
            {
                return Level.Type == LevelType.Swap ? Level.Swaps - Swaps > 0 : (Timeout - DateTime.Now).TotalSeconds > 0;
            }
        }

        private void BeginGame()
        {
            foreach (var table in FindObjectsOfType<Table>())
            {
                Destroy(table.gameObject);
            }

            GameData.Levels.Shuffle();

            var tables = Level.Generator ? GenerateTables(Level.TableNumber, Level.Target, Level.Сomplexity) : InitializeTables(Level);

            Timeout = DateTime.Now.AddSeconds(Level.Time);
            Swaps = 0;

            RemoveUnusedHobbies(tables);

            for (var i = 0; i < Level.TableNumber; i++)
            {
                var table = PrefabsHelper.Instantiate(Level.TableName, Get<Play>().GameTransform);
                var characters = table.GetComponentsInChildren<Character>();

                Get<Play>().Background.mainTexture = Resources.Load<Texture2D>("Images/Background/" + Level.Background);

                characters[0].Initialize(tables[i][0]);
                characters[1].Initialize(tables[i][1]);

                table.transform.localPosition = GameData.TablePositions[Level.TableNumber][i];
                table.transform.localScale = Level.TableScale * Vector3.one;
            }

            State = GameState.Playing;
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

        private static void DetectLanguage()
        {
            var languages = (TextAsset) Resources.Load("Localization", typeof(TextAsset));

            Localization.LoadCSV(languages);

            switch (Application.systemLanguage)
            {
                case SystemLanguage.Russian:
                case SystemLanguage.Ukrainian:
                case SystemLanguage.Belarusian:
                    Localization.language = "English";
                    break;
                default:
                    Localization.language = "English";
                    break;
            }
        }
    }
}