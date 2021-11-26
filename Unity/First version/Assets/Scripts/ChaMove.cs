using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaMove : MonoBehaviour
{
    public float speed = 0;
    public float direction;
    Animator anim;
    Vector3 move;
    float forwardAmount;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

        bool moveforward =Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow);
        bool moveright = Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow);
        bool moveleft = Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow);
        bool movebackward = Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow);
        speed = 0;
        if(moveforward)
        {
            direction = 1;
            speed = 2;
        }
        else if(movebackward)
        {
            direction = 2;
            speed = 2;
        }
        else if (moveleft)
        {
            direction = 3;
            speed = 2;
        }
        else if(moveright)
        {
            direction = 4;
            speed = 2;
        }
        else
        {
            direction = 1;
            speed = 0;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;    //«öshift¥i¥[³t
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        move = (transform.right * x) + transform.forward * z;

        UpdateAnim();
    }
    void UpdateAnim()
    {
        anim.SetFloat("speed", speed);
        anim.SetFloat("Blend", direction);
    }
}
