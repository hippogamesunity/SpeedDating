using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Menu : ViewBase
    {
        public GameObject PremiumButton;

        public void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
            PremiumButton.SetActive(!Profile.Premium);
        }

        public void BuyPremium()
        {
            if (!Profile.Premium)
            {
                Get<GameShop>().Buy(GameShop.SkuPremium);
            }
        }
    }
}