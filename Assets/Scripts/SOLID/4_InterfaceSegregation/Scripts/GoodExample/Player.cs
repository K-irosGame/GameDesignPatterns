using UnityEngine;


namespace DesignPatterns.BestPractice.ISP
{
    public class Player : MonoBehaviour, IMovable, IPreparatory, ICooking, IServing
    {
        public void Chop()
        {
            // code here
        }

        public void Cook()
        {
            // code here
        }

        public void Mix()
        {
            // code here
        }

        public void MoveTo(Vector3 position)
        {
            // code here
        }

        public void Serve()
        {
            // code here
        }

        void Start()
        {
            
        }

        void Update()
        {
            
        }
    }
}
