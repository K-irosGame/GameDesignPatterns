using UnityEngine;

namespace BadPractice.OOP.Encapsulation
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
            _player._playerHealth = - 100;
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
