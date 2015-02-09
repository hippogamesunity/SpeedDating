using System;
using System.Collections;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts
{
    public class AudioPlayer : Script
    {
        public AudioSource AudioSource;
        public AudioClip[] Music;
        public AudioClip BlinkSound;
        public AudioClip SuccessSound;
        public UITexture MuteButton;

        public void Awake()
        {
            Refresh();
            PlayMusic();
        }

        public void Refresh()
        {
            AudioSource.mute = Profile.Mute;
            MuteButton.mainTexture = Resources.Load<Texture2D>(Profile.Mute ? "Images/UI/UnmuteButton" : "Images/UI/MuteButton");
        }

        public void PlayMusic()
        {
            var track = Music[CRandom.GetRandom(0, Music.Length)];

            StartCoroutine(PlayInGameNext(track, 0));
        }

        public void PlayMusicByIndex(object index)
        {
            StartCoroutine(PlayInGameNext(Music[Convert.ToInt32(index)], 0));
        }

        public void Blink()
        {
            PlayEffect(BlinkSound);
        }

        public void Success()
        {
            PlayEffect(SuccessSound);
        }

        private void PlayEffect(AudioClip clip)
        {
            if (Profile.Mute) return;

            var audioSource = gameObject.AddComponent<AudioSource>();

            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(clip);
            Destroy(audioSource, clip.length);
        }

        private IEnumerator PlayInGameNext(AudioClip clip, float seconds)
        {
            yield return new WaitForSeconds(seconds);

            AudioSource.Stop();
            AudioSource.clip = clip;
            AudioSource.loop = false;
            AudioSource.Play();

            var nexts = Music.Where(i => i != clip).ToList();
            var next = nexts[CRandom.GetRandom(0, nexts.Count)];

            StartCoroutine(PlayInGameNext(next, next.length));
        }
    }
}