using UnityEngine;

namespace BestPractice.OOP.Abstraction
{
    public class PlayerController : MonoBehaviour
    {
        private SoundManager _soundManager;
        private AudioClip _jumpSound;
        private AudioClip _damageSound;

        void Awake()
        {
            _soundManager = FindFirstObjectByType<SoundManager>();
        }

        private void Jump()
        {
            _soundManager.PlaySound(_jumpSound);
        }

        private void TakeDamage()
        {
            _soundManager.PlaySound(_damageSound, 0.5f);
        }
    }
}

