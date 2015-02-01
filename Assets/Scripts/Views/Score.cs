using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Score : ViewBase
    {
        public UITexture ScorePanel;

        public void Set(bool completed)
        {
            ScorePanel.mainTexture = Resources.Load<Texture2D>(completed ? "Images/UI/LevelCompletedPanel" : "Images/UI/LevelFailedPanel");
        }
    }
}