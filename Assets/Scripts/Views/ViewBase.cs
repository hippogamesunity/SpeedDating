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
        private const float LoadingTime = 1f;

        public void Open(Action callback = null)
        {
            GetComponent<Loading>().Open(LoadingTime);
            TaskScheduler.CreateTask(() =>
            {
                GetComponent<Loading>().Close(LoadingTime);

                if (Current != null && !ReferenceEquals(Current, this))
                {
                    Current.Close();
                }

                Previous = Current;
                Current = this;
                enabled = true;
                Panel.SetActive(true);
                Initialize();

                if (callback != null)
                {
                    callback();
                }
            }, LoadingTime);
        }

        public void Close()
        {
            Cleanup();
            enabled = false;
            Panel.SetActive(false);
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
    }
}