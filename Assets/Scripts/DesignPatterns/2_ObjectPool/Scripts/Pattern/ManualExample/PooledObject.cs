using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    public class PooledObject : MonoBehaviour
    {
        private IObjectPool<PooledObject> _pool;

        public IObjectPool<PooledObject> Pool
        {
            get => _pool;
            set => _pool = value;
        }
        
        public void Release()
        {
            _pool.Release(this);
        }
    }
}
