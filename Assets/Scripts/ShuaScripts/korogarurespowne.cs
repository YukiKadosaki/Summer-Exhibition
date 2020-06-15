using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class korogarurespowne : MonoBehaviour
{
    public Vector3 returnposi;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            rb.isKinematic = true;
            this.transform.position = returnposi;
        }
        rb.isKinematic = false;
    }
}
