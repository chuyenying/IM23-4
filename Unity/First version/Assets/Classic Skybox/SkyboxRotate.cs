using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float RotateSpeed = 1.2f;  //�Ѫű��઺�t��
      
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);  //�H�ɶ���s���઺����
    }
}
