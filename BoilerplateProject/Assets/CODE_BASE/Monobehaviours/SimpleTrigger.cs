using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace KaiseiBoilerplate
{
    [RequireComponent(typeof(Collider))]
	public class SimpleTrigger : MonoBehaviour
	{
        [SerializeField] UnityEvent events;

        //Works with either trigger or non trigger colliders

        private void OnCollisionEnter(Collision collision)
        {
            events.Invoke();
        }

        private void OnTriggerEnter(Collider other)
        {
            events.Invoke();
        }
    }
}
