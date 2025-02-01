using UnityEngine;


namespace DesignPatterns.BestPractice.DIP
{
    public class Trap : MonoBehaviour, ISwitchable
    {
        private bool _isActivate;
        public bool IsActivate => _isActivate;

        public void Activate()
        {
            _isActivate = true;
            Debug.Log("The trap is open.");
        }

        public void Desactivate()
        {
            _isActivate = false;
            Debug.Log("The trap is closed.");
        }
    }
}
