using UnityEngine;

namespace BadPractice.OOP.Composition
{
    public class Player : MonoBehaviour
    {
        public void Move()
        {
            Debug.Log("Moving...");
        }

        public void Jump()
        {
            Debug.Log("Jumping...");
        }

        public void Shoot()
        {
            Debug.Log("Shooting...");
        }
    }
}
