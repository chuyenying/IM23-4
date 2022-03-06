using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaMove : MonoBehaviour
{   
    public float speed;
    public float direction = 0;
    Animator anim;
    Vector3 move;
    private bool run = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        move = (transform.right * x) + transform.forward * z;
        speed = controlpeople.speed;
        bool moveforward =Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow);
        bool moveright = Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow);
        bool moveleft = Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow);
        bool movebackward = Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow);
        if (moveforward)
        {
            direction = 1;
        }
        else if(movebackward)
        {
            direction = 2;
        }
        else if (moveleft)
        {
            direction = 3;
        }
        else if(moveright)
        {
            direction = 4;
        }
        if (move == new Vector3(0, 0, 0))
        {
            direction = 0;
            speed = 0;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) { if (run) { run = false; } else { run = true; } }
        UpdateAnim();
    }
    void UpdateAnim()
    {
        anim.SetFloat("speed", speed);
        anim.SetFloat("Blend", direction);
    }
}
