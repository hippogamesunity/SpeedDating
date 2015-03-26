using System;
using Assets.Scripts.Common;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public partial class Engine
    {
        public void PlayEasyLevel(object level)
        {
            if (ViewBase.Current is EasyLevels)
            {
                PlayEasyLevel(Convert.ToInt32(level));
            }
        }

        public void PlayEasyLevel(int progress)
        {
            Level = GameData.EasyLevels[progress];
            Level.Progress = progress;

            StartGame();
        }

        public void PlayHardLevel(object level)
        {
            if (ViewBase.Current is HardLevels)
            {
                PlayHardLevel(Convert.ToInt32(level));
            }
        }

        public void PlayHardLevel(int progress)
        {
            Level = Levels.HardLevels[progress];
            Level.Progress = progress;

            StartGame();
        }

        public void PlaySwapLevel(object level)
        {
            if (ViewBase.Current is SwapLevels)
            {
                PlaySwapLevel(Convert.ToInt32(level));
            }
        }

        public void PlaySwapLevel(int progress)
        {
            Level = Levels.SwapLevels[progress];
            Level.Progress = progress;

            StartGame();
        }

        public void PlayMemoLevel(object level)
        {
            if (ViewBase.Current is MemoLevels)
            {
                PlayMemoLevel(Convert.ToInt32(level));
            }
        }

        public void PlayMemoLevel(int progress)
        {
            Level = Levels.MemoLevels[progress];
            Level.Progress = progress;
            Level.Memorize = true;

            StartGame();
        }

        public void Swapped()
        {
            Swaps++;

            if (Level.Type == LevelType.Memo)
            {
                var formation = GetFormation();

                Debug.Log(formation);

                if (formation == Level.FormationHash)
                {
                    TaskScheduler.CreateTask(Find<AudioPlayer>().PlaySuccess, TaskId, 0f);
                    TaskScheduler.CreateTask(Find<Engine>().CompleteGame, TaskId, 1f);
                }
            }
        }

        public void GoBack()
        {
            if (ViewBase.Current is Menu)
            {
                Application.Quit();
            }
            else if (ViewBase.Current is Mode)
            {
                GetComponent<Menu>().Open();
            }
            else if (ViewBase.Current is EasyLevels)
            {
                GetComponent<Mode>().Open();
            }
            else if (ViewBase.Current is Play)
            {
                var play = Get<Play>();

                if (State == GameState.Playing)
                {
                    PauseGame(play.PauseDialog);
                }
                else if (play.HelpDialog.Displayed || play.PauseDialog.Displayed)
                {
                    ResumeGame();
                }
                else if (play.ScoreDialog.Displayed)
                {
                    ExitGame();
                }
            }
            else if (ViewBase.Current is Team)
            {
                GetComponent<Mode>().Open();
            }
            else if (ViewBase.Current is Shop)
            {
                GetComponent<Menu>().Open();
            }
            else if (ViewBase.Current is Deluxe)
            {
                GetComponent<Menu>().Open();
            }
        }
    }
}