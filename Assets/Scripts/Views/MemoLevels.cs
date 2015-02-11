using System.Collections.Generic;

namespace Assets.Scripts.Views
{
    public class MemoLevels : EasyLevels
    {
        protected override string ListenerMethodUp
        {
            get { return "PlayMemoLevel"; }
        }

        protected override int Progress
        {
            get { return Profile.ProgressMemo; }
        }

        protected override List<Level> LevelsList
        {
            get { return GameData.MemoLevels; }
        }
    }
}