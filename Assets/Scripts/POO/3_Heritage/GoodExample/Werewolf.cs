using UnityEngine;

namespace BestPractice.OOP.Inheritance
{
    public class Werewolf : Enemy
    {
        public Werewolf(int health, float moveSpeed) : base(health, moveSpeed)
        {
        }
    }
}

