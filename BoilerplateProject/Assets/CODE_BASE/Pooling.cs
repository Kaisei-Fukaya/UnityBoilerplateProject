using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KaiseiBoilerplate
{
    public class Pool<T> : List<T> where T : PoolItem
    {
        public int MaxCount { get; protected set; }
        public bool IsFull { get; protected set; }

        public Pool(int maxCount)
        {
            MaxCount = maxCount;
        }

        public T FindAvailable(GameObject _prefabToInstantiate)
        {
            IsFull = (Count == MaxCount);

            //Return existing item
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Available)
                {
                    return this[i];
                }
            }
            //Return new item
            if (Count < MaxCount)
            {
                GameObject gObject = GameObject.Instantiate(_prefabToInstantiate);
                T comp;
                gObject.TryGetComponent(out comp);
                if(comp == null)
                {
                    gObject.AddComponent<T>();
                }
                Add(comp);
                return comp;
            }
            //None available and no more slots= return null
            return null;
        }
	}

    public abstract class PoolItem : MonoBehaviour
    {
        public bool Available { get; protected set; } = true;
        public virtual void Engage() => Available = false;
        public virtual void Done() => Available = true;
    }

    public class PoolTestItem : PoolItem
    {

    }
}
