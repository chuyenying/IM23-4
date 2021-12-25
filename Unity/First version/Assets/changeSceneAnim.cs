using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSceneAnim : MonoBehaviour
{

    private void Start()
    {
        //changeScene = GetComponent<Animator>();
        StartCoroutine(changesce());
    }
    
    IEnumerator changesce()
    {
        yield return new WaitForSeconds(22);
        //StartCoroutine(closechangesce());
    }

    IEnumerator closechangesce()
    {
        yield return new WaitForSeconds(5);
    }
}
