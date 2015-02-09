using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class SwapLevels : ViewBase
    {
        private List<GameButton> _levelButtons; 

        public void Awake()
        {
            _levelButtons = Panel.GetComponentsInChildren<GameButton>().Where(i => i.ListenerMethodUp == "StartGameByLevel").ToList();
        }

        protected override void Initialize()
        {
            Refresh();
        }

        public void Refresh()
        {
            var progress = Profile.SwapProgress;

            foreach (var button in _levelButtons)
            {
                var image = button.GetComponent<UITexture>();
                var text = button.GetComponentInChildren<UILabel>();

                if ((int.Parse(button.Params) <= progress || Settings.Debug) && GameData.SwapLevels.Count > int.Parse(button.Params))
                {
                    button.Enabled = true;
                    image.mainTexture = Resources.Load<Texture2D>("Images/UI/LevelButton");
                    text.color = ColorHelper.GetColor(255, 255, 255);
                    text.applyGradient = true;
                }
                else
                {
                    button.Enabled = false;
                    image.mainTexture = Resources.Load<Texture2D>("Images/UI/LevelLockedButton");
                    text.color = ColorHelper.GetColor(180, 180, 180);
                    text.applyGradient = false;
                }
            }
        }
    }
}