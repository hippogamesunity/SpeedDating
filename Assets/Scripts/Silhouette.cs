using UnityEngine;

namespace Assets.Scripts
{
    public class Silhouette : Script
    {
        public GameObject MoscowSilhouette;
        public GameObject NYSilhouette;

        public void Awake()
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Russian:
                case SystemLanguage.Ukrainian:
                case SystemLanguage.Belarusian:
                    MoscowSilhouette.SetActive(true);
                    NYSilhouette.SetActive(false);
                    break;
                default:
                    MoscowSilhouette.SetActive(false);
                    NYSilhouette.SetActive(true);
                    break;
            }
        }
    }
}