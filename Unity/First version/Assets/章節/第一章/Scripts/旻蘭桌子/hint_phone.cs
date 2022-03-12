using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint_phone : MonoBehaviour
{
    [SerializeField] private GameObject hint_cellphone;
    [SerializeField] private AudioSource hint_sound;
    private void Start()
    {
        hint_cellphone.SetActive(false);
        hint_sound.Stop();
    }
    private void Update()
    {
        if (SelectionManager_MainRole.take_phone && !DeskInteractive_Main.E_use)
        {
            hint_cellphone.SetActive(true);
            StartCoroutine(CloseHint());
        }
    }

    IEnumerator CloseHint()
    {
        hint_sound.Play();
        SelectionManager_MainRole.take_phone = false;
        yield return new WaitForSeconds(5);
        hint_cellphone.SetActive(false);
    }
}
