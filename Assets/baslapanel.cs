using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslapanel : MonoBehaviour
{
    public GameObject panel;
    public void ExitButton()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void FirstScene()
    {
        SceneManager.LoadScene(0);
    }
    public void Panel()
    {
        panel.SetActive(true);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(4);
    }
}
