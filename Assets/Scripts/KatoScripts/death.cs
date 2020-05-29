using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

 
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Finish")
       
        {
            
        // Debug.Log("GameOver");
        }
   
    }
}