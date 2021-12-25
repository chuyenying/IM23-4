using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{
    public AudioSource music;

    private void Start()
    {
        StartCoroutine(waitfor());
    }
    IEnumerator waitfor()
    {
        yield return new WaitForSeconds(22);
        music.UnPause();
    }
}
