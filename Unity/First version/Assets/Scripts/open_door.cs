using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class open_door : MonoBehaviour
{
    public Text b1_t,t1;
    public GameObject b1;
    private bool open = false;
    private void Start()
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!open)
            {
                b1.SetActive(true);
                t1.gameObject.SetActive(true);
                b1_t.text = "E";
                t1.text = "打開門";
            }
            else
            {
                b1.SetActive(true);
                t1.gameObject.SetActive(true);
                b1_t.text = "F";
                t1.text = "關上門";
            }
   
            if (Input.GetKey(KeyCode.E) && !open)
            {
                //從教室開門，播放動畫
                open = true;
            }
            else if (Input.GetKey(KeyCode.F) && open)
            {
                //從走廊關門，播放動畫
                open = false;
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        b1.SetActive(false);
        t1.gameObject.SetActive(false);
    }
}
