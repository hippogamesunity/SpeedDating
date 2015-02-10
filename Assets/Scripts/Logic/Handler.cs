using System;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public partial class Engine
    {
        public void ShowModes()
        {
            if (ViewBase.Current is Menu)
            {
                GetComponent<Mode>().Open();
            }
        }

        public void ShowEasyLevels()
        {
            if (ViewBase.Current is Mode)
            {
                GetComponent<EasyLevels>().Open();
            }
        }

        public void ShowHardLevels()
        {
            if (ViewBase.Current is Mode)
            {
                GetComponent<HardLevels>().Open();
            }
        }

        public void ShowSwapLevels()
        {
            if (ViewBase.Current is Mode)
            {
                GetComponent<SwapLevels>().Open();
            }
        }

        public void PlayEasyLevel(object level)
        {
            if (ViewBase.Current is EasyLevels)
            {
                var progress = Convert.ToInt32(level);

                Level = GameData.EasyLevels[progress];
                Level.Progress = progress;

                StartGame();
            }
        }

        public void PlayHardLevel(object level)
        {
            if (ViewBase.Current is HardLevels)
            {
                var progress = Convert.ToInt32(level);

                Level = GameData.HardLevels[progress];
                Level.Progress = progress;

                StartGame();
            }
        }

        public void PlaySwapLevel(object level)
        {
            if (ViewBase.Current is SwapLevels)
            {
                var progress = Convert.ToInt32(level);

                Level = GameData.SwapLevels[progress];
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

        public void ShowLevelPage(object index)
        {
            if (ViewBase.Current is EasyLevels)
            {
                var view = GetComponent<EasyLevels>();

                view.Page = view.Page == 0 ? 1 : 0;
                view.Open();
            }
        }
    }
}