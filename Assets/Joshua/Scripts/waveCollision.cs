using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Joshua
{
    public class waveCollision : MonoBehaviour
    {
        [SerializeField] GameObject parent;
        MeshCollider meshCollider;
        // Start is called before the first frame update
        void Start()
        {
            meshCollider = GetComponent<MeshCollider>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerStay(Collider other)
        {
            if (other.GetComponent<Damageable>())
            {
                meshCollider.enabled = false;
            }
        }

    }
}