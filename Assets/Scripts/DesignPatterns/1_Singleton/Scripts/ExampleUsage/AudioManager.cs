using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class AudioManager : Singleton<AudioManager>
    {
        public AudioSource audioSource;


        public void PlaySoundEffect(AudioClip clip)
        {
            if (audioSource == null)
                return;

            audioSource.clip = clip;

            audioSource.Stop();
            audioSource.Play();
        }
    }
}

// AudioManager.Instance.PlaySoundEffect(walkAudioclip);