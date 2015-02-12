using System;
using System.Linq;
using Assets.Scripts.Common;
using Assets.Scripts.Logic;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts
{
    public class Table : Script
    {
        public UIBasicSprite[] Hearts;
        public Progress Progress;
        public GameObject Hud;
        private const float TweenTime = 0.4f;

        public void Start()
        {
            Hud.SetActive(Engine.Level.Type != LevelType.Memo);
            Refresh();
        }

        public void Refresh()
        {
            if (Engine.Level.Type == LevelType.Memo) return;

            var characters = FindObjectsOfType<Character>().Where(i => i.Table == this).ToList();
            var sympathy = GetSympathy(characters[0].Person, characters[1].Person);

            characters[0].Busy = characters[1].Busy = true;
            characters[0].Sympathy = characters[1].Sympathy = 1;

            for (var i = 0; i < 3; i++)
            {
                TweenAlpha.Begin(Hearts[i].gameObject, TweenTime, 0);
            }

            TaskScheduler.CreateTask(() =>
            {
                const float delay = 2.8f;

                Progress.Show(TweenTime);
                Progress.Animate(delay);
                TaskScheduler.CreateTask(() => ShowSympathy(characters[0], characters[1], sympathy), Engine.TaskId, delay);
            }, Engine.TaskId, TweenTime);
        }

        private void ShowSympathy(Character character1, Character character2, int sympathy)
        {
            Progress.Hide(TweenTime);

            TaskScheduler.CreateTask(() =>
            {
                for (var i = 0; i < 3; i++)
                {
                    TweenAlpha.Begin(Hearts[i].gameObject, TweenTime, sympathy >= i + 1 ? 1 : 0);
                }

                character1.Sympathy = character2.Sympathy = sympathy;
            }, Engine.TaskId, TweenTime);

            character1.Busy = character2.Busy = false;
            
            Find<Play>().RefreshScore();

            if (FindObjectsOfType<Character>().Any(i => i.Busy))
            {
                return;
            }

            if (Engine.CalcScore() >= Engine.Level.Target && Engine.Level.Target != -1)
            {
                Engine.State = GameState.Ready;
                TaskScheduler.CreateTask(Find<AudioPlayer>().Success, Engine.TaskId, 0.5f);
                TaskScheduler.CreateTask(Find<Engine>().CompleteGame, Engine.TaskId, 2f);
            }
            else if (sympathy >= 3)
            {
                TaskScheduler.CreateTask(Find<AudioPlayer>().Blink, Engine.TaskId, 0.5f);
            }

            if (Engine.Level.Type == LevelType.Swap)
            {
                var swapsleft = Engine.Level.Swaps - Engine.Swaps;

                if (swapsleft <= 0)
                {
                    TaskScheduler.CreateTask(Find<Engine>().CompleteGame, Engine.TaskId, 1);
                }
            }
        }

        public static int GetSympathy(Person p1, Person p2)
        {
            var count = 0;

            if (p1.Male == p2.Male && (!p1.Gay || !p2.Gay))
            {
                return 0;
            }

            foreach (var hobby in GameData.Hobbies)
            {
                if (p1.Hobbies.Contains(hobby) && p2.Hobbies.Contains(hobby))
                {
                    count++;
                }
            }

            return Math.Min(count, 3);
        }
    }
}