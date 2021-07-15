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
    [SerializeField] private AudioClip clearSound;
    [SerializeField] private AudioClip clearSound2;
    GameObject obj;
    private AudioSource m_audioSource;

    private void Start()
    {
        m_audioSource = this.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Goal")
        {

            Invoke("Change", delayTime);
            GameObject obj = GameObject.Find("cong");
            Debug.Log(obj.name);
            obj.GetComponent<TMP_Text>().text = goalString;

            if (null != clearSound)
            {
                m_audioSource.clip = clearSound;
                m_audioSource.Play();
            }
        }
        if(collider.gameObject.tag == "Goal2")
        {
            if (null != clearSound)
            {
                m_audioSource.clip = clearSound2;
                m_audioSource.Play();
            }
        }
    }

    public void Change()
    {
        SceneManager.LoadScene(nextscene);
    }
}
