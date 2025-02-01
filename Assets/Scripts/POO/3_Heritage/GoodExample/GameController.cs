using UnityEngine;

namespace BestPractice.OOP.Inheritance
{
    public class GameController : MonoBehaviour
    {
        private Zombie _zombie;
        private Werewolf _werewolf;


        private void Start()
        {
            _zombie = GetComponent<Zombie>();
            _werewolf  = GetComponent<Werewolf>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                _zombie.Move();
                _werewolf.Move();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                _zombie.Die();
                _werewolf.Die();
            }
        }
    }
}
