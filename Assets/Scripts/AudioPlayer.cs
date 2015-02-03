using UnityEngine;

namespace Assets.Scripts
{
    public class AudioPlayer : Script
    {
        public AudioClip BlinkSound;
        public AudioClip SuccessSound;

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
            var audioSource = gameObject.AddComponent<AudioSource>();

            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(audioClip);
            Destroy(audioSource, audioClip.length);
        }
    }
}