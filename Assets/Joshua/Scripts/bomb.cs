using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Joshua
{
    public class bomb : MonoBehaviour
    {
        [SerializeField] GameObject spawnPoint;
        [SerializeField] GameObject DamageWave;
        GameManager gameManager;
        // Start is called before the first frame update
        void Start()
        {
            gameManager = FindObjectOfType<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            Instantiate(DamageWave, spawnPoint.transform.position, Quaternion.identity);

            Destroy(gameObject);
            gameManager.ActivateCameraShake();
        }
    }
}

