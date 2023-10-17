using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using System;

public class Menu_ManagerScript : MonoBehaviour
{
    public void ExitGame()

    {
        Application.Quit();
    }

    public void StartLevel(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        Handler.strt = DateTime.Now;
    }

}