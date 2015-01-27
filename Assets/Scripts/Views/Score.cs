using Assets.Scripts.Common;
using UnityEngine;

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
                Message.color = Color.green;
            }
            else
            {
                Message.SetText("Level failed!");
                Message.color = Color.red;
            }
        }
    }
}