using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Coins : Script
    {
        public UITexture Icon;
        public UILabel Value;

        private float _delta;

        public void OnEnable()
        {
            Refresh();
        }

        public void Update()
        {
            Icon.transform.localPosition = new Vector3(Icon.transform.localPosition.x, _delta * Mathf.Sin(30 * Time.time));
            _delta = Mathf.Max(0, _delta - 10 * Time.deltaTime);
        }

        public void Refresh(bool spring = false)
        {
            Value.SetText(Profile.Coins);
            _delta = spring ? 10 : 0;
        }
    }
}