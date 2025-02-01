/*using System.Collections;
using UnityEngine;

namespace DesignPatterns.ObjectPool
{
    // Un projectile utilis� comme �l�ment du pool d'objets.
    [RequireComponent(typeof(PooledObject))]
    public class ExampleProjectile : MonoBehaviour
    {
        // D�sactiver apr�s un d�lai
        [SerializeField] private float timeoutDelay = 3f;

        // R�f�rence au composant PooledObject pour pouvoir le retourner au pool
        private PooledObject pooledObject;

        private void Awake()
        {
            pooledObject = GetComponent<PooledObject>();
        }

        public void Deactivate()
        {
            StartCoroutine(DeactivateRoutine(timeoutDelay));
        }

        IEnumerator DeactivateRoutine(float delay)
        {
            yield return new WaitForSeconds(delay);

            // R�initialiser le Rigidbody en mouvement
            Rigidbody rBody = GetComponent<Rigidbody>();
            rBody.linearVelocity = new Vector3(0f, 0f, 0f);
            rBody.angularVelocity = new Vector3(0f, 0f, 0f);

            // D�sactiver l'objet et le retourner au pool
            pooledObject.Release();
            gameObject.SetActive(false);
        }
    }
}
*/