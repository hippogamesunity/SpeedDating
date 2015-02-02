using System;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Table : Script
    {
        public UIBasicSprite[] Hearts;
        public Progress Progress;
        private const float TweenTime = 0.4f;

        public void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
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
                const float delay = 0;

                Progress.Show(TweenTime);
                Progress.Animate(delay);
                TaskScheduler.CreateTask(() => ShowSympathy(characters[0], characters[1], sympathy), delay);
            }, TweenTime);
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
            }, TweenTime);

            character1.Busy = character2.Busy = false;
            Find<Game>().RefreshScore();

            if (Game.CalcScore() >= Game.Level.Target)
            {
                TaskScheduler.CreateTask(Find<AudioPlayer>().Success, 0.5f);
                TaskScheduler.CreateTask(Find<Game>().CompleteGame, 1f);
            }
            else if (sympathy >= 3)
            {
                TaskScheduler.CreateTask(Find<AudioPlayer>().Blink, 0.5f);
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