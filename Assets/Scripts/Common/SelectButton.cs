using System;
using System.Collections.Generic;

namespace Assets.Scripts.Common
{
    public class SelectButton : GameButton
    {
        public event Action Selected = () => { };
        public event Action Confirmed = () => { };

        public int Tag = 0;
        private static readonly SortedDictionary<int, SelectButton> SelectedButtons = new SortedDictionary<int, SelectButton>();

        public bool Pressed
        {
            get { return SelectedButtons.ContainsKey(Tag) && SelectedButtons[Tag] == this; }
            set { if (value) Select(); else Unselect(); }
        }

        protected override void OnPress(bool down)
        {
            if (!enabled || !down || Pressed) return;

            Select();
        }

        private void Select()
        {
            ActionUp();
            Selected();

            if (SelectedButtons.ContainsKey(Tag))
            {
                if (SelectedButtons[Tag] == this)
                {
                    Confirmed();
                }
                else if (SelectedButtons[Tag] != null)
                {
                    SelectedButtons[Tag].Tween(false);
                }
            }

            SelectedButtons[Tag] = this;
            Tween(true);
        }

        private void Unselect()
        {
            if (SelectedButtons.ContainsKey(Tag) && SelectedButtons[Tag] == this)
            {
                SelectedButtons.Remove(Tag);
            }

            Tween(false);
        }
    }
}