using System;
using Assets.Scripts.Common;

namespace Assets.Scripts
{
    public class CharacterCard : Script
    {
        public CharacterId Id;
        public UISprite Image;
        public UILabel Name;
        public UISprite Frame;
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
                    Frame.spriteName = "UnlockedFrame";
                    Button.ListenerMethodUp = "ShowStory";
                    break;
                case CharacterState.Locked:
                    Name.SetLocalizedText("%Locked%");
                    Frame.spriteName = "LockedFrame";
                    Button.ListenerMethodUp = "OfferUnlock";
                    break;
                case CharacterState.ForSale:
                    Name.SetLocalizedText("%Purchase%");
                    Frame.spriteName = "ForSaleFrame";
                    Button.ListenerMethodUp = "OfferPurchase";
                    break;
            }
        }
    }
}