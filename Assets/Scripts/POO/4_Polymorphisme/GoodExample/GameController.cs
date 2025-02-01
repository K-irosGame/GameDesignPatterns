using UnityEngine;

namespace BestPractice.OOP.Polymorphism
{
    public class GameController : MonoBehaviour
    {
        Zombie _zombie;
        Werewolf _werewolf;

        Enemy[] _enemies;

        private void Start()
        {
            _zombie = gameObject.AddComponent<Zombie>();
            _werewolf = gameObject.AddComponent<Werewolf>();

            _enemies = new Enemy[] { _zombie, _werewolf };
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (Enemy enemy in _enemies)
                    enemy.Move();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                foreach (Enemy enemy in _enemies)
                    enemy.Die();
            }
        }
    }
}
