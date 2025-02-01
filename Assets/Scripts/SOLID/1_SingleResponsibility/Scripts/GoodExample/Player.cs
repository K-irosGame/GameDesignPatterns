using UnityEngine;
using DesignPatterns.Utilities;

namespace DesignPatterns.SRP
{
    [RequireComponent(typeof(PlayerInput), typeof(PlayerAudio), typeof(PlayerMovement))]
    public class Player : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("LayerMask to identify obstacles in the game environment.")]
        LayerMask _obstacleLayer;

        // Components for handling different aspects of player functionality.
        PlayerInput _playerInput;
        PlayerMovement _playerMovement;
        PlayerAudio _playerAudio;
        PlayerFX _playerFX;

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            _playerInput = GetComponent<PlayerInput>();
            _playerMovement = GetComponent<PlayerMovement>();
            _playerAudio = GetComponent<PlayerAudio>();
            _playerFX = GetComponent<PlayerFX>();
        }

        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if (_obstacleLayer.ContainsLayer(hit.gameObject))
            {

                _playerAudio.PlayRandomClip();


                if (_playerFX != null)
                    _playerFX.PlayEffect();

            }
        }

        private void LateUpdate()
        {
            Vector3 inputVector = _playerInput.InputVector;


            _playerMovement.Move(inputVector);
        }
    }
}
