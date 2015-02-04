using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Game
    {
        public void ShowLevels()
        {
            GetComponent<SelectLevel>().Open();
        }

        public void StartGame(object level)
        {
            if (State != GameState.Ready) return;

            var progress = int.Parse(level.ToString());

            Level = GameData.Levels[progress];
            Level.Progress = progress;

            GetComponent<Play>().Open(BeginGame);

            State = GameState.Playing;
        }

        public void CompleteGame()
        {
            if (State != GameState.Playing && State != GameState.Paused) return;

            var score = CalcScore();
            var scores = GetComponent<Score>();

            if (score >= Level.Target && Profile.Progress == Level.Progress)
            {
                Profile.Progress++;
            }

            scores.Set(score >= Level.Target);
            scores.Open();

            State = GameState.Ready;
        }

        public void RestartGame()
        {
            if (State != GameState.Ready) return;

            GetComponent<Play>().Open(BeginGame);

            State = GameState.Playing;
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
                CompleteGame();
            }
        }

        public void Mute()
        {
            Profile.Mute = !Profile.Mute;
            GetComponent<AudioPlayer>().Refresh();
        }
    }
}