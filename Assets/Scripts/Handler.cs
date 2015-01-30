using System;
using Assets.Scripts.Views;

namespace Assets.Scripts
{
    public partial class Game
    {
        private GameState _state;

        public void ShowLevels()
        {
            GetComponent<Levels>().Open();
        }

        public void StartGame(object level)
        {
            if (_state != GameState.Ready) return;

            Level = int.Parse(level.ToString());
            GetComponent<Views.Game>().Open(BeginGame);

            _state = GameState.Game;
        }

        public void CompleteGame()
        {
            if (_state != GameState.Game) return;

            var level = GameData.Levels[Level];
            var scores = GetComponent<Score>();

            scores.Set(CalcScore(), level.Target, level.Time, (int) (_timeout - DateTime.Now).TotalSeconds);
            scores.Open();

            _state = GameState.Ready;
        }

        public void Shifted()
        {
            _shifts++;
        }
    }
}