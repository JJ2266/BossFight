using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Joshua
{
    public class Saw : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var rotationsPerMinute = 50.0f;

            transform.Rotate(0, 0, (float)(6.0 * -rotationsPerMinute * Time.deltaTime));

        }

    }
}