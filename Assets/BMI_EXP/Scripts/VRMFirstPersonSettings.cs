using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

[RequireComponent(typeof(VRMFirstPerson))]
public class VRMFirstPersonSetting : MonoBehaviour
{

    [SerializeField] bool isFirtPerson;

    VRMFirstPerson vrmFirstPerson;

    void Start()
    {

        vrmFirstPerson = GetComponent<VRMFirstPerson>();

        if (isFirtPerson)
            vrmFirstPerson.Setup();

    }

    void Update()
    {

    }
}