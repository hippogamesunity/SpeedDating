using System.Collections.Generic;

namespace Assets.Scripts.Views
{
    public class SwapLevels : Levels
    {
        protected override string ListenerMethodUp
        {
            get { return "StartSwapGameByLevel"; }
        }

        protected override int Progress
        {
            get { return Profile.SwapProgress; }
        }

        protected override List<Level> LevelsList
        {
            get { return GameData.SwapLevels; }
        }
    }
}