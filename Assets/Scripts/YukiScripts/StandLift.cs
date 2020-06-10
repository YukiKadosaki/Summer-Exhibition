using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandLift : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "MoveBlock")
        {
            this.transform.SetParent(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MoveBlock")
        {
            this.transform.SetParent(null);
        }
    }
}
