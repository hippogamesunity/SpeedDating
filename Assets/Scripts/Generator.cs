using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Assets.Scripts.Common;
using Debug = UnityEngine.Debug;

namespace Assets.Scripts
{
    public partial class Game
    {
        private static List<List<Person>> GenerateLevel(int count, out int target, int fixedTarget = 0)
        {
            target = 0;

            const int iterations = 10;

            for (var i = 0; i <= iterations; i++)
            {
                var tables = GenerateTables(count);

                List<List<Person>> worst;
                List<List<Person>> best;
                int max;

                Analize(tables, out worst, out best, out max);
                target = max;

                Debug.Log(max);

                if (max == fixedTarget || i == iterations)
                {
                    return best;
                }
            }

            throw new Exception();
        }

        private static List<List<Person>> GenerateTables(int count)
        {
            var tables = new List<List<Person>>();

            for (var j = 0; j < count; j++)
            {
                var boy = new Person
                {
                    Name = GameData.GetNextMaleName(),
                    Image = GameData.GetNextMaleImage(),
                    Male = true,
                    Gay = false,
                    Hobbies = GenerateHobbies(CRandom.GetRandom(3, 9))
                };
                var girl = new Person
                {
                    Name = GameData.GetNextFemaleName(),
                    Image = GameData.GeNextFemaleImage(),
                    Male = false,
                    Gay = false,
                    Hobbies = GenerateHobbies(CRandom.GetRandom(3, 9))
                };

                tables.Add(CRandom.Chance(0.5f) ? new List<Person> {boy, girl} : new List<Person> {girl, boy});
            }
            return tables;
        }

        private static void Analize(List<List<Person>> tables, out List<List<Person>> worst, out List<List<Person>> best, out int max)
        {
            var combinations = new List<List<List<Person>>>();
            var boys = tables.Select(p => p.Single(c => c.Male)).ToList();
            var girls = tables.Select(p => p.Single(c => !c.Male)).ToList();

            Dump(boys, girls);

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            GetCombinations(boys, girls, ref combinations, new List<List<Person>>());

            Debug.Log("combinations.Count = " + combinations.Count);

            var minIndex = 0;
            var maxIndex = 0;
            var min = 999;

            max = 0;

            var sympathies = GetSympathies(boys, girls);

            for (var j = 0; j < combinations.Count; j++)
            {
                var s = 0;

                foreach (var table in combinations[j])
                {
                    s += sympathies[table[0]][table[1]];
                }

                if (s < min)
                {
                    min = s;
                    minIndex = j;
                }

                if (s > max)
                {
                    max = s;
                    maxIndex = j;
                }
            }

            worst = combinations[minIndex];
            best = combinations[maxIndex];

            stopWatch.Stop();

            Debug.Log(stopWatch.Elapsed);
        }

        private static Dictionary<Person, Dictionary<Person, int>> GetSympathies(List<Person> boys, List<Person> girls)
        {
            var sympathies = new Dictionary<Person, Dictionary<Person, int>>();

            foreach (var boy in boys)
            {
                sympathies.Add(boy, new Dictionary<Person, int>());

                foreach (var girl in girls)
                {
                    sympathies[boy].Add(girl, Table.GetSympathy(boy, girl));
                }
            }

            foreach (var girl in girls)
            {
                sympathies.Add(girl, new Dictionary<Person, int>());

                foreach (var boy in boys)
                {
                    sympathies[girl].Add(boy, Table.GetSympathy(girl, boy));
                }
            }

            return sympathies;
        }

        private static List<Hobby> GenerateHobbies(int count)
        {
            var hobbies = Enum.GetValues(typeof(Hobby)).Cast<Hobby>().Shuffle();

            hobbies.Remove(Hobby.Gay);

            return hobbies.Take(count).ToList();
        }

        private static void GetCombinations(ICollection<Person> boys, ICollection<Person> girls, ref List<List<List<Person>>> combinations, List<List<Person>> tables)
        {
            foreach (var boy in boys)
            {
                foreach (var girl in girls)
                {
                    var pair = new List<Person> { boy, girl };
                    var t = new List<List<Person>> { pair };

                    foreach (var table in tables)
                    {
                        t.Add(new List<Person> { table[0], table[1] });
                    }

                    if (boys.Count == 1 || girls.Count == 1)
                    {
                        combinations.Add(t);
                    }
                    else
                    {
                        GetCombinations(boys.Where(i => i != pair[0]).ToList(), girls.Where(i => i != pair[1]).ToList(), ref combinations, t);
                    }
                }
            }
        }

        private static void Dump(IEnumerable<Person> boys, IEnumerable<Person> girls)
        {
            var rows = new List<string>();

            foreach (var boy in boys)
            {
                rows.Add("new List<Hobby> { " + string.Join(", ", boy.Hobbies.Select(h => string.Format("Hobby.{0}", h)).ToArray()) + " },");
            }

            foreach (var girl in girls)
            {
                rows.Add("new List<Hobby> { " + string.Join(", ", girl.Hobbies.Select(h => string.Format("Hobby.{0}", h)).ToArray()) + " },");
            }

            Debug.Log(string.Join(Environment.NewLine, rows.ToArray()));
        }
    }
}