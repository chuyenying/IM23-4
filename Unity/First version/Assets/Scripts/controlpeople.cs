using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpeople : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 0.3f;    //角色移動速度
    Animator anim;

    void Update()
    {
        speed = 0.3f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;    //按shift可加速
        }

        //利用Input.GetAxis("Horizontal")、("Vertical")
        //來偵測WASD的值，值介於-1~1;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);


    }

}