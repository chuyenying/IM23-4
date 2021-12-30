using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button_opendoor : MonoBehaviour
{
    public Text b1_t, t1;
    public GameObject b1;
    private bool open = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!open)
            {
                b1_t.text = "E";
                b1.SetActive(true);
                t1.gameObject.SetActive(true);
                t1.text = "開門";
            }
            else
            {
                b1_t.text = "F";
                b1.SetActive(true);
                t1.gameObject.SetActive(true);
                t1.text = "關門";
            }
            if (Input.GetKey(KeyCode.E) && !open)
            {
                open = true;
                //從教室開門，播放動畫   
            }
            else if (Input.GetKey(KeyCode.F) && open)
            {
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
