using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katodeathkawarudesu : MonoBehaviour

{
    public Vector3 LocalGravity2 = new Vector3(0, -9.8f, 0);
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
            Physics.gravity = LocalGravity2;
        }
    }

}