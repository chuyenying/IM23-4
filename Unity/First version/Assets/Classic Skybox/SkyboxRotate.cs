using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float RotateSpeed = 1.2f;  //天空旋轉的速度
      
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);  //隨時間更新旋轉的角度
    }
}
