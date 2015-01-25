using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Table : Script
    {
        public UISprite[] Hearts;
        public UISprite Progress;

        private const float TweenTime = 0.4f;
        private readonly int[,] _sympathy =
        {
            {-1, 0, 0, 0, 0, 1, 1, 0, 0, 3},
            {0, -1, 0, 0, 0, 1, 0, 1, 0, 0},
            {0, 0, -1, 0, 0, 2, 2, 2, 1, 0},
            {0, 0, 0, -1, 0, 3, 3, 0, 2, 1},
            {0, 0, 0, 0, -1, 1, 3, 2, 0, 2},
            {1, 1, 2, 3, 1, -1, 0, 0, 2, 0},
            {1, 0, 2, 3, 3, 0, -1, 2, 1, 1},
            {0, 1, 2, 0, 2, 0, 2, -1, 0, 1},
            {0, 0, 1, 2, 0, 2, 1, 0, -1, 0},
            {3, 0, 0, 1, 2, 0, 1, 1, 0, -1}
        };

        public void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
            var characters = FindObjectsOfType<Character>().Where(i => i.Table == this).ToList();
            var sympathy = _sympathy[(int) characters[0].CharacterName, (int) characters[1].CharacterName];

            characters[0].Busy = characters[1].Busy = true;

            for (var i = 0; i < 3; i++)
            {
                TweenAlpha.Begin(Hearts[i].gameObject, TweenTime, 0);
            }

            TaskScheduler.CreateTask(() =>
            {
                const float delay = 2;

                Progress.transform.localScale = new Vector2(0, 1);
                TweenAlpha.Begin(Progress.gameObject, TweenTime, 1);
                TweenScale.Begin(Progress.gameObject, delay, Vector2.one);
                TaskScheduler.CreateTask(() => ShowSympathy(characters[0], characters[1], sympathy), delay);
            }, TweenTime);
        }

        private void ShowSympathy(Character character1, Character character2, int sympathy)
        {
            TweenAlpha.Begin(Progress.gameObject, TweenTime, 0);

            TaskScheduler.CreateTask(() =>
            {
                for (var i = 0; i < 3; i++)
                {
                    TweenAlpha.Begin(Hearts[i].gameObject, TweenTime, sympathy >= i + 1 ? 1 : 0);
                }
            }, TweenTime);

            character1.Busy = character2.Busy = false;
        }
    }
}