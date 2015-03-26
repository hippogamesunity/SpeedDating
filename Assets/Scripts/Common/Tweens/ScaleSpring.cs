using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public class ScaleSpring : TweenBase
    {
        public float From;
        public float To;
        public float Dumping;

        private float _amplitude = 1;
        private Vector2 _scale;

        public void Start()
        {
            _scale = transform.localScale;
        }

        public void Update()
        {
            _amplitude = Mathf.Max(0, _amplitude - Dumping * Time.deltaTime);

            transform.localScale = ((From + (To - From) * Basis()) * _amplitude) * _scale;
            
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