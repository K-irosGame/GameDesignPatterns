using UnityEngine;

namespace BestPractice.OOP.Coupling
{
    public class Player : MonoBehaviour
    {
        private InputReader _inputReader;

        private void Start()
        {
            _inputReader = GetComponent<InputReader>();
        }
        void Update()
        {
            Vector3 movementDirection = _inputReader.GetMovementInput();
            
                transform.Translate(movementDirection * Time.deltaTime);

            if (_inputReader.IsJumping())
            {
                Jump();
            }
        }

        void Jump()
        {
            Debug.Log("Player jumps!");
        }
    }
}
