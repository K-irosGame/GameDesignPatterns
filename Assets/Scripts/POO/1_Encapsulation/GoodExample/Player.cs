using UnityEngine;

namespace BestPractice.OOP.Encapsulation
{
    public class Player : MonoBehaviour
    {
        private int _playerHealth = 100;
        private int _playerHealthMax = 150;
        public int PlayerHealth => _playerHealth;


        public void TakeDamage(int damage)
        {
            if (damage <= 0) return;
            _playerHealth -= damage;

            _playerHealth = Mathf.Max(_playerHealth, 0);
            Debug.Log($"Enemy Attack damage {damage}");
        }

        public void Heal(int amount)
        {
            if (amount <= 0) return;
            _playerHealth += amount;

            _playerHealth = Mathf.Min(_playerHealth, _playerHealthMax);
            Debug.Log($"Heal Bonus amount {amount}");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Debug.Log($"La santé du joueur : {_playerHealth}");
        }
    }
}
