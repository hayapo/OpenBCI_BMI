using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitExperiment : MonoBehaviour
{
    GameObject CameraRig;
    resetPosition reset_position;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CameraRig = GameObject.Find("[CameraRig]");
        reset_position = CameraRig.GetComponent<resetPosition>();
        count = reset_position.trial_count;
        if (count == 5)
        {
            Debug.Log("Return To Control");
            SceneManager.LoadScene("Control", LoadSceneMode.Single);
        }
    }
}
