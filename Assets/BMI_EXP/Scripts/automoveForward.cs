using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class automoveForward : MonoBehaviour
{
    private Vector3 pos;
    static UdpClient udp;
    IPEndPoint remoteEP = null;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        int LOCA_LPORT = 50007;

        udp = new UdpClient(LOCA_LPORT);
        udp.Client.ReceiveTimeout = 2000;
        StartCoroutine("moveForward");
    }

    IEnumerator moveForward()
    {
        IPEndPoint remoteEP = null;
        byte[] data = udp.Receive(ref remoteEP);
        string flag = Encoding.UTF8.GetString(data);
        if (flag == "1")
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
