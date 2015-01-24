using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Character : GameButton
    {
        public string Id;
        public Vector3 Position;
        public Table Table;

        private Vector3 _delta;

        public new void Awake()
        {
            base.Awake();

            Position = transform.localPosition;

            var tables = FindObjectsOfType<Table>().ToList();

            tables.Sort((a, b) => Vector2.Distance(transform.position, a.transform.position).CompareTo(Vector2.Distance(transform.position, b.transform.position)));

            Table = tables[0];
        }

        public void Update()
        {
            if (_down)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _delta;
            }
        }

        protected override void OnPress(bool down)
        {
            base.OnPress(down);

            _delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

            if (!down)
            {
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
                }
            }
        }
    }
}