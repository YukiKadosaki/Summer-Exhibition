using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuaRespawn : MonoBehaviour
{
    private Vector3 returnpos;



    // Start is called before the first frame update
    void Start()
    {
        ChangeReturnPosition(transform.position);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Water")
        {
            transform.position = returnpos;
        }
        
        if(hit.gameObject.tag == "Teleport1")
        {
            transform.position = new Vector3(-66, 2, 40);
        }

        if (hit.gameObject.tag == "Teleport2")
        {
            transform.position = new Vector3(63,1,44);
        }

    }

    public void ChangeReturnPosition(Vector3 pos)
    {
        returnpos = pos;
    }
}
