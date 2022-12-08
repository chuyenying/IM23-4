using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Letter : MonoBehaviour
{
    [SerializeField] private Animator Classmate_Anim;
    [SerializeField] private Rigidbody Classmate_Trans;
    private bool Trigger = false;
    private bool Play_Once = true;
    private void Update()
    {
        if (!Trigger)
        {
            Classmate_Anim.SetBool("walk", true);
            Classmate_Trans.gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else 
        {
            Classmate_Anim.SetBool("Give letter", true);
            Play_Once = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            Trigger = !Trigger;
            Destroy(other);
        }
    }
}
