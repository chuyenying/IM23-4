using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_close_door : MonoBehaviour
{
    private bool open = false;
    [SerializeField] private GameObject E_button, F_button;
    [SerializeField] private Animator door_anim;
    void Start()
    {
        E_button.SetActive(false);
        F_button.SetActive(false);
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!open)
            {
                E_button.SetActive(true);
            }
            else
            {
                F_button.SetActive(true);
            }
        }
        if (Input.GetKey(KeyCode.E) && !open)
        {
            open = true;
            E_button.SetActive(false);
            F_button.SetActive(true);
            door_anim.SetTrigger("open");
        }
        else if (Input.GetKey(KeyCode.F) && open)
        {
            open = false;
            E_button.SetActive(true);
            F_button.SetActive(false);
            door_anim.SetTrigger("close");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        E_button.SetActive(false);
        F_button.SetActive(false);
    }
}
