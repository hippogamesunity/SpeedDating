using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Mode : ViewBase
    {
        public GameButton HardLevelsButton;
        public GameButton MaxLevelsButton;
        public GameButton RankingsButton;

        public void ShowEasyLevels()
        {
            if (Current is Mode)
            {
                GetComponent<EasyLevels>().Open();
            }
        }

        public void ShowHardLevels()
        {
            if (Current is Mode)
            {
                GetComponent<HardLevels>().Open();
            }
        }

        public void ShowSwapLevels()
        {
            if (Current is Mode)
            {
                GetComponent<SwapLevels>().Open();
            }
        }

        public void ShowMemoLevels()
        {
            if (Current is Mode)
            {
                GetComponent<MemoLevels>().Open();
            }
        }

        public void OpenTeam()
        {
            if (Current is Mode)
            {
                GetComponent<Team>().Open();
            }
        }

        protected override void Initialize()
        {
            EnableButton(HardLevelsButton, Profile.Deluxe || Settings.Debug);
            EnableButton(MaxLevelsButton, false);

            RankingsButton.Enabled = false;
            RankingsButton.GetComponent<UITexture>().mainTexture = Resources.Load<Texture2D>(RankingsButton.Enabled ? "Images/UI/RankingsButton" : "Images/UI/RankingsButtonDisabled");
        }

        private void EnableButton(GameButton button, bool enable)
        {
            button.Enabled = enable;
            button.GetComponent<UITexture>().mainTexture = Resources.Load<Texture2D>(enable ? "Images/UI/ButtonLong" : "Images/UI/ButtonLongInactive");
        }
    }
}