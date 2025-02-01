using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Events;

namespace DesignPatterns.ObjectPool
{
    public class RevisedGun : MonoBehaviour
    {
        [Tooltip("Prefab du projectile � tirer")]
        [SerializeField] private RevisedProjectile projectilePrefab;
        [Tooltip("Force appliqu�e au projectile")]
        [SerializeField] private float muzzleVelocity = 1500f;
        [Tooltip("Position de la bouche du canon o� apparaissent les tirs")]
        [SerializeField] private Transform muzzlePosition;
        [Tooltip("Temps entre deux tirs (plus petit = cadence de tir plus �lev�e)")]
        [SerializeField] private float cooldownWindow = 0.1f;

        [SerializeField] private UnityEvent m_GunFired;

        // Pool d'objets bas� sur une pile, disponible avec Unity 2021 et versions ult�rieures
        private IObjectPool<RevisedProjectile> objectPool;

        // G�n�re une exception si on essaie de retourner un objet d�j� pr�sent dans le pool
        [SerializeField] private bool collectionCheck = true;

        // Options suppl�mentaires pour contr�ler la capacit� initiale et la taille maximale du pool
        [SerializeField] private int defaultCapacity = 20;
        [SerializeField] private int maxSize = 100;

        private float nextTimeToShoot;

        private void Awake()
        {
            objectPool = new ObjectPool<RevisedProjectile>(CreateProjectile,
                OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject,
                collectionCheck, defaultCapacity, maxSize);
        }

        // Invoqu� lors de la cr�ation d'un �l�ment pour remplir le pool d'objets
        private RevisedProjectile CreateProjectile()
        {
            RevisedProjectile projectileInstance = Instantiate(projectilePrefab);
            projectileInstance.ObjectPool = objectPool;
            return projectileInstance;
        }

        // Invoqu� lorsqu'un �l�ment est retourn� au pool d'objets
        private void OnReleaseToPool(RevisedProjectile pooledObject)
        {
            pooledObject.gameObject.SetActive(false);
        }

        // Invoqu� lorsqu'on r�cup�re le prochain �l�ment depuis le pool d'objets
        private void OnGetFromPool(RevisedProjectile pooledObject)
        {
            pooledObject.gameObject.SetActive(true);
        }

        // Invoqu� lorsqu'on d�passe le nombre maximum d'objets dans le pool (c'est-�-dire d�truire l'objet exc�dentaire)
        private void OnDestroyPooledObject(RevisedProjectile pooledObject)
        {
            Destroy(pooledObject.gameObject);
        }

        private void FixedUpdate()
        {
            // Tirer si le d�lai est d�pass�
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

            // D�sactiver le projectile apr�s quelques secondes
            bulletObject.Deactivate();

            // D�finir le d�lai de tir
            nextTimeToShoot = Time.time + cooldownWindow;

            m_GunFired.Invoke();
        }
    }
}
