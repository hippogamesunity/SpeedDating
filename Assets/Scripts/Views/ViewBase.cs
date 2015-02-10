using System;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public abstract class ViewBase : Script
    {
        public GameObject Panel;
        public static ViewBase Previous;
        public static ViewBase Current;
        private const float LoadingTime = 0.25f;

        public void Open(Action callback = null)
        {
            var prev = Current;

            Current = null;
            GetComponent<Loading>().Open(LoadingTime);
            TaskScheduler.CreateTask(() => DelayedOpen(callback), LoadingTime);

            if (prev != null && !ReferenceEquals(prev, this))
            {
                TaskScheduler.CreateTask(prev.Close, LoadingTime);
            }
        }

        public void Close()
        {
            Cleanup();
            enabled = false;
            Panel.SetActive(false);

            foreach (var tween in Panel.GetComponentsInChildren<TweenScale>(true))
            {
                tween.transform.localScale = Vector2.one;
                Destroy(tween);
            }
        }

        protected void Open<T>() where T : ViewBase
        {
            GetComponent<T>().Open();
        }

        protected void Close<T>() where T : ViewBase
        {
            GetComponent<T>().Close();
        }

        protected virtual void Initialize()
        {
        }

        protected virtual void Cleanup()
        {
        }

        private void DelayedOpen(Action callback)
        {
            GetComponent<Loading>().Close(LoadingTime);
            Previous = Current;
            Current = this;
            enabled = true;
            Panel.SetActive(true);
            Initialize();

            if (callback != null)
            {
                callback();
            }
        }
    }
}