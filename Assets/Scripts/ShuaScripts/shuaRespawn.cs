using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuaRespawn : MonoBehaviour
{
    private Vector3 returnpos;
    [SerializeField] private Vector3 telep0;



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

        if (hit.gameObject.tag == "Teleport0")
        {
            transform.position = telep0;
        }

        if (hit.gameObject.tag == "Teleport1")
        {
            transform.position = new Vector3(-87, 2, 85);
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
