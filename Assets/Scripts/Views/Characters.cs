using System.Linq;
using Assets.Scripts.Common;
using Assets.Scripts.Logic;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Characters : ViewBase
    {
        public TweenPanel[] Pages;
        public UILabel StoryText;
        public GameButton BuyButton;

        public static CharacterId Selected;

        protected override void Initialize()
        {
            Pages[0].Show(0f);
            Pages[1].Hide(TweenDirection.Right, 0);
            StoryText.SetLocalizedText("%SelectCard%");
            SetBuyButton(false);
        }

        public void SelectCharacterCard(object character)
        {
            Selected = character.ToString().ToEnum<CharacterId>();

            if (Profile.CharacterUnlocked(Selected))
            {
                StoryText.SetLocalizedText(string.Format("%{0}Story%", Selected), GameData.GetNameById(Selected));
                SetBuyButton(false);
            }
            else
            {
                if (GameData.PremiumCharacters.Contains(Selected))
                {
                    StoryText.SetLocalizedText("%PremiumCharacter%");
                    SetBuyButton(false);
                }
                else
                {
                    var price = GameData.CharacterPrice[Selected];

                    StoryText.SetLocalizedText("%Unlock%", GameData.GetNameById(Selected), price, GetCoinsLocale(price));
                    SetBuyButton(Profile.Coins >= price);
                }
            }
        }

        public void UnlockCharacter()
        {
            var price = GameData.CharacterPrice[Selected];

            if (Profile.Coins >= price)
            {
                Profile.Coins -= price;
                Profile.UnlockCharacter(Selected);
                Get<Engine>().RefreshCoins();
                FindObjectsOfType<CharacterCard>().Single(i => i.Id == Selected).Refresh();
                SelectCharacterCard(Selected);
                Get<AudioPlayer>().Blink();
            }
        }

        public void NextPage()
        {
            if (Pages[0].Displayed)
            {
                Pages[0].Hide();
                Pages[1].Show();
            }
            else
            {
                Pages[1].Hide();
                Pages[0].Show();
            }
        }

        public static string GetCoinsLocale(int count)
        {
            var last = count % 10;

            switch (last)
            {
                case 1:
                    return Localization.Get("%Coins1%");
                case 2:
                case 3:
                case 4:
                    return Localization.Get("%Coins2%");
                default:
                    return Localization.Get("%Coins5%");
            }
        }

        private void SetBuyButton(bool enable)
        {
            BuyButton.Enabled = enable;
            BuyButton.GetComponent<UITexture>().mainTexture =
                Resources.Load<Texture2D>(enable ? "Images/UI/ButtonLong" : "Images/UI/ButtonLongInactive");
        }
    }
}