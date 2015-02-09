using System;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public partial class Engine
    {
        public void ShowLevels()
        {
            if (ViewBase.Current is Menu)
            {
                GetComponent<Levels>().Open();
            }
        }

        public void ShowSwapLevels()
        {
            if (ViewBase.Current is Levels)
            {
                GetComponent<SwapLevels>().Open();
            }
        }

        public void StartGameByLevel(object level)
        {
            if (ViewBase.Current is Levels)
            {
                var progress = Convert.ToInt32(level);

                Level = GameData.Levels[progress - 1];
                Level.Progress = progress;

                StartGame();
            }
        }

        public void StartSwapGameByLevel(object level)
        {
            if (ViewBase.Current is SwapLevels)
            {
                var progress = Convert.ToInt32(level);

                Level = GameData.SwapLevels[progress - 1];
                Level.Progress = progress;
                
                StartGame();
            }
        }

        public void Swapped()
        {
            Swaps++;
        }

        public void GoBack()
        {
            if (ViewBase.Current is Menu)
            {
                Application.Quit();
            }
            else if (ViewBase.Current is Levels)
            {
                GetComponent<Menu>().Open();
            }
            else if (ViewBase.Current is SwapLevels)
            {
                GetComponent<Menu>().Open();
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
                GetComponent<Menu>().Open();
            }
        }

        public void Mute()
        {
            Profile.Mute = !Profile.Mute;
            GetComponent<AudioPlayer>().Refresh();
        }

        public void OpenTeam()
        {
            if (ViewBase.Current is Menu)
            {
                GetComponent<Team>().Open();
            }
        }
    }
}