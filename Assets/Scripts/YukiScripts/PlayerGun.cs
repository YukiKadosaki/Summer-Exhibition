using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    private bool weaponed = false;

    public void GetGun(Collider other)
    {
        if (other.tag == "WarpGun")
        {
            if (!weaponed) {
                other.transform.SetParent(this.transform);
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = Vector3.forward;
                weaponed = true;
            }
        }
    }
}
