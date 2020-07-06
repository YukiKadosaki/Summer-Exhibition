using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFallFloor : MonoBehaviour
{
    private Vector3 returnpos;
    private Quaternion returnrot;
    Rigidbody rb;

    private void Start()
    {
        returnpos = transform.position;
        returnrot = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            rb.isKinematic = true;
            this.transform.rotation = returnrot;
            this.transform.position = returnpos;
        }
    }
}
