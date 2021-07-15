using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EXGoal : MonoBehaviour
{
    GameObject obj;
    GameObject ex;

    private void OnTriggerEnter(Collider collider)
    {
        GameObject obj = GameObject.Find("cong");

        if (collider.gameObject.tag == "Goal2")
        {
            GameObject ex = GameObject.Find("exgoal");
            
            Invoke("Praise", 3);
            obj.GetComponent<TMP_Text>().text = "Congratulations";
        }
    }

    public void Praise()
    {
        GameObject obj = GameObject.Find("cong");

        obj.GetComponent<TMP_Text>().fontSize = 22;
        obj.GetComponent<TMP_Text>().text = "You are\nwonderful player!";
        Invoke("Change", 3);
    }

    public void Change()
    {
        GetComponent<ChangeScenes>().Change();
    }
}
