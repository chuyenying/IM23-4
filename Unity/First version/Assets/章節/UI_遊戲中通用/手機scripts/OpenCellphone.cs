using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCellphone : MonoBehaviour
{
    [SerializeField] private GameObject cellphone_OB , walk_and_run;
    [SerializeField] private bool cellphone = false;

    private void Start()
    {
        cellphone_OB.SetActive(false);
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("Cellphone") && Input.GetKeyDown(KeyCode.Tab) && !cellphone && !DeskInteractive_bro.E_use && !DeskInteractive_Main.E_use){ //cellphone=FALSE
            Cursor.lockState=CursorLockMode.Confined;
            cellphone_OB.gameObject.SetActive(true);
            cellphone = !cellphone;
            GameObject.Find("Camera-跟人物").GetComponent<followpeople>().enabled = false;
            GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = false;
            walk_and_run.SetActive(false);
            //cellphone=TRUE
        }
        else if(PlayerPrefs.HasKey("Cellphone") && Input.GetKeyDown(KeyCode.Tab) && cellphone && !DeskInteractive_bro.E_use && !DeskInteractive_Main.E_use)
        {
            Cursor.lockState = CursorLockMode.Locked;
            cellphone_OB.gameObject.SetActive(false);
            GameObject.Find("Camera-跟人物").GetComponent<followpeople>().enabled = true;
            GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = true;
            walk_and_run.SetActive(true);
            cellphone = !cellphone;
        }
    }
}
