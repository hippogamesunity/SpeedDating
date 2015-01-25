using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Character : GameButton
    {
        public UISprite Image;
        public UILabel Name;
        public UISprite Interest;

        [HideInInspector] public CharacterName CharacterName;
        [HideInInspector] public List<CharacterInterest> CharacterInterests;
        [HideInInspector] public Vector3 Position;
        [HideInInspector] public Table Table;
        [HideInInspector] public bool Busy;

        private Vector3 _delta;


        public void Initialize(CharacterName id)
        {
            CharacterInterests = Game.Interests[id];
            CharacterName = id;
            Image.spriteName = string.Format("{0}{1}", (int) CharacterName >= 5 ? "m" : "f", (int) CharacterName >= 5 ? (int) CharacterName + 1 - 5 : (int) CharacterName + 1); // TODO:
            Name.SetText(Convert.ToString(CharacterName));

            Position = transform.localPosition;

            var tables = FindObjectsOfType<Table>().ToList();

            tables.Sort((a, b) => Vector2.Distance(transform.position, a.transform.position).CompareTo(Vector2.Distance(transform.position, b.transform.position)));
            Table = tables[0];
            Flip();
            InterestsLoop();
        }

        public void Update()
        {
            if (Busy) return;

            if (_down)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _delta;
            }
        }

        public void InterestsLoop()
        {
            var duration = 2 + CRandom.GetRandom(200) / 100f;

            if (CharacterInterests.Count == 0)
            {
                Interest.enabled = false;
            }
            else
            {
                Interest.spriteName = Convert.ToString(CharacterInterests[(int) CRandom.GetRandom(0, CharacterInterests.Count)]);
                TweenAlpha.Begin(Interest.gameObject, 0.4f, 0.8f);
                TaskScheduler.CreateTask(() => TweenAlpha.Begin(Interest.gameObject, 0.4f, 0), duration);
            }

            TaskScheduler.CreateTask(InterestsLoop, duration + 1 + CRandom.GetRandom(200) / 100f);
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

                var nearest = buttons.FirstOrDefault(i => Vector2.Distance(transform.parent.localPosition / 0.75f + transform.localPosition, i.transform.parent.localPosition / 0.75f + i.transform.localPosition) < 100);

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
                ? UIBasicSprite.Flip.Nothing
                : UIBasicSprite.Flip.Horizontally;
        }
    }
}