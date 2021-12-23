using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automoveForward : MonoBehaviour
{
    float MoveSpeed = 0.05f;
    private int _cameraHeight = 3;
    private GameObject Head;
    private GameObject Goal;

    // Start is called before the first frame update
    void Start()
    {
        Head = GameObject.Find("Camera");
        Goal = GameObject.Find("Goal");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 next_position = transform.position;

        if (Input.GetKey("w"))
        {
            Vector3 current_z = Head.transform.position;
            while (current_z.z <= 12.5f)
            {
                next_position += Head.transform.forward * MoveSpeed;
                Vector3 binding_y = next_position;
                binding_y.y = _cameraHeight;
                transform.position = binding_y;
            }
        }
        if (Input.GetKey("s"))
        {
            next_position -= Head.transform.forward * MoveSpeed;
            Vector3 binding_y = next_position;
            binding_y.y = _cameraHeight;
            transform.position = binding_y;
        }
    }
}
