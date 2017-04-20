using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void LoadGameBtn(string loadGameLevel)
    {
        SceneManager.LoadScene(loadGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
