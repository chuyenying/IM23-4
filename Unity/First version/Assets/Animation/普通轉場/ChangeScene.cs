using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public Animator Anim;
    public AudioSource music;

    private void Start()
    {
        StartCoroutine(waitfor22());
    }
    IEnumerator waitfor22()
    {
        yield return new WaitForSeconds(22);
        Anim.SetTrigger("Start");
        music.Play();
        StartCoroutine(waitfor2());
    }

    IEnumerator waitfor2()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("БаЋЧ");
    }
}
