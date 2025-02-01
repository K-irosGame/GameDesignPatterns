using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Events;

namespace DesignPatterns.ObjectPool
{
    public class RevisedGun : MonoBehaviour
    {
        [Tooltip("Prefab du projectile à tirer")]
        [SerializeField] private RevisedProjectile projectilePrefab;
        [Tooltip("Force appliquée au projectile")]
        [SerializeField] private float muzzleVelocity = 1500f;
        [Tooltip("Position de la bouche du canon où apparaissent les tirs")]
        [SerializeField] private Transform muzzlePosition;
        [Tooltip("Temps entre deux tirs (plus petit = cadence de tir plus élevée)")]
        [SerializeField] private float cooldownWindow = 0.1f;

        [SerializeField] private UnityEvent m_GunFired;

        // Pool d'objets basé sur une pile, disponible avec Unity 2021 et versions ultérieures
        private IObjectPool<RevisedProjectile> objectPool;

        // Génère une exception si on essaie de retourner un objet déjà présent dans le pool
        [SerializeField] private bool collectionCheck = true;

        // Options supplémentaires pour contrôler la capacité initiale et la taille maximale du pool
        [SerializeField] private int defaultCapacity = 20;
        [SerializeField] private int maxSize = 100;

        private float nextTimeToShoot;

        private void Awake()
        {
            objectPool = new ObjectPool<RevisedProjectile>(CreateProjectile,
                OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject,
                collectionCheck, defaultCapacity, maxSize);
        }

        // Invoqué lors de la création d'un élément pour remplir le pool d'objets
        private RevisedProjectile CreateProjectile()
        {
            RevisedProjectile projectileInstance = Instantiate(projectilePrefab);
            projectileInstance.ObjectPool = objectPool;
            return projectileInstance;
        }

        // Invoqué lorsqu'un élément est retourné au pool d'objets
        private void OnReleaseToPool(RevisedProjectile pooledObject)
        {
            pooledObject.gameObject.SetActive(false);
        }

        // Invoqué lorsqu'on récupère le prochain élément depuis le pool d'objets
        private void OnGetFromPool(RevisedProjectile pooledObject)
        {
            pooledObject.gameObject.SetActive(true);
        }

        // Invoqué lorsqu'on dépasse le nombre maximum d'objets dans le pool (c'est-à-dire détruire l'objet excédentaire)
        private void OnDestroyPooledObject(RevisedProjectile pooledObject)
        {
            Destroy(pooledObject.gameObject);
        }

        private void FixedUpdate()
        {
            // Tirer si le délai est dépassé
            if (Input.GetButton("Fire1") && Time.time > nextTimeToShoot && objectPool != null)
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            // Obtenir un objet depuis le pool au lieu d'en instancier un nouveau
            RevisedProjectile bulletObject = objectPool.Get();

            if (bulletObject == null)
                return;

            // Aligner sur la position et la rotation de la bouche du canon
            bulletObject.transform.SetPositionAndRotation(muzzlePosition.position, muzzlePosition.rotation);

            // Faire avancer le projectile
            bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.forward * muzzleVelocity, ForceMode.Acceleration);

            // Désactiver le projectile après quelques secondes
            bulletObject.Deactivate();

            // Définir le délai de tir
            nextTimeToShoot = Time.time + cooldownWindow;

            m_GunFired.Invoke();
        }
    }
}
