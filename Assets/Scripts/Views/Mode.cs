using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Mode : ViewBase
    {
        public GameButton HardLevelsButton;
        public GameButton MaxLevelsButton;
        public GameButton RankingsButton;

        protected override void Initialize()
        {
            EnableButton(HardLevelsButton, Profile.ProgressEasy >= GameData.EasyLevels.Count || Settings.Debug);
            EnableButton(MaxLevelsButton, false);

            RankingsButton.Enabled = false;
            RankingsButton.GetComponent<UITexture>().mainTexture = Resources.Load<Texture2D>(RankingsButton.Enabled ? "Images/UI/RankingsButton" : "Images/UI/RankingsButtonDisabled");
        }

        private void EnableButton(GameButton button, bool enable)
        {
            button.Enabled = enable;
            button.GetComponent<UITexture>().mainTexture = Resources.Load<Texture2D>(enable ? "Images/UI/ButtonLong" : "Images/UI/ButtonLongDisabled");
        }
    }
}