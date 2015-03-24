using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public abstract class TweenBase : Script
    {
        public float Speed;
        public float Period;

        private float _time;

        public virtual void OnEnable()
        {
            _time = Time.time;
        }

        protected float Basis()
        {
            return (Mathf.Sin(Speed * (Time.time - _time) + Period * Mathf.Deg2Rad) + 1) / 2;
        }
    }
}