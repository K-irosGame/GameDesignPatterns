using UnityEngine;

namespace BestPractice.OOP.Encapsulation
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
            _player.Heal(20);
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
