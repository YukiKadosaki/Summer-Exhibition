using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour
{
    [SerializeField]private string nextscene;
    [SerializeField]private string goalString = "Congratulations";
    [SerializeField] private float delayTime = 3;
    GameObject obj;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Goal")
        {
            Invoke("Change", delayTime);
            GameObject obj = GameObject.Find("cong");
            Debug.Log(obj.name);
            obj.GetComponent<TMP_Text>().text = goalString;
        }
    }

    public void Change()
    {
        SceneManager.LoadScene(nextscene);
    }
}
