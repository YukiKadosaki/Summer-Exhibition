/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    private bool weaponed = false;
    private GameObject mainCamera;

    private void Start()
    {
        mainCamera = GameObject.Find("FirstPersonCharacter");
    }

    public void GetGun(Collider other)
    {
        if (other.tag == "WarpGun")
        {
            if (!weaponed) {
                other.transform.SetParent(mainCamera.transform);
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = new Vector3(0, 1, 0.5f);
                other.GetComponent<Quaternion>().
                Debug.Log(Vector3.forward);
                weaponed = true;
            }
        }
    }
}
*/