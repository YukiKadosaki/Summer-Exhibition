using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpGun : MonoBehaviour
{
    private bool weaponed = false;
    private GameObject mainCamera;

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
                //銃がプレイヤーのほうを向く
                transform.LookAt(other.transform.localPosition);

                this.transform.SetParent(mainCamera.transform);
                this.GetComponent<Rigidbody>().useGravity = false;
                this.GetComponent<Rigidbody>().isKinematic = true;
                this.transform.localPosition = new Vector3(1f, -0.3f, 1.5f);

                //向こうを向く
                transform.Rotate(new Vector3(0, 150, 0));
                
                Debug.Log(Vector3.forward);
                weaponed = true;
            }
        }
    }
}
