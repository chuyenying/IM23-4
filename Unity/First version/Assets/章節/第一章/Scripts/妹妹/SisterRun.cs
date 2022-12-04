using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class SisterRun : MonoBehaviour
{
    public GameObject sis;
    public GameObject player;
    bool over = false;

    public PlayableDirector SisTimeline;
    public void sisRunToChangeScene()
    {

        player.gameObject.transform.SetParent(sis.transform);
        SisTimeline.Play();
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
