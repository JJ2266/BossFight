using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Joshua
{
    public class Fireprojectile : MonoBehaviour
    {
        [SerializeField] GameObject projectile;
        [SerializeField] float spawnRate;
        float time;
        public
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            time += Time.deltaTime;
            if (time >= spawnRate)
            {
                time = 0;
                Shoot();
            }
        }
        void Shoot()
        {
            GameObject p = Instantiate(projectile, transform.position, Quaternion.identity);
            p.transform.forward = transform.forward;
        }
    }
}