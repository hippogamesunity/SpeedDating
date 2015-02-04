using UnityEngine;

namespace Assets.Scripts
{
    public class AudioPlayer : Script
    {
        public AudioSource Music;
        public AudioClip BlinkSound;
        public AudioClip SuccessSound;
        public UITexture MuteButton;

        public void Awake()
        {
            Refresh();
        }

        public void Refresh()
        {
            Music.mute = Profile.Mute;
            MuteButton.mainTexture = Resources.Load<Texture2D>(Profile.Mute ? "Images/UI/UnmuteButton" : "Images/UI/MuteButton");
        }

        public void Blink()
        {
            PlayEffect(BlinkSound);
        }

        public void Success()
        {
            PlayEffect(SuccessSound);
        }

        private void PlayEffect(AudioClip audioClip)
        {
            if (Profile.Mute) return;

            var audioSource = gameObject.AddComponent<AudioSource>();

            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(audioClip);
            Destroy(audioSource, audioClip.length);
        }
    }
}