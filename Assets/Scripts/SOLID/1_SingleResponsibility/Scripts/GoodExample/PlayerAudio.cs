using UnityEngine;

namespace DesignPatterns.SRP
{
    /// <summary>
    /// Plays an example sound effect when colliding with a wall or obstacle.
    /// </summary>

    public class PlayerAudio : MonoBehaviour
    {
        [SerializeField]
        float _cooldownTime = 2f;
        [SerializeField]
        AudioClip[] _bounceClips;
        float _lastTimePlayed;
        AudioSource _audioSource;

        void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void Start()
        {
            _lastTimePlayed = -_cooldownTime;
        }

        public void PlayRandomClip()
        {
            // Calculate the time to play the next clip.            
            float timeToNextPlay = _cooldownTime + _lastTimePlayed;

            // Check if the cooldown time has passed.
            if (Time.time > timeToNextPlay)
            {
                _lastTimePlayed = Time.time;
                _audioSource.clip = GetRandomClip();
                _audioSource.Play();
            }
        }

        private AudioClip GetRandomClip()
        {
            // Get a random clip from the array based on the number of clips in it.
            int randomIndex = UnityEngine.Random.Range(0, _bounceClips.Length);
            return _bounceClips[randomIndex];
        }
    }
}
