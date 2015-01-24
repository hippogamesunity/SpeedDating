using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts
{
    public class Game : Script
    {
        public Transform GameTransform;
        public int TimeoutSeconds;
        public UILabel Timer;

        private DateTime _timeout;
        
        public void Start()
        {
            _timeout = DateTime.Now.AddSeconds(TimeoutSeconds);

            var boys = new List<CharacterName>
            {
                CharacterName.David,
                CharacterName.James,
                CharacterName.Michael,
                CharacterName.Robert,
                CharacterName.Steven
            };
            var girls = new List<CharacterName>
            {
                CharacterName.Alice,
                CharacterName.Jessica,
                CharacterName.Judy,
                CharacterName.Lisa,
                CharacterName.Mary
            };
            var positions = new List<Vector2>
            {
                new Vector2(-200, 200),
                new Vector2(200, 200),
                new Vector2(-400, -160),
                new Vector2(0, -160),
                new Vector2(400, -160)
            };

            var random = new Random();

            boys = boys.OrderBy(item => random.Next()).ToList();
            girls = girls.OrderBy(item => random.Next()).ToList();

            for (var i = 0; i < 5; i++)
            {
                var instance = PrefabsHelper.Instantiate("Table", GameTransform);
                var characters = instance.GetComponentsInChildren<Character>();

                if (CRandom.Chance(0.5f))
                {
                    characters[0].Initialize(boys[i]);
                    characters[1].Initialize(girls[i]);
                }
                else
                {
                    characters[1].Initialize(boys[i]);
                    characters[0].Initialize(girls[i]);
                }

                instance.transform.localPosition = positions[i];
            }
        }

        public void Update()
        {
            var timespan = _timeout - DateTime.Now;

            Timer.SetText(string.Format("{0:D2}:{1:D2}", timespan.Minutes, timespan.Seconds));
        }
    }
}