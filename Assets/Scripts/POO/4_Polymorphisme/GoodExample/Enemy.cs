using UnityEngine;

namespace BestPractice.OOP.Polymorphism
{
    public class Enemy : MonoBehaviour
    {
        public int Health { get; protected set; }
        public float MoveSpeed { get; protected set; }

        public Enemy(int health, float moveSpeed)
        {
            Health = health;
            MoveSpeed = moveSpeed;
        }

        public virtual void Move()
        {
            Debug.Log($"L'ennemi se déplace à la vitesse de {MoveSpeed}");
           
        }

        public virtual void Die()
        {
            Debug.Log("Enemy est mort !");
        }
    }
}
