using Assets.Scripts.Common;

namespace Assets.Scripts.Views
{
    public class Score : ViewBase
    {
        public UILabel Title;
        public UILabel Message;

        public void Set(bool completed)
        {
            Title.SetText(completed ? "Win" : "Time is up");
            Message.SetText(completed ? "Congratulation, level completed!" : "Better luck next time!");
        }
    }
}