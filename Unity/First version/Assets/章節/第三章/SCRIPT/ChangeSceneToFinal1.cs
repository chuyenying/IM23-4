using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneToFinal1 : MonoBehaviour
{
    public void ChangeSceneFromEP3ToFinal1House()
    {
        PlayerPrefs.SetInt("Ep3-MinLen", 1);
        PlayerPrefs.SetInt("Final1-MinLen", 0);
        PlayerPrefs.SetInt("Final2-MinLen", 0);
        SceneManager.LoadScene("結局一-家");
    }
}
