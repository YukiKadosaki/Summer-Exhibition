using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    public Vector3 localGravity = new Vector3(-9.8f, 0, 0); 
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "Gravity")
        {
            Physics.gravity = localGravity;

        }
    }
}
