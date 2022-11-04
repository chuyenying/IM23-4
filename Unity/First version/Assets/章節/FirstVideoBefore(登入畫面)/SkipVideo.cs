using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkipVideo : MonoBehaviour
{
    [SerializeField] private Image CircleFill;

    private float progress = 0;
    //progress�̤j�u��O1 �A�̤p�O0�C ���� Image �� Fill Amount

    [SerializeField] private Text Progress_text;


    private float sec = 2;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))  //���UENTER
        {
            if (progress >= 1)
            {
                progress = 1;
            }
            else
            {
                progress += (1 / sec) * Time.deltaTime; // Enter ���� sec ���|����
            }
        }
        else
        {
            if (progress > 0)
            {
                progress -= (1 / sec) * Time.deltaTime;
            }
            else
            {
                progress = 0;
            }
        }

        CircleFill.fillAmount = progress;
        Progress_text.text = ((int)(progress * 100)).ToString();
        //text��ܪ��Ȥ��� 0 ~ 100 �� progress ���� 0 ~ 1

        if (progress == 1)
        {
            SceneManager.LoadScene("�n�J�e��");
        }
    }
}
