using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class SimpleSingleton : MonoBehaviour
    {
        public static SimpleSingleton Instance;
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}  
