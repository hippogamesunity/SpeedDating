using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class TaskScheduler : Script
    {
        public static event Action<int> TaskCompleted = id => { };
        private static readonly List<int> Tasks = new List<int>();
        private static readonly Dictionary<int, Action> Callbacks = new Dictionary<int, Action>();

        private static TaskScheduler _instance;

        private static TaskScheduler Instance
        {
            get { return _instance ?? (_instance = new GameObject("TaskScheduler").AddComponent<TaskScheduler>()); }
        }

        public static void CreateTask(Action task, int id, float delay)
        {
            Tasks.Add(id);
            Instance.StartCoroutine(Coroutine(task, id, delay));
        }

        public static int CreateTask(Action task, float delay)
        {
            var id = CRandom.GetRandom(999999);

            Tasks.Add(id);
            Instance.StartCoroutine(Coroutine(task, id, delay));

            return id;
        }

        public static void CreateTask(Action task, float delay, Action callback)
        {
            Callbacks.Add(CreateTask(task, delay), callback);
        }

        public static void Kill(params int[] tasks)
        {
            //Debug.Log("Killing task " + string.Join(", ", tasks.Select(i => Convert.ToString(i)).ToArray()));

            if (tasks == null)
            {
                Tasks.Clear();
            }
            else
            {
                foreach (var task in tasks)
                {
                    if (Tasks.Contains(task))
                    {
                        Tasks.RemoveAll(i => i == task);
                    }
                }
            }
        }

        private static IEnumerator Coroutine(Action task, int id, float delay)
        {
            yield return new WaitForSeconds(delay);

            if (!Tasks.Contains(id)) yield break;

            //Debug.Log("Running task " + id);

            task();

            if (Callbacks.ContainsKey(id))
            {
                Callbacks[id]();
            }

            Tasks.Remove(id);
            Callbacks.Remove(id);
            TaskCompleted(id);
        }
    }
}