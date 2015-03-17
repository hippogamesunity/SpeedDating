using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Menu : ViewBase
    {
        public GameButton PremiumButton;

        public void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
            PremiumButton.GetComponent<UITexture>().mainTexture =
                Resources.Load<Texture2D>(Profile.Premium ? "Images/UI/ButtonLongInactive" : "Images/UI/ButtonLong");
            PremiumButton.Enabled = !Profile.Premium;
        }

        public void BuyPremium()
        {
            if (!Profile.Premium)
            {
                Get<GameShop>().Buy(GameShop.SkuDeluxe);
            }
        }
    }
}