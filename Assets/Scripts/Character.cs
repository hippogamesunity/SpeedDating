using System;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Character : GameButton
    {
        public UISprite Image;
        public UILabel Name;

        [HideInInspector] public CharacterName CharacterName;
        [HideInInspector] public Vector3 Position;
        [HideInInspector] public Table Table;
        [HideInInspector] public bool Busy;

        private Vector3 _delta;

        public void Initialize(CharacterName id)
        {
            CharacterName = id;
            Image.spriteName = Convert.ToString(CharacterName);
            Name.SetText(Convert.ToString(CharacterName));

            Position = transform.localPosition;

            var tables = FindObjectsOfType<Table>().ToList();

            tables.Sort((a, b) => Vector2.Distance(transform.position, a.transform.position).CompareTo(Vector2.Distance(transform.position, b.transform.position)));
            Table = tables[0];
            Flip();
        }

        public void Update()
        {
            if (Busy) return;

            if (_down)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _delta;
            }
        }

        protected override void OnPress(bool down)
        {
            if (Busy) return;

            base.OnPress(down);

            _delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

            if (down)
            {
                Image.depth = 50;
            }
            else
            {
                Image.depth = 0;

                var buttons = FindObjectsOfType<Character>().ToList();

                buttons.Remove(this);

                var nearest = buttons.FirstOrDefault(i => Vector2.Distance(transform.parent.localPosition + transform.localPosition, i.transform.parent.localPosition + i.transform.localPosition) < 60);

                if (nearest == null)
                {
                    TweenPosition.Begin(gameObject, 0.5f, Position);
                }
                else
                {
                    var transformParent = nearest.transform.parent;
                    nearest.transform.parent = transform.parent;
                    transform.parent = transformParent;

                    TweenPosition.Begin(gameObject, 0.5f, nearest.Position);
                    TweenPosition.Begin(nearest.gameObject, 0.5f, Position);

                    var pos = Position;
                    
                    Position = nearest.Position;
                    nearest.Position = pos;

                    var table = Table;

                    Table = nearest.Table;
                    nearest.Table = table;

                    Table.Refresh();
                    nearest.Table.Refresh();
                    
                    Flip();
                    nearest.Flip();
                }
            }
        }

        private void Flip()
        {
            Image.flip = Table.transform.position.x > Position.x
                ? UIBasicSprite.Flip.Horizontally
                : UIBasicSprite.Flip.Nothing;
        }
    }
}