using UnityEngine;


namespace DesignPatterns.BestPractice.LSP
{
    public class RoadVehicule : MonoBehaviour, IMovable, ITurnable
    {
        public void GoForward()
        {
            //Logic Here
        }

        public void Reverse()
        {
            //Logic Here
        }

        public void TurnLeft()
        {
            //Logic Here
        }

        public void TurnRight()
        {
            //Logic Here
        }

    }
}
