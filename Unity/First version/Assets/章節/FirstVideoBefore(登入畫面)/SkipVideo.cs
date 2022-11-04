using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkipVideo : MonoBehaviour
{
    [SerializeField] private Image CircleFill;

    private float progress = 0;
    //progress最大只能是1 ，最小是0。 對應 Image 的 Fill Amount

    [SerializeField] private Text Progress_text;


    private float sec = 2;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))  //按下ENTER
        {
            if (progress >= 1)
            {
                progress = 1;
            }
            else
            {
                progress += (1 / sec) * Time.deltaTime; // Enter 按住 sec 秒後會按滿
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
        //text顯示的值介於 0 ~ 100 而 progress 介於 0 ~ 1

        if (progress == 1)
        {
            SceneManager.LoadScene("登入畫面");
        }
    }
}
