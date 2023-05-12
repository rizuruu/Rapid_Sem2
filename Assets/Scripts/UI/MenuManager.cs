using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Play()
    {
        LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void LoadScene(int id)
    {
        SceneManager.LoadScene(id);
    }
}
