using UnityEngine;

namespace DesignPatterns.StatePattern
{
    public class WalkState : IState
    {
        private PlayerController _player;
        public WalkState(PlayerController player)
        {
            _player = player;
        }
        public void Enter()
        {
            
        }

        public void Exit()
        {
            
        }

        public void Update()
        {
            if (!_player.IsGrounded)
                _player.StateMachine.TransitionTo(_player.StateMachine.JumpState);

            else if (_player.IsGrounded && Mathf.Abs(_player.CharController.velocity.x) < 0.1f || Mathf.Abs(_player.CharController.velocity.z) < 0.1f)
                _player.StateMachine.TransitionTo(_player.StateMachine.IdleState);
        }
    }
}
