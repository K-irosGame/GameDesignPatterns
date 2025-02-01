using UnityEngine;

namespace BestPractice.OOP.Polymorphism
{
    public class Zombie : Enemy
    {
        public Zombie(int health, float moveSpeed) : base(health, moveSpeed)
        {

        }

        public override void Move()
        {
            Debug.Log($"L'ennemi de type Zombie se déplace à la vitesse de {MoveSpeed}");
        }
        public override void Die()
        {
            Debug.Log("Enemy de type zombie est mort !");
        }
    }

}
