using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToClassRoom : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("wait");
    }

    IEnumerator wait()
    {
        yield return new  WaitForSeconds(32f);
        SceneManager.LoadScene("БаЋЧ");
    }
}
