using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Joshua
{
    public class DamagingWave : MonoBehaviour
    {
        [SerializeField] GameObject Explosionparticles;
        // Start is called before the first frame update
        void Start()
        {
            var e = Instantiate(Explosionparticles, transform.position, Quaternion.identity);
            e.transform.localScale = new Vector3(3, 3, 3);
            Destroy(gameObject, 0.5f);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}