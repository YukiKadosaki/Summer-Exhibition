using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukiRespawn : MonoBehaviour
{
    Vector3 initpos;

    // Start is called before the first frame update
    void Start()
    {
        initpos = transform.position;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.gameObject.name);

        if(hit.gameObject.tag == "Water")
        {
            transform.position = initpos;
        }
    }
    
}
