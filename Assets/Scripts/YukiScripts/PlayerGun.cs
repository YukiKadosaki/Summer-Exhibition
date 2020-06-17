using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    private bool weaponed = false;
    private GameObject mainCamera;
    private GameObject[] partOfGun;

    private void Start()
    {
        mainCamera = GameObject.Find("FirstPersonCharacter");
        partOfGun = GameObject.FindGameObjectsWithTag("WarpGun");
    }

    public void GetGun(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!weaponed)
            {
                foreach(GameObject part in partOfGun)
                {
                    if(null != part.GetComponent<MeshRenderer>())
                    {
                        part.GetComponent<MeshRenderer>().enabled = true;
                    }
                }
                weaponed = true;
            }
        }
    }

    private void Update()
    {
        if (weaponed)
        {
            Debug.Log(transform.forward);
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = new Ray(transform.position + transform.forward, transform.up);
                Debug.DrawLine(ray.origin, transform.up, Color.red, 20f);
                Physics.Raycast(ray, out hit, Mathf.Infinity, Physics.AllLayers, QueryTriggerInteraction.Ignore);
                /*if (Physics.Raycast(ray, out hit, Mathf.Infinity, Physics.AllLayers, QueryTriggerInteraction.Ignore))
                {
                    Debug.Log(hit.collider.name);
                }*/
            }
        }
    }
}
