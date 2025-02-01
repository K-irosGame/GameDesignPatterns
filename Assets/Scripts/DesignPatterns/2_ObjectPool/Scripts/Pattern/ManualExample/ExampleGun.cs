/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectPool
{
    // Exemple de client qui utilise notre simple object pool.
    public class ExampleGun : MonoBehaviour
    {
        [Tooltip("Prefab à tirer")]
        [SerializeField] private GameObject projectile;
        [Tooltip("Force du projectile")]
        [SerializeField] float muzzleVelocity = 700f;
        [Tooltip("Extrémité du canon où les tirs apparaissent")]
        [SerializeField] private Transform muzzlePosition;
        [Tooltip("Temps entre les tirs / plus petit = cadence de tir plus élevée")]
        [SerializeField] float cooldownWindow = 0.1f;
        [Tooltip("Référence au Object Pool")]
        [SerializeField] ObjectPool objectPool;

        private float nextTimeToShoot;

        private void FixedUpdate()
        {
            // Tirer si le délai est dépassé
            if (Input.GetButton("Fire1") && Time.time > nextTimeToShoot && objectPool != null)
            {
                // Obtenir un objet du pool au lieu de l'instancier
                GameObject bulletObject = objectPool.GetPooledObject().gameObject;

                if (bulletObject == null)
                    return;

                bulletObject.SetActive(true);

                // Aligner sur le canon du pistolet / position de la bouche
                bulletObject.transform.SetPositionAndRotation(muzzlePosition.position, muzzlePosition.rotation);

                // Faire avancer le projectile
                bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * muzzleVelocity, ForceMode.Acceleration);

                // Désactiver après quelques secondes
                ExampleProjectile projectile = bulletObject.GetComponent<ExampleProjectile>();
                projectile?.Deactivate();

                // Définir le délai de rechargement
                nextTimeToShoot = Time.time + cooldownWindow;
            }
        }
    }
}
*/