using UnityEngine;

namespace BadPractice.OOP.Coupling
{
    public class Player : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }

        void Jump()
        {
            Debug.Log("Player jumps!");
        }

    }
}
