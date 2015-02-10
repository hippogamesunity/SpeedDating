using System;
using Assets.Scripts.Common;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public partial class Engine
    {
        public static Level Level;
        public static int TaskId = 999;
        public static DateTime Timeout;
        public static TimeSpan Timeleft;
        public static int Swaps;

        private static GameState _state;

        public static GameState State
        {
            get { return _state; }
            set
            {
                _state = value;
                
                Time.timeScale = value == GameState.Paused ? 0 : 1;
                
                if (Time.timeScale > 0)
                {
                    Find<AudioPlayer>().ScheduleFix();
                }
            }
        }

        public void StartGame()
        {
            TaskScheduler.Kill(TaskId++);

            State = GameState.Ready;

            var play = Get<Play>();

            play.Open(BeginGame);

            if (Level.Progress == 0)
            {
                TaskScheduler.CreateTask(() => PauseGame(play.HelpDialog), TaskId, 1);
            }
        }
        
        public void PauseGame(TweenPanel dialog)
        {
            Timeleft = Timeout - DateTime.Now;
            Get<Play>().ShowDialog(dialog);
            State = GameState.Paused;
        }

        public void ResumeGame()
        {
            Timeout = DateTime.Now.Add(Timeleft);
            GetComponent<Play>().CloseDialog();
            State = GameState.Playing;
        }

        public void CompleteGame()
        {
            State = GameState.Paused;

            var score = CalcScore();

            if (score >= Level.Target && Profile.Progress == Level.Progress)
            {
                Profile.Progress++;
            }

            var play = Get<Play>();

            play.SetScoreDialog(score >= Level.Target);
            play.ShowDialog(play.ScoreDialog);
        }

        public void ExitGame()
        {
            if (State != GameState.Paused) return;

            TaskScheduler.Kill(TaskId);

            if (Level.Type == LevelType.Time)
            {
                Get<Levels>().Open();
            }
            else
            {
                Get<SwapLevels>().Open();
            }

            State = GameState.Ready;
        }
    }
}