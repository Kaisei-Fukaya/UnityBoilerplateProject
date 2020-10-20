using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaiseiBoilerplate
{
	public abstract class Singleton<T> where T : new()
	{
        static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                    Debug.Log("New Instance of: " + typeof(T) + " created.");
                    return _instance;
                }
                else
                {
                    Debug.Log("Instance of: " + typeof(T) + " exists.");
                    return _instance;
                }
            }
        }
	}

    public abstract class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviourSingleton<T>
    {
        private static T _instance;
        public static T Instance {
            get
            {
                if(_instance == null)
                {
                    throw new System.Exception("No instance of " + typeof(T).FullName + " exists!");
                }
                else
                {
                    return _instance;
                }
            }
            private set
            {
                _instance = value;
            }
        }

        protected virtual void Awake()
        {
            if (_instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
