using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InsText : MonoBehaviour
{
    GameObject obj;

    private void Start()
    {
        GameObject obj = GameObject.Find("cong");
        obj.GetComponent<TextMeshPro>().text = "Congraturations";
    }
    
}
