using UnityEngine;

namespace BestPractice.OOP.Coupling
{
    public class InputReader : MonoBehaviour
    {
        
        public Vector3 GetMovementInput()
        {
            float horizontalInput = Input.GetAxis("H");
            float verticalInput = Input.GetAxis("V");

            return new Vector3(horizontalInput, 0, verticalInput);
        }

        public bool IsJumping() => Input.GetKeyDown(KeyCode.Space);
        
    }
}
