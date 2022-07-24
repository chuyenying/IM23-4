using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenComputer : MonoBehaviour
{
    [SerializeField] private GameObject camera_computer, camera_peo , walk_run_music;
    private bool open = false , trigger=false;
    [SerializeField] private GameObject E_image, Text_OpenComputer, Text_CloseComputer;
    private void Awake()
    {
        E_image.SetActive(open);
        Text_OpenComputer.SetActive(open);
        Text_CloseComputer.SetActive(open);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && trigger)
        {
            open = !open;
            camera_computer.SetActive(open);
            camera_peo.SetActive(!open);
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            trigger = true;
            if (!open)  //還沒打開電腦
            {
                E_image.SetActive(true);
                Text_OpenComputer.SetActive(true);
                Text_CloseComputer.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.Find("主角").GetComponent<controlpeople>().enabled = true;
                walk_run_music.SetActive(true);
            }
            else if (open)  //已經打開電腦
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
}
