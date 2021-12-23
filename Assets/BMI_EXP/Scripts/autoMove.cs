using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoMove : MonoBehaviour
{
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos = transform.position;
        if (Input.GetKey("w"))
        {
            if (pos.z < 12.5f)
            {
                pos = transform.position;
                transform.Translate(0, 0, 0.08f);
            }
        }
    }
}
