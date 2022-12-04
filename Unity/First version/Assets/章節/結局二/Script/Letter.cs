using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    Animator animator;
    public float speed = 2;
    bool walk = false;

    void Start()
    {
        Invoke("letter", 10);
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (walk == true)
        {
            Vector3 des = new Vector3(-1.30999994f, 2.65249157f, 26.8369999f);
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed); ;
            if (this.transform.position == des)
            {
                transform.Rotate(0, 90, 0);
                animator.SetBool("Give letter", true);
                animator.SetBool("Give letter", false);
                animator.SetBool("walk", false);
            }
        }
    }
    void letter()
    {
        animator.SetBool("walk", true);
        walk = true;
    }
}
