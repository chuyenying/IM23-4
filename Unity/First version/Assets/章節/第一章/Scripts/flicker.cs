using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class flicker : MonoBehaviour
{
    private Light light;

    float sec_end;
    float sec = 0;
    public float  sec_min ,sec_max;
    public float  light_min ,light_max;
    public Material flicker_material;
    void Start()
    {
        light = this.GetComponent<Light>();
        light.intensity = Random.Range(light_min, light_max);
        sec_end = Random.Range(sec_min, sec_max);
    }

    private void Update()
    {
        if(sec < sec_end)
        {
            sec += Time.deltaTime;
        }
        else if(sec >= sec_end)
        {
            light.intensity = Random.Range(light_min, light_max);
            if(light.intensity > (light_min+ light_max)/2)
            {
                flicker_material.SetColor("_EmissionColor",new Color(5, 5, 5));
            }
            else
            {
                flicker_material.SetColor("_EmissionColor", new Color(0.5f, 0.5f, 0.5f));
            }
            sec = 0;
            sec_end = Random.Range(sec_min, sec_max);
        }
    }
}
