using UnityEngine;

namespace BadPractice.OOP.Encapsulation
{
    public class Bonus : MonoBehaviour
    {
        private Player _player;

        void Awake()
        {
            _player = FindFirstObjectByType<Player>();
        }

        private void Heal()
        {
            _player._playerHealth = 19999999;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Heal();
            }
        }
    }
}
