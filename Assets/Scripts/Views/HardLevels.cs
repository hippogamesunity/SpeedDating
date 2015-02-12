using System.Collections.Generic;

namespace Assets.Scripts.Views
{
    public class HardLevels : EasyLevels
    {
        protected override string ListenerMethodUp
        {
            get { return "PlayHardLevel"; }
        }

        protected override int Progress
        {
            get { return Profile.ProgressHard; }
        }

        protected override List<Level> LevelsList
        {
            get { return Levels.HardLevels; }
        }
    }
}