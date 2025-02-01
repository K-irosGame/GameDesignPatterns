using UnityEngine;

namespace BestPractice.OOP.Composition
{
    public class Player : MonoBehaviour
    {
        private Movement _movement ;
        private Jumping _jumping ;
        private Shooting _shooting;

        private void Start()
        {
            _movement = GetComponent<Movement>();
            _jumping = GetComponent<Jumping>();
            _shooting = GetComponent<Shooting>();
        }

        private void Update()
        {
            _movement.Move();
            _jumping.Jump();
            _shooting.Shoot();
        }
    }
}
