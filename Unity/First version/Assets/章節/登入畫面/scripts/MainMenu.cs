using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        PixelCrushers.SaveSystem.LoadScene("開場動畫");
        //SceneManager.LoadScene("開場動畫");
    }
}
