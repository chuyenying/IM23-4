using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerLogic : MonoBehaviour
{
    private int Click = 0;
    private float DoubleClick_Endtime = 1f;
    private float DoubleClick_time = 0f;

    [SerializeField] private GameObject window;
    void Update()
    {
        if (DoubleClick_time < DoubleClick_Endtime)
        {
            DoubleClick_time += Time.deltaTime;
            CheckDoubleClick();
        }
        else
        {
            Click = 0;
            DoubleClick_time = 0;
        }
    }


    public void Click_add()
    {
        Click += 1;
    }

    public void CheckDoubleClick()
    {
        if (Click == 2)
        {
            window.SetActive(true);
        }
    }

    public void CloseWindow()
    {
        window.SetActive(false);
    }
}
