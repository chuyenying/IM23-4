using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenCellphone : MonoBehaviour
{
    [SerializeField] private GameObject cellphone_OB ;
    [SerializeField] private bool cellphone = false;
    [SerializeField] private GameObject cellphone_LockPage , cellphone_MainPage;
    [SerializeField] private UnityEvent OpenCellphoneEvent , CloseCellphoneEvent;

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

            OpenCellphoneEvent.Invoke();
            
        }
        else if(PlayerPrefs.GetInt("Cellphone") ==1 && Input.GetKeyDown(KeyCode.Tab) && cellphone && !DeskInteractive_bro.E_use && !DeskInteractive_Main.E_use)
        {
            Cursor.lockState = CursorLockMode.Locked;
            cellphone_OB.gameObject.SetActive(false);

            CloseCellphoneEvent.Invoke();

            cellphone = !cellphone;
        }
    }
}
