using UnityEngine;


namespace DesignPatterns.BadPractice.DIP
{
    public class Door : MonoBehaviour
    {
        public void Open()
        {
            Debug.Log("The door is open.");
        }
        public void Close()
        {
            Debug.Log("The door is closed.");
        }
    }
}
