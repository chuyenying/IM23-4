using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCellphone : MonoBehaviour
{
    [SerializeField] private GameObject cellphone_OB , walk_and_run;
    [SerializeField] private bool cellphone = false;
    [SerializeField] private GameObject cellphone_LockPage , cellphone_MainPage;

    private void Awake()
    {
        //cellphone_OB.SetActive(false);        
        if (PlayerPrefs.GetInt("Cellphone_Unlock") == 1)
        {
            cellphone_LockPage.SetActive(false);
            cellphone_MainPage.SetActive(true);
        }
    }
    private void Update()
    {

        if (PlayerPrefs.GetInt("Cellphone") ==1 && Input.GetKeyDown(KeyCode.Tab) && !cellphone && !DeskInteractive_bro.E_use && !DeskInteractive_Main.E_use){ //cellphone=FALSE
            Cursor.lockState=CursorLockMode.Confined;
            cellphone_OB.gameObject.SetActive(true);
            cellphone = !cellphone;
            GameObject.Find("Camera-主角").GetComponent<followpeople>().enabled = false;
            GameObject.Find("主角").GetComponent<controlpeople>().enabled = false;
            walk_and_run.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("Cellphone") ==1 && Input.GetKeyDown(KeyCode.Tab) && cellphone && !DeskInteractive_bro.E_use && !DeskInteractive_Main.E_use)
        {
            Cursor.lockState = CursorLockMode.Locked;
            cellphone_OB.gameObject.SetActive(false);
            GameObject.Find("Camera-主角").GetComponent<followpeople>().enabled = true;
            GameObject.Find("主角").GetComponent<controlpeople>().enabled = true;
            walk_and_run.SetActive(true);
            cellphone = !cellphone;
        }
    }
}
