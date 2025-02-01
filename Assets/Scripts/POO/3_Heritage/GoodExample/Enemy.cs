using UnityEngine;

namespace BestPractice.OOP.Inheritance
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

        public void Move()
        {
            Debug.Log($"L'ennemi se déplace à la vitesse de : {MoveSpeed}");
        }

        public void Die()
        {
            Debug.Log("L'ennemi est mort !");
        }
    }
}
