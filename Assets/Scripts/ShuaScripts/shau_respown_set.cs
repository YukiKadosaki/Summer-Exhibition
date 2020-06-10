using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shau_respown_set : MonoBehaviour
{
    [SerializeField] private Material savedColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<shuaRespawn>().ChangeReturnPosition(this.transform.position);
            this.GetComponent<MeshRenderer>().material = savedColor;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
