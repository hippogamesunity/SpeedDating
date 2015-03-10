using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Characters : ViewBase
    {
        public UILabel Story;

        public void ShowStory(object character)
        {
            var id = character.ToString().ToEnum<CharacterId>();

            Story.SetLocalizedText(string.Format("%{0}Story", id));
        }

        public void OfferUnlock(object character)
        {
            var id = character.ToString().ToEnum<CharacterId>();

            Debug.Log("OfferUnlock=" + id);
        }

        public void OfferPurchase(object character)
        {
            var id = character.ToString().ToEnum<CharacterId>();

            Debug.Log("OfferPurchase=" + id);
        }

        public void Unlock(CharacterId id)
        {
            if (Profile.Credits > 0)
            {
                Profile.Credits--;
                Profile.SetCharacterState(id, CharacterState.Unlocked);
            }
        }
    }
}