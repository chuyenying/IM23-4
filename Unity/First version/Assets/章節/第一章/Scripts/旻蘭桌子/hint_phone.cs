using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint_phone : MonoBehaviour
{
    [SerializeField] private GameObject hint_cellphone;
    [SerializeField] private AudioSource hint_sound;
    private bool do_once = true;
    private void Start()
    {
        hint_cellphone.SetActive(false);
        hint_sound.Stop();
    }
    private void Update()
    {
        if (SelectionManager_MainRole.take_phone && !DeskInteractive_Main.E_use && do_once)
        {
            hint_cellphone.SetActive(true);
            hint_sound.Play();
            StartCoroutine(CloseHint());
        }
    }

    IEnumerator CloseHint()
    {
        do_once = false;
        //SelectionManager_MainRole.take_phone = false;
        yield return new WaitForSeconds(5);
        hint_cellphone.SetActive(false);
    }
}
