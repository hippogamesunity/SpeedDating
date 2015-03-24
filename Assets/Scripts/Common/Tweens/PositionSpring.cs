using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public class PositionSpring : TweenBase
    {
        public Vector2 From;
        public Vector2 To;
        public float Dumping;

        private float _amplitude = 1;
        private Vector2 _pos;

        public void Start()
        {
            _pos = transform.localPosition;
        }

        public void Update()
        {
            _amplitude = Mathf.Max(0, _amplitude - Dumping * Time.deltaTime);

            transform.localPosition = _pos + (From + (To - From) * Basis()) * _amplitude;
            
            if (_amplitude <= 0)
            {
                enabled = false;
            }
        }

        public override void OnEnable()
        {
            base.OnEnable();
            _amplitude = 1;
        }
    }
}