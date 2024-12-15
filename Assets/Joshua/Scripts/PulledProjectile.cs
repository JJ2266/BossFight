using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Joshua
{
    public class PulledProjectile : MonoBehaviour
    {
        Transform target;
        [SerializeField] float speed;
        Rigidbody rigidBody;
        // Start is called before the first frame update
        void Start()
        {
            target = FindObjectOfType<BlackHole>().GetComponent<Transform>();
            rigidBody = GetComponent<Rigidbody>();
            rigidBody.velocity = transform.forward * speed;
            StartCoroutine(GoToTarget());
        }

        public void DestroyProjectile()
        {
            Destroy(gameObject);
        }

        IEnumerator GoToTarget()
        {
            yield return new WaitForSeconds(1);
            if (target != null)
            {
                rigidBody.velocity = (target.position - transform.position).normalized * speed;
            }

        }
    }
}