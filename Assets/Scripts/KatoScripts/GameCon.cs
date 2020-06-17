using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCon : MonoBehaviour
{
    public GameObject CCtext;
    // Start is called before the first frame update
    void Start()
    {
        CCtext.SetActive(false);
    }

 
    private  void OnTrggerEnter (Collider collider)

        {
            if (collider.gameObject.tag =="Player")
            {
                CCtext.SetActive(true);
            }
        }
    
}
