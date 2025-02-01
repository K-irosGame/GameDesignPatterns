using UnityEngine;

namespace BestPractice.OOP.Inheritance
{
    public class Zombie : Enemy
    {
        public Zombie(int health, float moveSpeed) : base(health, moveSpeed)
        {
        }
    }

}
