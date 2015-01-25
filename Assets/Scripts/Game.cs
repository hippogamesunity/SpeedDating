using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using Assets.Scripts.Views;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts
{
    public class Game : Script
    {
        public Transform GameTransform;
        public int TimeoutSeconds;
        public UILabel Timer;
        public UISprite TimerProgress;
        public UITexture Background;
        public static readonly Dictionary<CharacterName, List<CharacterInterest>> Interests = new Dictionary<CharacterName, List<CharacterInterest>>
        {
            { CharacterName.Alice, new List<CharacterInterest> { CharacterInterest.Books, CharacterInterest.Flowers, CharacterInterest.Clothing } },
            { CharacterName.Jessica, new List<CharacterInterest> { CharacterInterest.Cars, CharacterInterest.Photo, CharacterInterest.Sport } },
            { CharacterName.Judy, new List<CharacterInterest> { CharacterInterest.Books, CharacterInterest.Cars, CharacterInterest.Drink, CharacterInterest.Money } },
            { CharacterName.Lisa, new List<CharacterInterest> { CharacterInterest.Food, CharacterInterest.Drink, CharacterInterest.Photo } },
            { CharacterName.Mary, new List<CharacterInterest> { CharacterInterest.Games, CharacterInterest.Animals,CharacterInterest.Games } },
            { CharacterName.David, new List<CharacterInterest> { CharacterInterest.Flowers, CharacterInterest.Sport, CharacterInterest.Money } },
            { CharacterName.James, new List<CharacterInterest> { CharacterInterest.Books, CharacterInterest.Cars, CharacterInterest.Clothing } },
            { CharacterName.Michael, new List<CharacterInterest> { CharacterInterest.Books, CharacterInterest.Cars, CharacterInterest.Animals } },
            { CharacterName.Robert, new List<CharacterInterest> { CharacterInterest.Games, CharacterInterest.Sport, CharacterInterest.Drink } },
            { CharacterName.Steven, new List<CharacterInterest> { CharacterInterest.Drink, CharacterInterest.Games, CharacterInterest.Cars } }
        };
        public static int Level;
        private DateTime _timeout;

        public void Start()
        {
            GetComponent<Menu>().Open();
        }

        public void ShowLevels()
        {
            GetComponent<Levels>().Open();
        }

        public void StartGame(object level)
        {
            Level = int.Parse(level.ToString());
            GetComponent<Views.Game>().Open(BeginGame);
        }

        public void CompleteGame()
        {
            GetComponent<Score>().Open();
        }

        public void BeginGame()
        {
            GetComponent<Views.Game>().Open();

            foreach (var table in FindObjectsOfType<Table>())
            {
                Destroy(table.gameObject);
            }

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
                new Vector2(-320, 80),
                new Vector2(320, 80),
                new Vector2(0, -120),
                new Vector2(-440, -260),
                new Vector2(440, -260)
            };

            //var random = new Random();

            //boys = boys.OrderBy(item => random.Next()).ToList();
            //girls = girls.OrderBy(item => random.Next()).ToList();

            for (var i = 0; i < (Level == 0 ? 3 : 5); i++)
            {
                var instance = PrefabsHelper.Instantiate(Level == 0 ? "BurgerKingTable" : "RestaurantTable", GameTransform);
                var characters = instance.GetComponentsInChildren<Character>();

                Background.mainTexture = Resources.Load<Texture2D>(Level == 0 ? "Images/Background/BurgerKing" : "Images/Background/Restaurant");

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
                instance.transform.localScale = 0.75f * Vector3.one;
            }
        }

        public void Update()
        {
            if (ViewBase.Current is Views.Game)
            {
                var timespan = _timeout - DateTime.Now;

                if (timespan.TotalSeconds > 0)
                {
                    Timer.SetText(Convert.ToString(Math.Round(timespan.TotalSeconds)));
                    TimerProgress.fillAmount = (float) timespan.TotalSeconds/TimeoutSeconds;
                }
                else
                {
                    GetComponent<Score>().Open();
                }
            }
        }
    }
}