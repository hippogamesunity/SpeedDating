using System;
using System.Linq;
using System.Xml.Schema;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class Character : GameButton
    {
        public UISprite Image;
        public UILabel Name;
        public UISprite Interest;
        public Hobby[] HobbiesDebug;

        [HideInInspector] public Person Person;
        [HideInInspector] public Vector3 Position;
        [HideInInspector] public Table Table;
        [HideInInspector] public bool Busy;

        private Vector3 _delta;

        public void Initialize(Person person)
        {
            Person = person;

            HobbiesDebug = person.Hobbies.ToArray();

            Name.SetText(person.Name);
            Image.spriteName = person.Image;
            Position = transform.localPosition;

            var tables = FindObjectsOfType<Table>().ToList();

            tables.Sort((a, b) => Vector2.Distance(transform.position, a.transform.position).CompareTo(Vector2.Distance(transform.position, b.transform.position)));
            Table = tables[0];
            Interest.color = person.Male ? ColorHelper.GetColor(0, 120, 255) : ColorHelper.GetColor(200, 0, 200);
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
            if (this == null) return; // TODO:

            var duration = 2 + CRandom.GetRandom(200) / 100f;

            if (Person.Hobbies.Count == 0)
            {
                Interest.enabled = false;
            }
            else
            {
                Interest.spriteName = Convert.ToString(Person.Hobbies[CRandom.GetRandom(0, Person.Hobbies.Count)]);
                TweenAlpha.Begin(Interest.gameObject, 0.4f, 1);
                TaskScheduler.CreateTask(() =>
                {
                    if (this == null) return;

                    TweenAlpha.Begin(Interest.gameObject, 0.4f, 0);
                }, duration);
            }

            TaskScheduler.CreateTask(InterestsLoop, duration + 1);
        }

        public int Sympathy
        {
            set
            {
                switch (value)
                {
                    case 0:
                        Image.spriteName = Person.Image + "no";
                        break;
                    case 1:
                        Image.spriteName = Person.Image;
                        break;
                    default:
                        Image.spriteName = Person.Image + "yes";
                        break;
                }
            }
        }

        protected override void OnPress(bool down)
        {
            if (Busy || !Find<Game>().CanShift()) return;

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

                var nearest = buttons.FirstOrDefault(i => Vector2.Distance(transform.parent.localPosition / transform.parent.localScale.x
                    + transform.localPosition, i.transform.parent.localPosition / transform.parent.localScale.x + i.transform.localPosition) < 100);

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

                    Find<Game>().Shifted();
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