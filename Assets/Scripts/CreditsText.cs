using Assets.Scripts.Common;

namespace Assets.Scripts
{
    public class CreditsText : Script
    {
        public void OnEnable()
        {
            GetComponent<UILabel>().SetText("x {0}", Profile.Credits);
        }
    }
}