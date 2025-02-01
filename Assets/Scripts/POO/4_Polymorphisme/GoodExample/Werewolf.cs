using UnityEngine;

namespace BestPractice.OOP.Polymorphism
{
    public class Werewolf : Enemy
    {
        public Werewolf(int health, float moveSpeed) : base(health, moveSpeed)
        {
        }

        public override void Move()
        {
            Debug.Log($"L'ennemi de type Loup-garou se déplace à la vitesse de {MoveSpeed}");
        }
        public override void Die()
        {
            Debug.Log("Enemy de type loup-garou est mort !");
        }
    }
}

