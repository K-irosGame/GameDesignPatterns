using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    // Projectile r�vis� pour utiliser UnityEngine.Pool dans Unity 2021
    public class RevisedProjectile : MonoBehaviour
    {
        // D�sactivation apr�s un d�lai
        [SerializeField] private float timeoutDelay = 3f;

        private IObjectPool<RevisedProjectile> objectPool;

        // Propri�t� publique pour donner au projectile une r�f�rence � son ObjectPool
        public IObjectPool<RevisedProjectile> ObjectPool { set => objectPool = value; }

        public void Deactivate()
        {
            StartCoroutine(DeactivateRoutine(timeoutDelay));
        }

        IEnumerator DeactivateRoutine(float delay)
        {
            yield return new WaitForSeconds(delay);

            // R�initialise le Rigidbody en mouvement
            Rigidbody rBody = GetComponent<Rigidbody>();
            rBody.linearVelocity = new Vector3(0f, 0f, 0f);
            rBody.angularVelocity = new Vector3(0f, 0f, 0f);

            // Lib�re le projectile pour le retourner au pool
            objectPool.Release(this);
        }
    }
}
