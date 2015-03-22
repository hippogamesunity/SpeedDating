using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public class ColorSpring : TweenBase
    {
        public Color From;
        public Color To;

        private UIWidget _widget;

        public void Start()
        {
            _widget = GetComponent<UIWidget>();
        }

        public void Update()
        {
            _widget.color = From + (To - From) * Basis();
        }
    }
}