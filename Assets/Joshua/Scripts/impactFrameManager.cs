using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Joshua
{
    public class impactFrameManager : MonoBehaviour
    {

        [SerializeField] GameObject manager;
        public UnityEvent Activate;
        public UnityEvent Dectivate;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Startframe()
        {
            StartCoroutine(activate());
        }
        IEnumerator activate()
        {
            Activate.Invoke();
            yield return new WaitForSeconds(0.1f);
            Dectivate.Invoke();
        }
    }
}