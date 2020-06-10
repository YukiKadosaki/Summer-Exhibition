using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class korogarurespowne : MonoBehaviour
{
    private Vector3 returnpos;

    void Start()
    {
        returnpos = this.transform.position;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Water")
        {
            transform.position = returnpos;
        }
    }
}
