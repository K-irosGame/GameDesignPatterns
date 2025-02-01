using UnityEngine;

namespace BadPractice.OOP.Inheritance
{
    public class Werewolf : MonoBehaviour
    {
        public int health;
        public float moveSpeed;


        public void Move()
        {
            Debug.Log($"L'ennemi se déplace à la vitesse de : {moveSpeed}");
        }

        public void Die()
        {
            Debug.Log("L'ennemi est mort !");
        }
    }
}

