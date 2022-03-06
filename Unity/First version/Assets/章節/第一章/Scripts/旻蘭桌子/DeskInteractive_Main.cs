using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeskInteractive_Main : MonoBehaviour
{
    private Vector3 FirstPerson_position;
    [SerializeField] private GameObject focus_people, focus_table, focus_info, bg;  //carema
    [SerializeField] private GameObject E_button, F_button, left_click, right_click;   //button
    [SerializeField] private GameObject FirstPerson;//¨¤¦â
    [SerializeField] private GameObject selectionManager;
    //[SerializeField] private GameObject selectionManager;

    private bool E_use = false;

    private void Start()
    {
        focus_table.SetActive(false);
        F_button.SetActive(false);
        E_button.SetActive(false);
        selectionManager.SetActive(false);
        left_click.SetActive(false);
        right_click.SetActive(false);
    }

    private void Update()
    {
        if (E_use)
        {
            FirstPerson.transform.position = FirstPerson_position;
            if (Input.GetKey(KeyCode.F) && !SelectionManager_MainRole.read_info)
            {
                F_button.SetActive(false);
                FirstPerson.SetActive(true);
                focus_people.SetActive(true);
                focus_table.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                E_use = false;
                left_click.SetActive(false);
                selectionManager.SetActive(false);
                SelectionManager_MainRole.name = "";
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            E_button.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                FirstPerson.SetActive(false);
                focus_people.SetActive(false);
                focus_table.SetActive(true);
                E_button.SetActive(false);
                E_use = true;
                FirstPerson_position = FirstPerson.transform.position;
                Cursor.lockState = CursorLockMode.Confined;
                F_button.SetActive(true);
                selectionManager.SetActive(true);
                left_click.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        E_button.SetActive(false);
    }
}

