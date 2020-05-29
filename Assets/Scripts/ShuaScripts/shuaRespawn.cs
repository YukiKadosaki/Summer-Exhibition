using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuaRespawn : MonoBehaviour
{
    Vector3 initpos;


    // Start is called before the first frame update
    void Start()
    {
        initpos = transform.position;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Water")
        {
            transform.position = initpos;
        }
    }
}
