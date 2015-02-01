using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Game
    {
        private GameState _state;

        public void ShowLevels()
        {
            GetComponent<SelectLevel>().Open();
        }

        public void StartGame(object level)
        {
            if (_state != GameState.Ready) return;

            var progress = int.Parse(level.ToString());

            Level = GameData.Levels[progress];
            Level.Progress = progress;

            GetComponent<Views.Game>().Open(BeginGame);

            _state = GameState.Game;
        }

        public void CompleteGame()
        {
            if (_state != GameState.Game) return;

            var score = CalcScore();
            var scores = GetComponent<Score>();

            if (score >= Level.Target && Profile.Progress == Level.Progress)
            {
                Profile.Progress++;
                Debug.Log(Profile.Progress);
            }

            scores.Set(score >= Level.Target);
            scores.Open();

            _state = GameState.Ready;
        }

        public void RestartGame()
        {
            if (_state != GameState.Ready) return;

            GetComponent<Views.Game>().Open(BeginGame);

            _state = GameState.Game;
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
        }
    }
}