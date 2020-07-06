using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", 0.1f);
        }
    }

    void Fall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
