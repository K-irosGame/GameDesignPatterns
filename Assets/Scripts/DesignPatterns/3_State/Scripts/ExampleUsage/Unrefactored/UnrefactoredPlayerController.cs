using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StatePattern
{
    public enum PlayerControllerState
    {
        Idle,
        Walk,
        Jump
    }

    public class UnrefactoredPlayerController : MonoBehaviour
    {
        private PlayerControllerState state;

        private void Update()
        {
            GetInput();
            switch(state)
            {
                case PlayerControllerState.Idle:
                    Idle();
                    break;
                case PlayerControllerState.Walk:
                    Walk();
                    break;
                case PlayerControllerState.Jump:
                    Jump();
                    break;
            }
            
        }

        private void GetInput()
        {
            // Traiter les commandes de marche et de saut
        }

        private void Walk()
        {
            // Logique pour marcher
        }

        private void Idle()
        {
            // Logique pour rester immobile
        }

        private void Jump()
        {
            // Logique pour sauter
        }
    }
}
