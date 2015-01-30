using UnityEngine;

public class AudioPlayer : Script
{
    public AudioClip BlinkSound;

    public void Blink()
    {
        PlayEffect(BlinkSound);
    }

    private void PlayEffect(AudioClip audioClip)
    {
        var audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.volume = 0.5f;
        audioSource.PlayOneShot(audioClip);
        Destroy(audioSource, audioClip.length);
    }
}