using UnityEngine;


namespace DesignPatterns.BestPractice.LSP
{
    public class Car : RoadVehicule
    {

        void Start()
        {
            
        }


        void Update()
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
