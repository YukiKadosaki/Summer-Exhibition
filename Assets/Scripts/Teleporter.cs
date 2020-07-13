using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Stage1-demo");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Stage2-demo");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Stage3-demo");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Stage4-demo");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("stage5-demo");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("stage6");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SceneManager.LoadScene("TitleScene");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SceneManager.LoadScene("EndStage");
        }

    }
}
