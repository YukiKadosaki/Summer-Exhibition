using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otiruyo : MonoBehaviour
{
    Rigidbody rib;

    private void Start()
    {
        rib = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        rib.useGravity = false;

        if (collision.gameObject.tag == "Player")
        {
            rib.useGravity = true;
        }
    }
}
