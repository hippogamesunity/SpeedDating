using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Characters : ViewBase
    {
        public GameObject[] Pages;
        public UILabel StoryText;
        public GameButton BuyButton;
        public Coins Coins;
        public Reward Reward;

        public static CharacterId Selected;

        protected override void Initialize()
        {
            Coins.Refresh();
            Unselect();
        }

        public void SelectCharacterCard(object character)
        {
            Selected = character.ToString().ToEnum<CharacterId>();
            Reward.Hide();

            if (Profile.CharacterUnlocked(Selected))
            {
                StoryText.SetLocalizedText(string.Format("%{0}Story%", Selected), GameData.GetNameById(Selected));
                SetBuyButton(false);
            }
            else
            {
                if (GameData.DeluxeCharacters.Contains(Selected) && !Profile.Deluxe)
                {
                    StoryText.SetLocalizedText("%DeluxeCharacter%");
                    SetBuyButton(false);
                }
                else
                {
                    var price = GameData.CharacterPrice[Selected];

                    StoryText.SetLocalizedText("%Unlock%", GameData.GetNameById(Selected));
                    Reward.Initialize(price);
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
                Coins.Refresh(spring: true);
                Get<AudioPlayer>().PlayBlink();
                FindObjectsOfType<CharacterCard>().Single(i => i.Id == Selected).Refresh();
                SelectCharacterCard(Selected);
            }
        }

        public void NextPage()
        {
            const float speed = 0.2f;

            var hide = Pages[0].activeSelf ? Pages[0] : Pages[1];
            var show = Pages[0].activeSelf ? Pages[1] : Pages[0];

            Unselect();

            foreach (var card in hide.GetComponentsInChildren<CharacterCard>())
            {
                TweenRotation.Begin(card.gameObject, speed, Quaternion.Euler(0, 90, 0));
                card.Button.Pressed = false;
            }

            TaskScheduler.CreateTask(() =>
            {
                hide.SetActive(false);
                show.SetActive(true);

                foreach (var card in hide.GetComponentsInChildren<CharacterCard>(true))
                {
                    card.transform.localRotation = Quaternion.Euler(0, 0, 0);
                }

                foreach (var card in show.GetComponentsInChildren<CharacterCard>(true))
                {
                    card.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    TweenRotation.Begin(card.gameObject, speed, Quaternion.Euler(0, 0, 0));
                }
            }, speed);
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

        private void Unselect()
        {
            StoryText.SetLocalizedText("%SelectCard%");
            Reward.Hide();
            SetBuyButton(false);
        }
    }
}