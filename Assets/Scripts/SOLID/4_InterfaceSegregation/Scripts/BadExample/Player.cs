using UnityEngine;


namespace DesignPatterns.BadPractice.ISP
{
    public class Player : MonoBehaviour, ICookingEntity
    {
        public void Chop()
        {
            // Code Logic here
        }

        public void Cook()
        {
            // Code Logic here
        }

        public void Heat()
        {
            // Code Logic here
        }

        public void Move()
        {
            // Code Logic here
        }

        public void Serve()
        {
            // Code Logic here
        }

        public void Wash()
        {
            // Code Logic here
        }

        void Start()
        {
            
        }

        void Update()
        {
            
        }
    }
}
