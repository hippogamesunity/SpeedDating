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
            var state = Profile.GetCharacterState(Id);
            var cname = Convert.ToString(Id);

            Image.spriteName = cname;
            Button.Params = cname;

            switch (state)
            {
                case CharacterState.Unlocked:
                    Name.SetLocalizedText(cname);
                    Frame.mainTexture = Resources.Load<Texture2D>("Images/UI/UnlockedFrame");
                    Button.ListenerMethodUp = "ShowStory";
                    break;
                case CharacterState.Locked:
                    Name.SetLocalizedText("%Locked%");
                    Frame.mainTexture = Resources.Load<Texture2D>("Images/UI/LockedFrame");
                    Button.ListenerMethodUp = "OfferUnlock";
                    break;
                case CharacterState.ForSale:
                    Name.SetLocalizedText("%Purchase%");
                    Frame.mainTexture = Resources.Load<Texture2D>("Images/UI/ForSaleFrame");
                    Button.ListenerMethodUp = "OfferPurchase";
                    break;
            }
        }
    }
}