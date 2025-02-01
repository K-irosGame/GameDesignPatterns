using UnityEngine;



namespace DesignPatterns.OCP
{
    public class Sword : Weapon
    {
        public override int CalculateDamage()
        {
            return 15;
        }
    }
}
