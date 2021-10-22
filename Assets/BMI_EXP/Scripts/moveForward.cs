using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    float MoveSpeed = 0.05f;
    private GameObject Head;
    
    // Start is called before the first frame update
    private void Start()
    {
        Head = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 next_position = transform.position;
        if (Input.GetKey("w"))
        {
            next_position += Head.transform.forward * MoveSpeed;
            Vector3 binding_y = next_position;
            binding_y.y = next_position.y;
            transform.position = binding_y;
        }
        if (Input.GetKey("s"))
        {
            next_position -= Head.transform.forward * MoveSpeed;
            Vector3 binding_y = next_position;
            binding_y.y = next_position.y;
            transform.position = binding_y;
        }
    }
}   