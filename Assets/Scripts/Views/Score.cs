using Assets.Scripts.Common;

namespace Assets.Scripts.Views
{
    public class Score : ViewBase
    {
        public UILabel Message;

        public void Set(int score, int target, int timeout, int timeleft)
        {
            if (score >= target)
            {
                Message.SetText("Level completed!");
                Message.color = ColorHelper.GetColor(100, 255, 0);
            }
            else
            {
                Message.SetText("Level failed");
                Message.color = ColorHelper.GetColor(255, 80, 40);
            }
        }
    }
}