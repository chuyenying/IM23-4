using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaMove : MonoBehaviour
{
    public float speed = 0.3f;
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
        speed = 2;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;    //«öshift¥i¥[³t
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        move = (transform.right * x) + transform.forward * z;

        Vector3 localMove = transform.InverseTransformVector(move);
        forwardAmount = localMove.z;
        UpdateAnim();
    }
    void UpdateAnim()
    {
        anim.SetFloat("speed", forwardAmount);
    }
}
