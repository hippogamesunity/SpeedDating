using System;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class GameButton : Script
    {
        public Color ColorDown = Color.white;
        public Color ColorDisabled = Color.gray;
        public float ScaleDown = 1.2f;
        public float TweenTimeDown = 0.1f;
        public float TweenTimeUp = 0.4f;
        public MonoBehaviour Listener;
        public string ListenerMethodDown;
        public string ListenerMethodUp;
        public string Params;
        public event Action Down = () => {};
        public event Action Up = () => {};

        private Color _color = Color.clear;
        private bool _enabled = true;

        public void Awake()
        {
            PickColor();
        }

        protected bool _down;

        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                if (_enabled == value) return;

                _enabled = value;
                GetComponent<Collider2D>().enabled = _enabled;
                TweenEnabled(_enabled, TweenTimeDown);
            }
        }

        public Color Color
        {
            get
            {
                if (_color != Color.clear) return _color;

                PickColor();

                return _color;
            }
            set { _color = value; }
        }

        public void ChangeColor(Color color, float duration)
        {
            _color = color;
            TweenColor.Begin(gameObject, duration, _color);
        }

        protected virtual void OnPress(bool down)
        {
            if (!enabled) return;

            Tween(down);

            if (down)
            {
                ActionDown();
                Down();
            }
            else
            {
                if (_down)
                {
                    ActionUp();
                    Up();
                }
            }

            _down = down;
        }

        protected virtual void ActionDown()
        {
            if (Listener == null || string.IsNullOrEmpty(ListenerMethodDown)) return;

            if (string.IsNullOrEmpty(Params))
            {
                Listener.SendMessage(ListenerMethodDown);
            }
            else
            {
                Listener.SendMessage(ListenerMethodDown, Params);
            }
        }

        protected virtual void ActionUp()
        {
            if (Listener == null || string.IsNullOrEmpty(ListenerMethodUp)) return;

            if (string.IsNullOrEmpty(Params))
            {
                Listener.SendMessage(ListenerMethodUp);
            }
            else
            {
                Listener.SendMessage(ListenerMethodUp, Params);
            }
        }

        protected virtual void Tween(bool down)
        {
            if (down)
            {
                TweenColor.Begin(gameObject, TweenTimeDown, ColorDown);
                TweenScale.Begin(gameObject, TweenTimeDown, ScaleDown * Vector3.one);
            }
            else
            {
                TweenColor.Begin(gameObject, TweenTimeUp, Color);
                TweenScale.Begin(gameObject, TweenTimeUp, Vector3.one);
            }
        }

        private void TweenEnabled(bool value, float duration)
        {
            TweenColor.Begin(gameObject, duration, value ? Color : ColorDisabled);
        }

        private void PickColor()
        {
            var sprite = GetComponent<UISprite>();
            var texture = GetComponent<UITexture>();
            var label = GetComponent<UILabel>();

            _color = sprite != null ? sprite.color : texture != null ? texture.color : label != null ? label.color : Color.white;
        }
    }
}