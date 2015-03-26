using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using Assets.Scripts.Common.Tweens;
using Assets.Scripts.Logic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Character : GameButton
    {
        public UISprite MaleImage;
        public UISprite FemaleImage;
        public UILabel Name;
        public UISprite Hobby;
        public Hobby[] HobbiesDebug;
        public PositionSpring PositionSpring;

        [HideInInspector] public Person Person;
        [HideInInspector] public Vector3 Position;
        [HideInInspector] public Table Table;
        [HideInInspector] public bool Busy;

        private UISprite _image;
        private Vector3 _delta;
        private int _hobby;

        public void Initialize(Person person)
        {
            Person = person;

            HobbiesDebug = person.Hobbies.ToArray();

            Name.SetText(person.Name);
            Position = transform.localPosition;

            var tables = FindObjectsOfType<Table>().ToList();

            tables.Sort((a, b) => Vector2.Distance(transform.position, a.transform.position).CompareTo(Vector2.Distance(transform.position, b.transform.position)));
            Table = tables[0];
            
            if (Engine.Level.Type == LevelType.Memo)
            {
                Hobby.enabled = false;
            }
            else
            {
                HobbyLoop();
            }

            FemaleImage.enabled = MaleImage.enabled = false;

            _image = person.Male ? MaleImage : FemaleImage;
            _image.enabled = true;
            _image.spriteName = person.Image;

            Flip();
        }

        public new void Update()
        {
            if (Busy || Engine.State != GameState.Playing)
            {
                if (_down)
                {
                    OnPress(false);
                }

                return;
            }

            if (_down)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _delta;
            }
        }

        public void HobbyLoop()
        {
            var duration = 2 + 1 * CRandom.GetRandom(200) / 100f;

            if (Person.Hobbies.Count == 0)
            {
                Hobby.enabled = false;
            }
            else if (Engine.State == GameState.Playing)
            {
                Hobby.spriteName = Convert.ToString(Person.Hobbies[_hobby++]);

                if (_hobby == Person.Hobbies.Count)
                {
                    _hobby = 0;
                }

                TweenAlpha.Begin(Hobby.gameObject, 0.4f, 1);
                TaskScheduler.CreateTask(() => TweenAlpha.Begin(Hobby.gameObject, 0.4f, 0), Engine.TaskId, duration);
            }

            TaskScheduler.CreateTask(HobbyLoop, Engine.TaskId, duration + 1);
        }

        public int Sympathy
        {
            set
            {
                switch (value)
                {
                    case 0:
                        _image.spriteName = Person.Image + "no";
                        break;
                    case 1:
                        _image.spriteName = Person.Image;
                        break;
                    default:
                        _image.spriteName = Person.Image + "yes";
                        break;
                }
            }
        }

        protected override void OnPress(bool down)
        {
            const float tweenTime = 0.2f;

            if ((Engine.State != GameState.Playing && down) || Busy || !Engine.CanShift || Engine.Level.Memorize) return;

            base.OnPress(down);

            _delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

            if (down)
            {
                _image.depth = 50;
            }
            else
            {
                _image.depth = 0;

                var characters = FindObjectsOfType<Character>().ToList();

                characters.Remove(this);

                Character nearest = null;
                var minDistance = float.MaxValue;

                foreach (var character in characters)
                {
                    var distance = Vector2.Distance(transform.parent.localPosition / transform.parent.localScale.x
                        + transform.localPosition, character.transform.parent.localPosition / character.transform.parent.localScale.x + character.transform.localPosition);

                    if (distance < 200 && distance < minDistance)
                    {
                        nearest = character;
                        minDistance = distance;
                    }
                }

                if (nearest == null || nearest.Busy)
                {
                    TweenPosition.Begin(gameObject, tweenTime, Position);
                }
                else
                {
                    var transformParent = nearest.transform.parent;
                    nearest.transform.parent = transform.parent;
                    transform.parent = transformParent;

                    TweenPosition.Begin(gameObject, tweenTime, nearest.Position);
                    TweenPosition.Begin(nearest.gameObject, tweenTime, Position);

                    var pos = Position;
                    
                    Position = nearest.Position;
                    nearest.Position = pos;

                    var table = Table;

                    Table = nearest.Table;
                    nearest.Table = table;
                    
                    Flip();
                    nearest.Flip();

                    if (Table != nearest.Table)
                    {
                        Table.Refresh();
                        nearest.Table.Refresh();
                        Find<Engine>().Swapped();
                    }

                    TaskScheduler.CreateTask(() => nearest.PositionSpring.enabled = true, tweenTime);
                }

                TaskScheduler.CreateTask(() => PositionSpring.enabled = true, tweenTime);
            }
        }

        private void Flip()
        {
            _image.flip = Table.transform.position.x < Position.x ? UIBasicSprite.Flip.Horizontally : UIBasicSprite.Flip.Nothing;
        }
    }
}