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
        public GameButton Button;

        public void OnEnable()
        {
            Refresh();
        }

        public void Refresh()
        {
            var state = Profile.GetCharacterState(Id);
            var id = Convert.ToString(Id);

            Image.spriteName = id;
            Button.Params = id;

            switch (state)
            {
                case CharacterState.Unlocked:
                    Image.color = Color.white;
                    Name.SetLocalizedText(GameData.GetNameById(id));
                    Frame.mainTexture = Resources.Load<Texture2D>("Images/UI/CardFrame");
                    break;
                case CharacterState.Locked:
                    Image.color = ColorHelper.GetColor(0, 0, 0, 150);
                    Name.SetLocalizedText(GameData.GetNameById(id));
                    Frame.mainTexture = Resources.Load<Texture2D>("Images/UI/CardFrameLocked");
                    break;
            }
        }
    }
}