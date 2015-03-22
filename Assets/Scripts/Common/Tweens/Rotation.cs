using UnityEngine;

namespace Assets.Scripts.Common.Tweens
{
    public class Rotation : TweenBase
    {
        public void Update()
        {
            transform.localRotation = Quaternion.Euler(0, 0, Speed * Time.time);
        }
    }
}