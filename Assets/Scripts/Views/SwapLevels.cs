using System.Collections.Generic;

namespace Assets.Scripts.Views
{
    public class SwapLevels : EasyLevels
    {
        protected override string ListenerMethodUp
        {
            get { return "PlaySwapLevel"; }
        }

        protected override int Progress
        {
            get { return Profile.ProgressSwap; }
        }

        protected override List<Level> LevelsList
        {
            get { return Levels.SwapLevels; }
        }
    }
}