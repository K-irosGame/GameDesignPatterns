using UnityEngine;

namespace DesignPatterns.StatePattern
{
    // Simple FPS Controller (logique issue de FPS Starter)
    [RequireComponent(typeof(CharacterController))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private bool isGrounded = true;

        private StateMachine _stateMachine;
        public CharacterController CharController => charController;
        public bool IsGrounded => isGrounded;
        private CharacterController charController;

        public StateMachine StateMachine => _stateMachine;

        private void Awake()
        {
            charController = GetComponent<CharacterController>();
            _stateMachine = new StateMachine(this);
        }

        private void Start()
        {
            _stateMachine.Initialize(_stateMachine.IdleState);
        }

        private void Update()
        {
            _stateMachine.Update();
        }

        private void LateUpdate()
        {
            Move();
        }

        private void Move()
        {
            // Inserez la logique

        }

    }
}
