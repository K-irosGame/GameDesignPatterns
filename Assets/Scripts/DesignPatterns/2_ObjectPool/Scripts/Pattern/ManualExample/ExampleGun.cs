/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectPool
{
    // Exemple de client qui utilise notre simple object pool.
    public class ExampleGun : MonoBehaviour
    {
        [Tooltip("Prefab � tirer")]
        [SerializeField] private GameObject projectile;
        [Tooltip("Force du projectile")]
        [SerializeField] float muzzleVelocity = 700f;
        [Tooltip("Extr�mit� du canon o� les tirs apparaissent")]
        [SerializeField] private Transform muzzlePosition;
        [Tooltip("Temps entre les tirs / plus petit = cadence de tir plus �lev�e")]
        [SerializeField] float cooldownWindow = 0.1f;
        [Tooltip("R�f�rence au Object Pool")]
        [SerializeField] ObjectPool objectPool;

        private float nextTimeToShoot;

        private void FixedUpdate()
        {
            // Tirer si le d�lai est d�pass�
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

                // D�sactiver apr�s quelques secondes
                ExampleProjectile projectile = bulletObject.GetComponent<ExampleProjectile>();
                projectile?.Deactivate();

                // D�finir le d�lai de rechargement
                nextTimeToShoot = Time.time + cooldownWindow;
            }
        }
    }
}
*/