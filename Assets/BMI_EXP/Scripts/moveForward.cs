using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class moveForward : MonoBehaviour
{
    float MoveSpeed = 0.05f;
    private int _cameraHeight = 3;
    private GameObject Head;

    static UdpClient udp;
    IPEndPoint remoteEP = null;
    int i = 0;

    // Start is called before the first frame update
    private void Start()
    {
        Head = GameObject.Find("Camera");
        int LOCA_LPORT = 50007;

        udp = new UdpClient(LOCA_LPORT);
        udp.Client.ReceiveTimeout = 2000;
    }

    // Update is called once per frame
    void Update()
    {
        IPEndPoint remoteEP = null;
        byte[] data = udp.Receive(ref remoteEP);
        string text = Encoding.UTF8.GetString(data);
        Vector3 next_position = transform.position;


        if (Input.GetKey("w"))
        {
            next_position += Head.transform.forward * MoveSpeed;
            Vector3 binding_y = next_position;
            binding_y.y = _cameraHeight;
            transform.position = binding_y;
        }
    }
}   