using System;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Engine
    {
        public static Level Level;
        public static GameState State;

        private static DateTime _timeout;
        private static TimeSpan _timeleft;
        private static int _shifts;

        public void StartGame(object level)
        {
            if (State != GameState.Ready) return;

            var progress = int.Parse(level.ToString());

            Level = GameData.Levels[progress];
            Level.Progress = progress;

            GetComponent<Play>().Open(BeginGame);

            State = GameState.Playing;
        }

        public void RestartGame()
        {
            if (State != GameState.Ready) return;

            GetComponent<Play>().Open(BeginGame);

            State = GameState.Playing;
        }

        public void PauseGame()
        {
            _timeleft = _timeout - DateTime.Now;
            Time.timeScale = 0;
            GetComponent<Play>().ShowPauseDialog();
            State = GameState.Paused;
        }

        public void ResumeGame()
        {
            _timeout = DateTime.Now.Add(_timeleft);
            Time.timeScale = 1;
            GetComponent<Play>().ClosePauseDialog();
            State = GameState.Playing;
        }

        public void CompleteGame()
        {
            if (State != GameState.Paused) return;

            State = GameState.Ready;

            var score = CalcScore();

            if (score >= Level.Target && Profile.Progress == Level.Progress)
            {
                Profile.Progress++;
            }

            Get<Play>().ShowScoreDialog(score >= Level.Target);
        }

        public void ExitGame()
        {
            Time.timeScale = 1;
            Get<SelectLevel>().Open();
            State = GameState.Ready;
        }
    }
}