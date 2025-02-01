using UnityEngine;


namespace DesignPatterns.BestPractice.DIP
{
    public class Door : MonoBehaviour, ISwitchable
    {
        private bool _isActivate;
        public bool IsActivate => _isActivate;

        public void Activate()
        {
            _isActivate = true;
            Debug.Log("The door is open.");
        }

        public void Desactivate()
        {
            _isActivate = false;
            Debug.Log("The door is closed.");
        }
    }
}
