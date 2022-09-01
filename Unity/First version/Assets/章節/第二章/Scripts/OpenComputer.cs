using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenComputer : MonoBehaviour
{
    [SerializeField] private GameObject camera_computer, camera_peo, walk_run_music;
    private bool open = false, trigger = false, ClickGameButton = false;
    [SerializeField] private GameObject E_image, Text_OpenComputer, Text_CloseComputer;
    private void Awake()
    {
        E_image.SetActive(open);
        Text_OpenComputer.SetActive(open);
        Text_CloseComputer.SetActive(open);
    }

    private void Update()
    {
        Debug.Log($"Open:{open} , ClickGameButton:{ClickGameButton}");
        if (Input.GetKeyDown(KeyCode.E) && trigger && !ClickGameButton)
        {
            open = !open;
            camera_computer.SetActive(open);
            camera_peo.SetActive(!open);

            if (open)
            {
                GameObject.Find("主角").GetComponent<controlpeople>().enabled = false;
            }
            else
            {
                GameObject.Find("主角").GetComponent<controlpeople>().enabled = true;
            }
        }

    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            trigger = true;
            if (!open && !ClickGameButton)  //還沒打開電腦也沒開遊戲
            {
                E_image.SetActive(true);
                Text_OpenComputer.SetActive(true);
                Text_CloseComputer.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.Find("主角").GetComponent<controlpeople>().enabled = true;
                walk_run_music.SetActive(true);
            }
            else if (open && !ClickGameButton)  //已經打開電腦且沒有打開遊戲
            {
                E_image.SetActive(true);
                Text_OpenComputer.SetActive(false);
                Text_CloseComputer.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
                GameObject.Find("主角").GetComponent<controlpeople>().enabled = false;
                walk_run_music.SetActive(false);

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        E_image.SetActive(false);
        Text_OpenComputer.SetActive(false);
        Text_CloseComputer.SetActive(false);
        trigger = false;
    }

    public void ClickGame() //有可能是打開遊戲或是關掉遊戲
    {
        ClickGameButton = !ClickGameButton;
        ClickGameButtonAndCannotShow_EImage();
    }

    private void ClickGameButtonAndCannotShow_EImage()  //如果是打開遊戲的時候就不顯示UI
    {
        if (ClickGameButton)
        {
            E_image.SetActive(false);
            Text_OpenComputer.SetActive(false);
            Text_CloseComputer.SetActive(false);
        }
    }
}
