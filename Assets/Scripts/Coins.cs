using Assets.Scripts.Common;

namespace Assets.Scripts
{
    public class Coins : Script
    {
        public void OnEnable()
        {
            Refresh();
        }

        public void Refresh()
        {
            GetComponent<UILabel>().SetText(Profile.Coins);
        }
    }
}