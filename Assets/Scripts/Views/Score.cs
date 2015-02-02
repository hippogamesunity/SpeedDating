using Assets.Scripts.Common;

namespace Assets.Scripts.Views
{
    public class Score : ViewBase
    {
        public UILabel Result;

        public void Set(bool completed)
        {
            Result.SetText(completed ? "Completed" : "Failed");
        }
    }
}