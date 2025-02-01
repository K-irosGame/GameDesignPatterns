using UnityEngine;


namespace DesignPatterns.BadPractice.DIP
{
    public class Switch : MonoBehaviour
    {
        public Door door;
        public Trap trap;
        public bool isActivated;
        public void Toggle()
        {
            if (isActivated)
            {
                isActivated = false;
                door.Close();
                trap.Close();
            }
            else
            {
                isActivated = true;
                door.Open();
                trap.Open();
            }
        }
    }

    public class Trap
    {
        public void Open()
        {
            Debug.Log("The Trap is open.");
        }
        public void Close()
        {
            Debug.Log("The Trap is closed.");
        }
    }
}
