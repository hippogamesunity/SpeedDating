using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class SelectLevel : ViewBase
    {
        protected override void Initialize()
        {
            Refresh();
        }

        public void Refresh()
        {
            var progress = Profile.Progress;

            foreach (var button in Panel.GetComponentsInChildren<GameButton>().Where(i => i.ListenerMethodUp == "StartGame"))
            {
                if ((int.Parse(button.Params) <= progress || Settings.Debug) && GameData.Levels.Count > progress)
                {
                    button.Enabled = true;
                    button.GetComponent<UITexture>().mainTexture = Resources.Load<Texture2D>("Images/UI/LevelButton");
                }
                else
                {
                    button.Enabled = false;
                    button.GetComponent<UITexture>().mainTexture = Resources.Load<Texture2D>("Images/UI/LevelLockedButton");
                }
            }
        }
    }
}