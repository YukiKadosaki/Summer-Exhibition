using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CG2 : MonoBehaviour
{
    public Vector3 localGravity = new Vector3(-9.8f, 0, 0);
    public Vector3 LocalGravity = new Vector3(0, -9.8f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Physics.gravity = localGravity;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Physics.gravity = LocalGravity;
        }
    }

}
