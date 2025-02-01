using UnityEngine;

namespace BadPractice.OOP.Abstraction
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource _audioSource;
        public AudioClip _jumpSound;
        public AudioClip _damageSound;

        void PlayJumpSound()
        {
            _audioSource.clip = _jumpSound;
            _audioSource.volume = 0.5f;
            _audioSource.loop = false;
            _audioSource.Play();
        }

        void PlayDamageSound()
        {
            _audioSource.clip = _damageSound;
            _audioSource.volume = 1f;
            _audioSource.loop = false;
            _audioSource.Play();
        }

        void AdjustVolume(float newVolume)
        {
            _audioSource.volume = newVolume;
        }

    }
}
