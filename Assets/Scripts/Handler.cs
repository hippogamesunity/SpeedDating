using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Engine
    {
        public void ShowLevels()
        {
            GetComponent<SelectLevel>().Open();
        }

        public void Shifted()
        {
            _shifts++;
        }

        public void GoBack()
        {
            if (ViewBase.Current is Menu)
            {
                Application.Quit();
            }
            else if (ViewBase.Current is SelectLevel)
            {
                GetComponent<Menu>().Open();
            }
            else if (ViewBase.Current is Play)
            {
                if (State == GameState.Playing)
                {
                    PauseGame();
                }
                else
                {
                    ResumeGame();
                }
            }
        }

        public void Mute()
        {
            Profile.Mute = !Profile.Mute;
            GetComponent<AudioPlayer>().Refresh();
        }
    }
}