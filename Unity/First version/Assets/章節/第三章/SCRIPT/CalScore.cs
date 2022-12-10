using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CalScore : MonoBehaviour
{
    public void CalScoreAndChangeScene()
    {
        StartCoroutine("WaitForSevenSec");
    }

    IEnumerator WaitForSevenSec()
    {
        yield return new WaitForSeconds(7f);    //等待Panel動畫跑完
        if (PlayerPrefs.GetInt("score1") >= 15)
        {
            PlayerPrefs.SetInt("Ep3-MinLen", 0);
            PlayerPrefs.SetInt("Final1-MinLen", 1);
            PlayerPrefs.SetInt("Final2-MinLen", 0);
            SceneManager.LoadScene("結局一");
        }
        else if ((PlayerPrefs.GetInt("score1") + PlayerPrefs.GetInt("score2")) > 50)
        {
            PlayerPrefs.SetInt("Ep3-MinLen", 0);
            PlayerPrefs.SetInt("Final1-MinLen", 0);
            PlayerPrefs.SetInt("Final2-MinLen", 1);
            SceneManager.LoadScene("結局二-教室");
        }
        else
        {
            int RandomScene = Random.Range(0, 2);
            if (RandomScene == 0)
            {
                PlayerPrefs.SetInt("Ep3-MinLen", 0);
                PlayerPrefs.SetInt("Final1-MinLen", 1);
                PlayerPrefs.SetInt("Final2-MinLen", 0);
                SceneManager.LoadScene("結局一");
            }
            else
            {
                PlayerPrefs.SetInt("Ep3-MinLen", 0);
                PlayerPrefs.SetInt("Final1-MinLen", 0);
                PlayerPrefs.SetInt("Final2-MinLen", 1);
                SceneManager.LoadScene("結局二-教室");
            }
        }
    }
}
