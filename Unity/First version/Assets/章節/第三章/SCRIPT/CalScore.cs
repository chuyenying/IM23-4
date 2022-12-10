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
        yield return new WaitForSeconds(7f);    //����Panel�ʵe�]��
        if (PlayerPrefs.GetInt("score1") >= 15)
        {
            PlayerPrefs.SetInt("Ep3-MinLen", 0);
            PlayerPrefs.SetInt("Final1-MinLen", 1);
            PlayerPrefs.SetInt("Final2-MinLen", 0);
            SceneManager.LoadScene("�����@");
        }
        else if ((PlayerPrefs.GetInt("score1") + PlayerPrefs.GetInt("score2")) > 50)
        {
            PlayerPrefs.SetInt("Ep3-MinLen", 0);
            PlayerPrefs.SetInt("Final1-MinLen", 0);
            PlayerPrefs.SetInt("Final2-MinLen", 1);
            SceneManager.LoadScene("�����G-�Ы�");
        }
        else
        {
            int RandomScene = Random.Range(0, 2);
            if (RandomScene == 0)
            {
                PlayerPrefs.SetInt("Ep3-MinLen", 0);
                PlayerPrefs.SetInt("Final1-MinLen", 1);
                PlayerPrefs.SetInt("Final2-MinLen", 0);
                SceneManager.LoadScene("�����@");
            }
            else
            {
                PlayerPrefs.SetInt("Ep3-MinLen", 0);
                PlayerPrefs.SetInt("Final1-MinLen", 0);
                PlayerPrefs.SetInt("Final2-MinLen", 1);
                SceneManager.LoadScene("�����G-�Ы�");
            }
        }
    }
}
