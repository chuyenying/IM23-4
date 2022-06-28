using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class flicker : MonoBehaviour
{
    private Light light;

    int intensity_zero= 0;
    void Start()
    {
        light = this.GetComponent<Light>();
        light.intensity = 1f;
    }

    private void Update()
    {
        if(light.intensity <= 0f)
        {
            light.intensity = Random.Range(0, 1f);
        }
        
        if(light.intensity > intensity_zero)
        {
            
            float random_sec = Random.Range(0.2f, 0.5f);
            light.intensity -= Time.deltaTime * random_sec;
        }
    }
}
