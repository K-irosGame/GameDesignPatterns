using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace DesignPatterns.BadPractice.LSP
{
    public class Train : Vehicule
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
            
        }
    }
}
