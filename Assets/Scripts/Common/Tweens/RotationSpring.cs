using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public class RotationSpring : TweenBase
    {
        public float From;
        public float To;

        private float _rotation;

        public void Start()
        {
            _rotation = 2 * Mathf.Rad2Deg * transform.localRotation.z;
        }

        public void Update()
        {
            var angle = _rotation + From + (To - From) * Basis();

            transform.localRotation = Quaternion.Euler(0, 0, angle);
        }
    }
}