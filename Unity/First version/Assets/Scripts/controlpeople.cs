using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpeople : MonoBehaviour
{
    public AudioSource walk;
    public CharacterController controller;
    static public float speed = 0;    //角色移動速度
    private bool run = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) { if (run) { run = false; } else { run = true; } }
        if(run)
        {
            walk.UnPause();
            walk.pitch = 2;
            speed = 3;    //按shift可加速
        }
        else
        {
            walk.UnPause();
            walk.pitch = 1;
            speed = 1.5f;
        }

        //利用Input.GetAxis("Horizontal")、("Vertical")
        //來偵測WASD的值，值介於-1~1;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        if(move==new Vector3(0, 0, 0))
        {
            walk.Pause();
        }
        controller.Move(move * speed * Time.deltaTime);
    }
}