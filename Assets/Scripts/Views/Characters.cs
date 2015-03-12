using System.Linq;
using Assets.Scripts.Common;
using Assets.Scripts.Logic;

namespace Assets.Scripts.Views
{
    public class Characters : ViewBase
    {
        public TweenPanel[] Pages;
        public UILabel StoryText;
        public UILabel PriceText;
        public UITexture CoinsIcon;
        public GameButton UnlockButton;

        public static CharacterId Selected;

        protected override void Initialize()
        {
            Pages[0].Show(0f);
            Pages[1].Hide(TweenDirection.Right, 0);
            StoryText.enabled = true;
            StoryText.SetLocalizedText("%SelectCard%");
            PriceText.enabled = CoinsIcon.enabled = false;
            UnlockButton.Enabled = false;
        }

        public void SelectCharacterCard(object character)
        {
            Selected = character.ToString().ToEnum<CharacterId>();

            var locked = true;

            if (Profile.GetCharacterState(Selected) == CharacterState.Locked)
            {
                PriceText.SetLocalizedText("%Unlock%", GameData.GetNameById(Selected), GameData.CharacterPrice[Selected]);
            }
            else
            {
                StoryText.SetLocalizedText(string.Format("%{0}Story%", Selected));
                locked = false;
            }

            StoryText.enabled = !locked;
            PriceText.enabled = CoinsIcon.enabled = locked;
            UnlockButton.Enabled = locked;
        }

        public void UnlockCharacter()
        {
            var price = GameData.CharacterPrice[Selected];

            if (Profile.Coins >= price)
            {
                Profile.Coins -= price;
                Profile.SetCharacterState(Selected, CharacterState.Unlocked);
                Get<Engine>().RefreshCoins();
                FindObjectsOfType<CharacterCard>().Single(i => i.Id == Selected).Refresh();
                SelectCharacterCard(Selected);
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
    }
}