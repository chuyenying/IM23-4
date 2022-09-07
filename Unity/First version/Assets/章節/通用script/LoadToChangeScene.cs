using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadToChangeScene : MonoBehaviour
{
    public void _LoadToChangeScene()
    {
        string json_data = File.ReadAllText(Application.dataPath + "/PlayerData.sav");
        PlayerData data = JsonUtility.FromJson<PlayerData>(json_data);
        PlayerPrefs.SetInt("Automatically_LoadScene", 1);
        SceneManager.LoadScene(data.Scene_Name);
    }
}
