using UnityEngine;

namespace DesignPatterns.SRP
{
    public class PlayerInput : MonoBehaviour
    {
        // Inspector fields
        [Header("Controls")]
        [Tooltip("Use WASD keys to move")]
        [SerializeField] private KeyCode _forwardKey = KeyCode.W;
        [SerializeField] private KeyCode _backwardKey = KeyCode.S;
        [SerializeField] private KeyCode _leftKey = KeyCode.A;
        [SerializeField] private KeyCode _rightKey = KeyCode.D;

        // Private members
        private Vector3 _inputVector;
        private float _xInput;
        private float _zInput;
        private float _yInput;

        // Properties
        public Vector3 InputVector => _inputVector;

        // MonoBehaviour methods
        private void Update()
        {
            HandleInput();
        }

        // Methods
        public void HandleInput()
        {

            // Reset input values to zero at the beginning of each frame
            _xInput = 0;
            _zInput = 0;

            if (Input.GetKey(_forwardKey))
            {
                _zInput++;
            }

            if (Input.GetKey(_backwardKey))
            {
                _zInput--;
            }

            if (Input.GetKey(_leftKey))
            {
                _xInput--;
            }

            if (Input.GetKey(_rightKey))
            {
                _xInput++;
            }

            _inputVector = new Vector3(_xInput, _yInput, _zInput);
        }
    }
}
