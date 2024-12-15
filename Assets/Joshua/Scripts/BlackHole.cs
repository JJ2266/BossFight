using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Joshua
{
    public class BlackHole : MonoBehaviour
    {
        [SerializeField] GameObject particle;
        public UnityEvent OnSpawn;
        // Start is called before the first frame update
        void Start()
        {
            OnSpawn.Invoke();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Destroy()
        {
            var g = Instantiate(particle, transform.position, Quaternion.identity);
            g.transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);
            gameObject.SetActive(false);
        }
    }
}

