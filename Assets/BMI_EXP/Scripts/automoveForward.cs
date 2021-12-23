using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automoveForward : MonoBehaviour
{
    private Vector3 pos;
    private int flag = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("moveForward");
    }

    IEnumerator moveForward()
    {
        if(flag == 1)
        {
            while (pos.z < 12.5f)
            {
                pos = transform.position;
                transform.Translate(0, 0, 0.08f);
                yield return new WaitForSeconds(0.01f);
            }
        }

    }
}
