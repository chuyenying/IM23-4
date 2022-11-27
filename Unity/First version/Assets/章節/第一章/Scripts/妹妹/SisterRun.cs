using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class SisterRun : MonoBehaviour
{
    public GameObject sis;
    public GameObject sisdes;
    Vector3 Pos;
    public GameObject player;
    public GameObject cam1, cam2;

    //public PlayableDirector SisTimeline;
    Animator sisanim;
    public void sisRunToChangeScene()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        player.gameObject.transform.SetParent(sis.transform);
        sisanim = sis.GetComponent<Animator>();
        sisdes.GetComponent<NPCdes>().enabled = false;
        Pos = new Vector3(-3.58f, 2.702f, 8.063f);
        sisdes.transform.position = Pos;
        sisanim.ResetTrigger("Walk");
        sisanim.ResetTrigger("Idle");
        sisanim.SetTrigger("holdhand");
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
