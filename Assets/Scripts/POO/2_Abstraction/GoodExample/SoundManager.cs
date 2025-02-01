using UnityEngine;

namespace BestPractice.OOP.Abstraction
{
    public class SoundManager : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Start()
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
        }
        public void PlaySound(AudioClip audioClip, float volume = 1f, bool loop = false)
        {
            ConfigureAudioSource(audioClip, volume, loop);
            _audioSource.Play();
        }


        void ConfigureAudioSource(AudioClip audioClip, float volume, bool loop)
        {
            _audioSource.clip = audioClip;
            _audioSource.volume = volume;
            _audioSource.loop = loop;
        }
    }

}
