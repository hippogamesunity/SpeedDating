namespace Assets.Scripts.Views
{
    public class Deluxe : ViewBase
    {
        public void BuyDeluxe()
        {
            if (!Profile.Deluxe)
            {
                Get<GameShop>().Buy(GameShop.SkuDeluxe);
            }
        }

        public void RestoreDeluxe()
        {
            if (!Profile.Deluxe)
            {
                Get<GameShop>().Restore();
            }
        }
    }
}