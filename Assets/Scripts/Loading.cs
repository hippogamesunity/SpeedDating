using UnityEngine;

namespace Assets.Scripts
{
    public class Loading : Script
    {
        public GameObject Panel;

        public void Awake()
        {
            Panel.GetComponent<UIPanel>().alpha = 1;
        }

        public void Open(float duration)
        {
            TweenAlpha.Begin(Panel, duration, 1);
        }

        public void Close(float duration)
        {
            TweenAlpha.Begin(Panel, duration, 0);
        }
    }
}