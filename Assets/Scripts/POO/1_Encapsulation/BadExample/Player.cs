using UnityEngine;

namespace BadPractice.OOP.Encapsulation
{
    public class Player : MonoBehaviour
    {
        public int _playerHealth = 100;
         
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Debug.Log($"La sant� du joueur : {_playerHealth}");
        }
    }
}
