using UnityEngine;


namespace DesignPatterns.BadPractice.ISP
{
    public class PanCounter : ICookingEntity
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
            Debug.Log("Heat logic ...");
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
    }
}
