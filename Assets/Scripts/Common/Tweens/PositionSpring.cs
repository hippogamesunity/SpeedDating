using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public class PositionSpring : TweenBase
    {
        public Vector2 From;
        public Vector2 To;

        private Vector2 _pos;

        public void Start()
        {
            _pos = transform.localPosition;
        }

        public void Update()
        {
            transform.localPosition = _pos + From + (To - From) * Basis();
        }
    }
}