using UnityEngine;



namespace DesignPatterns.OCP
{
    public class Bow : Weapon
    {
        public override int CalculateDamage()
        {
            return 5;
        }

    }
}
