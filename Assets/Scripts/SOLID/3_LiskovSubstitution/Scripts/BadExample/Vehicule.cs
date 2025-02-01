using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace DesignPatterns.BadPractice.LSP
{
    public class Vehicule : MonoBehaviour
    {
        public float speed = 100;
        public Vector3 direction;
        public void GoForward()
        {
            Debug.Log(" GoForward... ");
        }
        public void Reverse()
        {
            Debug.Log(" Reverse... ");
        }
        public void TurnRight()
        {
            Debug.Log(" Turn Right... ");
        }
        public void TurnLeft()
        {
            Debug.Log(" Turn Left... ");
        }
    }
}
