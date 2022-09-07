using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpeople : MonoBehaviour
{
    public static Vector3 move;
    public CharacterController controller;
    [SerializeField] public float gravity = -9.81f;
    [SerializeField] Vector3 velocity;
    static public float speed = 0;    //角色移動速度
    private bool run = false;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
   [SerializeField] bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) { if (run) { run = false; } else { run = true; } }
        if(run)
        {
            speed = 5;    //按shift可加速
        }
        else
        {
            speed = 1.5f;
        }

        //利用Input.GetAxis("Horizontal")、("Vertical")
        //來偵測WASD的值，值介於-1~1;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}