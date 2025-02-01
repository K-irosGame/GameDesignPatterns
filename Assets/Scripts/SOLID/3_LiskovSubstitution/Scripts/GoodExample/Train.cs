using UnityEngine;


namespace DesignPatterns.BestPractice.LSP
{
    public class Train : RailVehicule
    {
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
        }
    }
}
