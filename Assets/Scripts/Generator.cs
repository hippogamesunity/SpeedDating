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
        private const int MaxCombinations = 518400;

        private static List<List<Person>> GenerateTables(int count, out int target, int fixedTarget, int complexity)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            Action stop = () =>
            {
                stopWatch.Stop();
                Debug.Log("GenerateTables: stopWatch.Elapsed=" + stopWatch.Elapsed.TotalSeconds);
            };

            target = 0;

            const int iterations = 1000;

            for (var i = 0; i <= iterations; i++)
            {
                var tables = CreateRandomTables(count);
                int max, fake;
                List<List<Person>> worst;
                List<List<Person>> best;

                Analize(tables, out worst, out best, out max, out fake);
                target = max;

                Debug.Log("max = " + max);

                if (fixedTarget != -1 && complexity != -1)
                {
                    if (max == fixedTarget && fake == complexity)
                    {
                        stop();
                        return worst;
                    }
                }
                else if (fixedTarget != -1 && max == fixedTarget)
                {
                    stop();
                    return worst;
                }
                else if (complexity != -1 && fake == complexity)
                {
                    stop();
                    return worst;
                }
                else if (i == iterations)
                {
                    stop();
                    return worst;
                }
            }

            throw new Exception();
        }

        private static List<List<Person>> CreateRandomTables(int count)
        {
            var tables = new List<List<Person>>();

            for (var j = 0; j < count; j++)
            {
                var boy = new Person
                {
                    Name = GameData.GetNextMaleName(false),
                    Image = GameData.GetNextMaleImage(),
                    Male = true,
                    Gay = false,
                    Hobbies = GenerateHobbies(CRandom.GetRandom(3, 9))
                };
                var girl = new Person
                {
                    Name = GameData.GetNextFemaleName(false),
                    Image = GameData.GeNextFemaleImage(),
                    Male = false,
                    Gay = false,
                    Hobbies = GenerateHobbies(CRandom.GetRandom(3, 9))
                };

                tables.Add(new List<Person> { boy, girl });
            }

            return tables;
        }

        private static void Analize(List<List<Person>> tables, out List<List<Person>> worst, out List<List<Person>> best, out int max, out int complexity)
        {
            var combinations = new List<List<List<Person>>>();
            var boys = tables.Select(p => p.Single(c => c.Male)).ToList();
            var girls = tables.Select(p => p.Single(c => !c.Male)).ToList();

            Dump(boys, girls);

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            GetCombinations(boys, girls, ref combinations, new List<List<Person>>());

            Debug.Log("combinations.Count = " + combinations.Count);

            var mins = new List<int>();
            var maxs = new List<int>();
            var min = 999;
            long sum = 0;

            max = complexity = 0;

            var sympathies = GetSympathies(boys, girls);

            for (var j = 0; j < combinations.Count; j++)
            {
                var s = 0;

                foreach (var table in combinations[j])
                {
                    var sympathy = sympathies[table[0]][table[1]];

                    s += sympathy;
                }

                if (s < min)
                {
                    min = s;
                    mins = new List<int> { j };
                }
                else if (s == min)
                {
                    mins.Add(j);
                }

                if (s > max)
                {
                    max = s;
                    maxs = new List<int> { j };
                }
                else if (s == max)
                {
                    maxs.Add(j);
                }

                sum += s;
            }

            var m = 0;

            foreach (var i in maxs)
            {
                foreach (var table in combinations[i])
                {
                    var sympathy = Table.GetSympathy(table[0], table[1]);

                    if (sympathy > m)
                    {
                        m = sympathy;
                    }
                }
            }

            foreach (var boy in boys)
            {
                foreach (var girl in girls)
                {
                    if (IsComplex(boy, girl, boys, girls, m, max, sympathies))
                    {
                        complexity++;
                    }
                }
            }

            worst = combinations[mins[CRandom.GetRandom(0, mins.Count)]];
            best = combinations[maxs[CRandom.GetRandom(0, maxs.Count)]];

            stopWatch.Stop();

            Debug.Log(string.Format("min={0}, max={1}, avg={2}, minRate={3}, maxRate={4}, m={5} complexity={6}", min, max, (float) sum / combinations.Count, mins.Count, maxs.Count, m, complexity));
            Debug.Log("Analize: stopWatch.Elapsed=" + stopWatch.Elapsed.TotalSeconds);
        }

        private static bool IsComplex(Person boy, Person girl, List<Person> boys, List<Person> girls, int m, int max, Dictionary<Person, Dictionary<Person, int>> sympathies)
        {
            if (Table.GetSympathy(boy, girl) < m) return false;

            var combinations = new List<List<List<Person>>>();

            GetCombinations(boys.Where(b => b != boy).ToList(), girls.Where(g => g != girl).ToList(), ref combinations, new List<List<Person>>());

            for (var j = 0; j < combinations.Count; j++)
            {
                var s = 0;

                foreach (var table in combinations[j])
                {
                    s += sympathies[table[0]][table[1]];
                }

                if (s + m >= max)
                {
                    return false;
                }
            }

            return true;
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
            var hobbies = GameData.Hobbies.Shuffle();

            return hobbies.Take(count).ToList();
        }

        private static void GetCombinations(IList<Person> boys, IList<Person> girls, ref List<List<List<Person>>> combinations, List<List<Person>> tables)
        {
            var boy = boys[0];

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
                else if (combinations.Count <= MaxCombinations)
                {
                    GetCombinations(boys.Where(i => i != pair[0]).ToList(), girls.Where(i => i != pair[1]).ToList(), ref combinations, t);
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