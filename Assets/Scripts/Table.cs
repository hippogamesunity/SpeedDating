using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class Table : Script
    {
        public void Start()
        {
            Refresh();
        }

        public void Refresh()
        {
            var characters = FindObjectsOfType<Character>().Where(i => i.Table == this).ToList();

            Debug.Log(string.Format("Table {0}: {1} + {2}", name, characters[0].Id, characters[1].Id));
        }
    }
}
