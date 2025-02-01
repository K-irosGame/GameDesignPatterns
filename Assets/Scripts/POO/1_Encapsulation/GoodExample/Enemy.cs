using UnityEngine;

namespace BestPractice.OOP.Encapsulation
{
    public class Enemy : MonoBehaviour
    {
        private Player _player;

        void Awake()
        {
            _player = FindFirstObjectByType<Player>();
        }

        private void SetAttack()
        {
            _player.TakeDamage(50);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                SetAttack();
            }
        }
    }
}
