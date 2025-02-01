using UnityEngine;



namespace DesignPatterns.OCP
{
    public abstract class Weapon : MonoBehaviour
    {
        public abstract int CalculateDamage();
    }
}
