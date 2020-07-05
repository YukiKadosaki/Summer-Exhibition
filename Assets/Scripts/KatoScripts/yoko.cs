using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class yoko : MonoBehaviour
{
    private Rigidbody rigid;
    private Vector3 defaultPos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rigid.MovePosition(new Vector3(defaultPos.x + Mathf.PingPong(Time.time, 3) * speed, defaultPos.y , defaultPos.z));
    }
}
