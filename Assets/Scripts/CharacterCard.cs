using System;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class CharacterCard : Script
    {
        public CharacterId Id;
        public UISprite Image;
        public UILabel Name;
        public UITexture Frame;
        public SelectButton Button;

        public void Awake()
        {
            Refresh();
        }

        public void Refresh()
        {
            var id = Convert.ToString(Id);

            Image.spriteName = id;
            Button.Params = id;

            if (Profile.CharacterUnlocked(Id))
            {
                Image.color = Color.white;
                Name.color = Id >= CharacterId.f1 ? ColorHelper.GetColor(255, 100, 150) : ColorHelper.GetColor(0, 210, 255);
            }
            else
            {
                Image.color = Name.color = ColorHelper.GetColor(0, 0, 0, 150);
            }

            Name.SetText(GameData.GetNameById(id));
        }
    }
}