using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StatePattern
{
    public class StateMachine
    {
        public IState CurrentState
        {
            get;
            private set;
        }

        public StateMachine(PlayerController player)
        {
            IdleState = new IdleState(player);
            JumpState = new JumpState(player);
            WalkState = new WalkState(player);
        }

        public IdleState IdleState;
        public JumpState JumpState;
        public WalkState WalkState;


        public void Initialize(IState state)
        {
            CurrentState = state;
            state.Enter();
        }

        public void Update()
        {
            if (CurrentState != null)
            {
                CurrentState.Update();
            }
        }

        public void TransitionTo(IState nextState)
        {
            CurrentState.Exit();
            CurrentState = nextState;
            nextState.Enter();
        }
    }
}
