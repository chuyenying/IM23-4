using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movetoplayer : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent nav;
    float direction,speed;
    Animator anim;
    void Start()
    {
        GameObject.Find("同學A").GetComponent<movetoplayer>().enabled = false;
        anim = GetComponent<Animator>();
        //nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3(0, 0, -0.5f);
        //Vector3 look = nav.nextPosition;
        Vector3 point = GameObject.Find("FirstPerson").transform.position + a;
        if(DeskInteractive.Amove)
        {
            
            transform.LookAt(new Vector3(point.x,transform.position.y,point.z));
            nav.SetDestination(point);
        }
        //if (nav.remainingDistance == 0)
        if((point.x - nav.nextPosition.x<= 0.01f)
            &&(point.y - nav.nextPosition.y <= 0.01f)
            && (point.z - nav.nextPosition.z <= 0.01f))
        {
            nav.transform.Rotate(new Vector3(0, -90, 0), Space.Self);            
            direction = 0;
            speed = 0;
            GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = true;
            GameObject.Find("同學A").GetComponent<movetoplayer>().enabled = false;

        }
        else
        {
            direction = 1;
            speed = 1.5f;
        }
        
        UpdateAnim();
    }
   void UpdateAnim()
    {
        anim.SetFloat("Blend", direction);
        anim.SetFloat("speed", speed);
    }
}
