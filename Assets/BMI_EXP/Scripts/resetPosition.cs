using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPosition : MonoBehaviour
{
    private GameObject Head;
    private Vector3 initial_position;
    public int trial_count = 0;

    // Start is called before the first frame update
    private void Start()
    {
        Head = GameObject.Find("Camera");
        initial_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current_position = transform.position;
        Debug.Log("transform.position.z: " + current_position.z);
        Debug.Log("counter: " + trial_count);
        if (current_position.z >= 12.5)
        {
            transform.position = initial_position;
            trial_count += 1;
        }
    }

    public int GetTrialCount()
    {
        return trial_count;
    }
}
