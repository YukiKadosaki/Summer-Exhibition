using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string nextscene;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(nextscene);
        }
    }
}
