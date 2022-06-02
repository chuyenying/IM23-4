using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref_Score : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.DeleteKey("score1");
        PlayerPrefs.DeleteKey("score2");
        PlayerPrefs.SetInt("score1", 0);    
        PlayerPrefs.SetInt("score2", 0);    
    }

    public void score1(int score)
    {
        int PlayerPrefscore = PlayerPrefs.GetInt("score1");
        PlayerPrefscore += score;
        PlayerPrefs.SetInt("score1", PlayerPrefscore);
        Debug.Log($"score1: {PlayerPrefs.GetInt("score1")}");
    }
    public void score2(int score)
    {
        int PlayerPrefscore = PlayerPrefs.GetInt("score2");
        PlayerPrefscore += score;
        PlayerPrefs.SetInt("score2", PlayerPrefscore);
        Debug.Log($"score2: {PlayerPrefs.GetInt("score2")}");

    }
}
