using UnityEngine;
using UnityEngine.SceneManagement;

namespace DesignPatterns.Singleton
{
   
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T _localInstance;
        public static T Instance
        {
            get
            {
                if (_localInstance == null )
                {
                    _localInstance = (T) FindAnyObjectByType<T>();

                    if (_localInstance == null)
                    {
                        SetupInstance();
                    }
                }
                return _localInstance;
            }
        }

        public virtual void Awake()
        {
            if (_localInstance == null)
            {
                _localInstance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);
        }

        private static void SetupInstance()
        {
            _localInstance = FindAnyObjectByType<T>();
            
            if ( _localInstance == null )
            {
                GameObject gameObject = new GameObject();
                gameObject.name = typeof(T).Name;

                _localInstance = gameObject.AddComponent<T>();

                DontDestroyOnLoad(gameObject);
            }
            
        }

    }
}
