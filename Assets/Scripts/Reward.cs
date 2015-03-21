using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Reward : Script
    {
        public UITexture Icon;
        public UILabel Value;
        public float Delta;
        public float Speed;

        public void Update()
        {
            if (Delta <= 0) return;

            var y = Delta * Mathf.Sin(Speed * Time.time);

            Icon.transform.localPosition = new Vector3(Icon.transform.localPosition.x, y);
            Value.transform.localPosition = new Vector3(Value.transform.localPosition.x, y);
        }

        public void Initialize(int coins, string prefix = null)
        {
            gameObject.SetActive(coins > 0);

            if (coins > 0)
            {
                Value.SetText(prefix + coins);
            }
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}