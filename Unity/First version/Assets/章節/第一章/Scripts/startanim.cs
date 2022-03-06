using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startanim : MonoBehaviour
{
    Animator anim;
    public float walk = 0, sit = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateAnim()
    {
        anim.SetFloat("walk", walk);
        anim.SetFloat("sitandstand", sit);
    }
}
