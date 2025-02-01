

using UnityEngine;

namespace DesignPatterns.StatePattern
{
    public class IdleState : IState
    {
        private PlayerController _player;

        private float _deadZoneValue = 0.1f;
        public IdleState(PlayerController player) 
        {
            _player = player;
        }
        public void Enter()
        {
            // code d'initialisation
        }

        public void Exit()
        {
            // code 
        }

        public void Update()
        {
            if (!_player.IsGrounded)
                _player.StateMachine.TransitionTo(_player.StateMachine.JumpState);

            else if (Mathf.Abs(_player.CharController.velocity.x) > _deadZoneValue || Mathf.Abs(_player.CharController.velocity.z) > _deadZoneValue)
                _player.StateMachine.TransitionTo(_player.StateMachine.WalkState);
        }
    }
}
