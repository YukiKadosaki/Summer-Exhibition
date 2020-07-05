using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour
{
    [SerializeField]private string nextscene;
    GameObject obj;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Goal")
        {
            Invoke("Change", 3);
            GameObject obj = GameObject.Find("cong");
            Debug.Log(obj.name);
            obj.GetComponent<TMP_Text>().text = "Congratulations";
        }
    }

    public void Change()
    {
        SceneManager.LoadScene(nextscene);
    }
}
