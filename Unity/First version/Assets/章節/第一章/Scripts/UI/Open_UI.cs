//本
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_UI : MonoBehaviour
{

    [SerializeField] private GameObject walk_and_run;
    [SerializeField] private GameObject MainMenu,SettingMenu;
    //[SerializeField] private Animator MainMenu;
    public static bool open = false;
    private bool Open_SM=false;
    //Open_SM為打開設定與幫助菜單

    private void Awake()
    {
        MainMenu.SetActive(false);
        SettingMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ContinueGame()
    {
        open = false;
        MainMenu.SetActive(false);
        SettingMenu.SetActive(false);
        //MainMenu.SetTrigger("FlyOut");
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("Camera-跟人物").GetComponent<followpeople>().enabled = true;
        GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = true;
        walk_and_run.SetActive(true);

    }
    public void Open_SettingMenu()
    {
        Open_SM = !Open_SM;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !DeskInteractive_Main.E_use && !DeskInteractive_bro.E_use)
        {
            open = !open;
            if (open && !Open_SM)
            {
                //MainMenu.SetTrigger("FlyIn");
                MainMenu.SetActive(true);
                GameObject.Find("Camera-跟人物").GetComponent<followpeople>().enabled = false;
                GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = false;
                walk_and_run.SetActive(false);
                Cursor.lockState = CursorLockMode.Confined;
            }
            else if (!open && !Open_SM)
            {
                ContinueGame();
            }
        }
    }
}
