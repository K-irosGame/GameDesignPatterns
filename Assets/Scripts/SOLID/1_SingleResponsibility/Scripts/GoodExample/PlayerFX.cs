using UnityEngine;

namespace DesignPatterns.SRP
{
    public class PlayerFX : MonoBehaviour
    {
        [SerializeField]
        ParticleSystem _particleSystem;

        // Cooldown time between particle system plays.
        const float _cooldown = 1f;

        float _timeToNextPlay = -1f;

        public void PlayEffect()
        {
            // Check if the cooldown time has passed.
            if (Time.time < _timeToNextPlay)
                return;

            // Play the particle system effect if it is not null.
            if (_particleSystem != null)
            {
                // Stop the particle system before playing it again to avoid overlapping effects.
                _particleSystem.Stop();
                _particleSystem.Play();

                _timeToNextPlay = Time.time + _cooldown;
            }
        }

    }
}
