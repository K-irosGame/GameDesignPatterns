using UnityEngine;


namespace DesignPatterns.BestPractice.DIP
{
    public class Switch : MonoBehaviour
    {
        [SerializeField] private ISwitchable _client;
        public void Toggle()
        {
            if (_client.IsActivate)
                _client.Desactivate();
            else
                _client.Activate();
        }
    }
}
