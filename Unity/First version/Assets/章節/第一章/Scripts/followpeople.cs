using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpeople : MonoBehaviour
{
    public Transform playerbody;
    public float mousespeed;    //視角移動的速度
    float xrotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        //鎖定鼠標不出現
    }

    void Update()
    {
        //利用input.GetAxis取得滑鼠往X、Y方向的值
        float mouse_x = Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * mousespeed * Time.deltaTime;

        

        xrotation -= mouse_y;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        //限制視角不能抬超過90或-90，避免讓玩家的頭斷掉

        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        //camera視角隨滑鼠移動
        playerbody.Rotate(Vector3.up * mouse_x);
        //玩家將滑鼠左右移動，角色也會跟著左右旋轉
    }
}