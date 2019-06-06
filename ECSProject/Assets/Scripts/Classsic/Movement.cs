using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment.Movement
{
    public class Movement : MonoBehaviour
    {
        // Update is called once per frame
        void Update ()
        {
            Vector3 pos = transform.position;
            pos += transform.up * Time.deltaTime;

            if (pos.y > 10)
            {
                pos.y = -10;
            }
            transform.position = pos;
        }
    }
}
