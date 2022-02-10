using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    private int turn_sec=1, OffOrOn;
    private bool call = true;
    [SerializeField] private new Light light;

    void Update()
    {
        if (call)
        {
            StartCoroutine(Light_flicker_on());
        }
        
    }

    IEnumerator Light_flicker_on()
    {
        call = !call;
        turn_sec = Random.Range(1, 3);
        OffOrOn = Random.Range(0, 2);
  
        yield return new WaitForSeconds(turn_sec);
        
        if (OffOrOn==1)
        {
            light.range = 10;
        }
        else
        {
            light.range = 0;
        }
        call = !call;
    }

}
