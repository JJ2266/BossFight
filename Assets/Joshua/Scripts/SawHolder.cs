using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Joshua
{
    public class SawHolder : MonoBehaviour
    {
        [SerializeField] Transform target;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, .012f);
            transform.LookAt(target.transform.position);
        }
    }
}