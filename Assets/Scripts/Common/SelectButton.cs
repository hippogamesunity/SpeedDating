using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class SelectButton : GameButton
    {
        public event Action Selected = () => { };
        public event Action Unselected = () => { };
        public event Action Confirmed = () => { };

        public int Tag = 0;
        private static readonly SortedDictionary<int, SelectButton> SelectedButtons = new SortedDictionary<int, SelectButton>();

        public bool Pressed
        {
            get { return SelectedButtons.ContainsKey(Tag) && SelectedButtons[Tag] == this; }
            set { if (Pressed != value) OnPress(value); }
        }

        protected override void OnPress(bool down)
        {
            if (!enabled || !down) return;

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
                    SelectedButtons[Tag].Unselected();
                }
            }

            Tween(true);
            SelectedButtons[Tag] = this;
        }
    }
}