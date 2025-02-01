using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;


namespace DesignPatterns.ObjectPool
{
    public class ObjectPool : MonoBehaviour
    {

        [SerializeField] PooledObject _objectToPool;

        [SerializeField]  private int _maxSizePool = 100;
        [SerializeField]  private int _defaultSizePool = 20;
        [SerializeField]  private bool _collectionCheck = true;

        IObjectPool<PooledObject> _objectPool;

        private void Awake()
        {
            _objectPool = new ObjectPool<PooledObject>
                (
                    SetupPool, 
                    GetPooledObject, 
                    ReturnToPool,
                    DestroyFromPool,
                    _collectionCheck,
                    _defaultSizePool,
                    _maxSizePool
                );
        }

        private PooledObject SetupPool()
        {
            PooledObject instance = Instantiate(_objectToPool);
            instance.Pool = _objectPool;
            return instance;
        }

        private void GetPooledObject(PooledObject pooledObject)
        {
            pooledObject.gameObject.SetActive(true);
        }

        private void ReturnToPool(PooledObject pooledObject)
        {
            pooledObject.gameObject.SetActive(false );
        }

        private void DestroyFromPool(PooledObject pooledObject)
        {
            Destroy(pooledObject.gameObject);
        }
    }
}
