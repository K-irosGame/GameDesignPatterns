using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace DesignPatterns.BadPractice.LSP
{
    public class Truck : Vehicule
    {

        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                GoForward();
            }

            if (Input.GetKey(KeyCode.S))
            {
                Reverse();
            }

            if (Input.GetKey(KeyCode.A))
            {
                TurnLeft();
            }

            if (Input.GetKey(KeyCode.D))
            {
                TurnRight();
            }
        }
    }
}
