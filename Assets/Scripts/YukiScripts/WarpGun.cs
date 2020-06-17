using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpGun : MonoBehaviour
{
    private bool weaponed = false;
    private GameObject mainCamera;
    private GameObject partOfGun;

    private void Start()
    {
        mainCamera = GameObject.Find("FirstPersonCharacter");
    }

    public void GetGun(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!weaponed)
            {
                transform.Find("Handgun_M1911A (Model)").gameObject.GetComponent<MeshRenderer>().enabled = true;
                transform.Find("CasingExit").gameObject.GetComponent<MeshRenderer>().enabled = true;
                transform.Find("Hammer").gameObject.GetComponent<MeshRenderer>().enabled = true;
                transform.Find("Slider").gameObject.GetComponent<MeshRenderer>().enabled = true;
                transform.Find("Trigger").gameObject.GetComponent<MeshRenderer>().enabled = true;
                this.GetComponent<MeshRenderer>().enabled = true;
                Debug.Log(Vector3.forward);
                weaponed = true;
            }
        }
    }
}
