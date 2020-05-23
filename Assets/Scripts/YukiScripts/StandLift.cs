using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandLift : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touch");

        if (other.tag == "MoveBlock")
        {
            Debug.Log("MoveBlock");
            this.transform.SetParent(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MoveBlock")
        {
            this.transform.SetParent(null);
        }
    }
}
