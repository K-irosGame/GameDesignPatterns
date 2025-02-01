using UnityEngine;



namespace DesignPatterns.OCP
{
    public class DamageCalculator : MonoBehaviour
    {
        public int CalculateDamage(string weaponType)
        {
            if (weaponType == "Sword")
            {
                return 10;
            }
            else if (weaponType == "Bow")
            {
                return 5;
            }

            return 0;
        }
    }
}
