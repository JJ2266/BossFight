using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Joshua
{
    public class SpawnProjectiles : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] GameObject projectile;
        [SerializeField] float spawnRate;
        [SerializeField] int maxAngle = 180;
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
            p.transform.rotation = Quaternion.Euler(0, Random.Range(0, maxAngle), 0);
        }

    }
}