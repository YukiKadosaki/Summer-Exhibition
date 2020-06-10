using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukiRespawnChanger : MonoBehaviour
{
    [SerializeField] private Material savedColor;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<YukiRespawn>().ChangeReturnPosition(this.transform.position);
            this.GetComponent<MeshRenderer>().material = savedColor;
            this.GetComponent<AudioSource>().Play();
        }
    }
    
}
