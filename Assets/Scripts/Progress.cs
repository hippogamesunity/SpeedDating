using UnityEngine;

namespace Assets.Scripts
{
    public class Progress : Script
    {
        public UIBasicSprite Image;
        public UIBasicSprite Frame;

        private float _time;

        public void Update()
        {
            if (_time <= 0) return;

            if (Image.fillAmount < 1)
            {
                Image.fillAmount += Time.deltaTime / _time;
            }
            else if (Image.fillAmount > 1)
            {
                //Image.fillAmount = 1;
            }
        }

        public void Animate(float time)
        {
            Image.fillAmount = 0;
            _time = time;
        }

        public void Show(float time)
        {
            TweenAlpha.Begin(gameObject, time, 0.75f);
        }

        public void Hide(float time)
        {
            if (this == null) return;

            TweenAlpha.Begin(gameObject, time, 0);
        }
    }
}