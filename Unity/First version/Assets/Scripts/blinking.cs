using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinking : MonoBehaviour
{
    public Animation topeye, bottomeye;
    void Start()
    {
        StartCoroutine(blink());
    }

    IEnumerator blink()
    {
        yield return new WaitForSeconds(1);
        topeye.Play();
        bottomeye.Play();
    }
}
