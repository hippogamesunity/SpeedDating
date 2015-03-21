using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public abstract class TweenBase : Script
    {
        public float Speed;
        public float Period;

        protected float Basis()
        {
            return (Mathf.Sin(Speed * Time.time + Mathf.Rad2Deg * Period) + 1) / 2;
        }
    }
}