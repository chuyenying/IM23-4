using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SisterRun : MonoBehaviour
{
    public Animator sis;
    public GameObject player;
    bool over = false;
    public void sisRunToChangeScene()
    {
        sis.SetBool("RunToChangeScene", true);
        player.gameObject.transform.SetParent(sis.gameObject.transform);
        player.GetComponent<controlpeople>().enabled = false;
        player.gameObject.transform.localPosition= new Vector3(-1f, 0f, 0f);
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene("®a");
    }
}
