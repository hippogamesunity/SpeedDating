using System;
using Assets.Scripts.Common;

namespace Assets.Scripts
{
    public class Game : Script
    {
        public int TimeoutSeconds;
        public UILabel Timer;

        private DateTime _timeout;

        public void Start()
        {
            _timeout = DateTime.Now.AddSeconds(TimeoutSeconds);
        }

        public void Update()
        {
            var timespan = _timeout - DateTime.Now;

            Timer.SetText(string.Format("{0:D2}:{1:D2}", timespan.Minutes, timespan.Seconds));
        }
    }
}