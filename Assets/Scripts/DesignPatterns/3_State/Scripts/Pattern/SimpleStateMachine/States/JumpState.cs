using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StatePattern
{
    public class JumpState : IState
    {
        private PlayerController _player;
        public JumpState(PlayerController player)
        {
            _player = player;
        }
        public void Enter()
        {
            // code 
        }

        public void Exit()
        {
            // code
        }

        public void Update()
        {
            if (_player.IsGrounded)
            {
                if (Mathf.Abs(_player.CharController.velocity.x) > 0.1f || Mathf.Abs(_player.CharController.velocity.z) > 0.1f)
                    _player.StateMachine.TransitionTo(_player.StateMachine.WalkState);
                else
                    _player.StateMachine.TransitionTo(_player.StateMachine.IdleState);
            }

        }
    }
}
