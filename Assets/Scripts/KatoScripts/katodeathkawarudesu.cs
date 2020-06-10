using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katodeathkawarudesu : MonoBehaviour

{
    public Material savedColor;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<katodeathdesu>().ChangeReturnPosition(this.transform.position);
            this.GetComponent<MeshRenderer>().material = savedColor;
            this.GetComponent<AudioSource>().Play();
        }
    }

}