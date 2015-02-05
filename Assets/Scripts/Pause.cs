using System;
using Assets.Scripts.Common;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Engine
    {
        private static TimeSpan _timeleft;

        public void PauseGame()
        {
            _timeleft = _timeout - DateTime.Now;
            Time.timeScale = 0;
            GetComponent<Play>().ShowDialog();
            State = GameState.Paused;
        }

        public void ResumeGame()
        {
            _timeout = DateTime.Now.Add(_timeleft);
            Time.timeScale = 1;
            GetComponent<Play>().CloseDialog();
            State = GameState.Playing;
        }

        public void AbortGame()
        {
            ResumeGame();
            TaskScheduler.CreateTask(CompleteGame, GetComponent<Play>().PauseDialog.DefaultTimeout);
        }
    }
}