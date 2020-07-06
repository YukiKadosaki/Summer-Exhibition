using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukiRespawn : MonoBehaviour
{
    private Vector3 returnpos;

    // Start is called before the first frame update
    void Start()
    {
        ChangeReturnPosition(transform.position);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Water" || hit.gameObject.tag == "Death")
        {
            transform.position = returnpos;
        }
    }
    

    public void ChangeReturnPosition(Vector3 pos)
    {
        returnpos = pos;
    }

    
}
