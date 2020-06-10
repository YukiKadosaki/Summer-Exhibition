using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katodeathdesu : MonoBehaviour
{
    private Vector3 returnpos;

    // Start is called before the first frame update
    void Start()
    {
        ChangeReturnPosition(transform.position);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if(hit.gameObject.tag =="Water")
        {
            
            transform.position = returnpos;
        }
    }

    public void ChangeReturnPosition(Vector3 pos)
    {
        returnpos = pos;
    }
}