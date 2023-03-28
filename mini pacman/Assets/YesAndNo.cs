using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YesAndNo : MonoBehaviour
{


    public void Play()
    {
        SceneManager.LoadScene("Test-Youtube");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("quit");
    }


    public void Yes()
    {
        SceneManager.LoadScene("Test-Youtube");
    }
    public void No()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
