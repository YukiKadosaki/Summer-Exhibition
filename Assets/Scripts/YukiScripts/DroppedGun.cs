using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedGun : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void DestroyGun(Collider other)
    {

            if (other.tag == "Player")
            {
                Destroy(this.gameObject);
            }
        
    }
}
