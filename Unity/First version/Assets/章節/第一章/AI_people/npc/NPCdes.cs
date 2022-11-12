using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.Events;

public class NPCdes : MonoBehaviour
{
    Animator anim;

    NavMeshHit hit;

    Vector3 NewPos, OldPos, FirstRandomPos; //�s���I

    [SerializeField] NavMeshAgent theAgent;     //������NPC

    [SerializeField] private float x1, z1, x2, z2, TwoPointDistance, MaxDistance;

    private void Start()
    {
        anim = theAgent.gameObject.GetComponent<Animator>();

        FirstRandomPos = new Vector3(Random.Range(x1, x2), 2.702f, Random.Range(z1, z2));
        NavMesh.SamplePosition(FirstRandomPos, out hit, MaxDistance, 1);
        this.gameObject.transform.position = new Vector3(hit.position.x, 2.702f, hit.position.z);

        OldPos = FirstRandomPos;
        anim.SetTrigger("Walk");    //�b�Ӱʵe��event�̭��ϥ�npc�}����GoTarget()�C

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerĲ�o");
        if (other.tag == "NPC")
        {
            do
            {
                NewPos = new Vector3(Random.Range(x1, x2), 2.702f, Random.Range(z1, z2));
                Debug.Log("�b�j�餤");
            } while (Vector3.Distance(NewPos, OldPos) < TwoPointDistance);

            NavMesh.SamplePosition(NewPos, out hit, MaxDistance, 1);    //�M��b�Ŧ�ϰ줺��NewPos�̪��I
            this.gameObject.transform.position = new Vector3(hit.position.x, 2.702f, hit.position.z); //�N�o�Ӧ�m���������
            OldPos = NewPos;
            StartCoroutine("AfterGoingTakeARest");
        }
    }
    IEnumerator AfterGoingTakeARest()
    {
        //Idle
        
        theAgent.speed = 0;
        anim.ResetTrigger("Walk");
        anim.SetTrigger("Idle");
        
        float sec = Random.Range(4f, 7f);
        Debug.Log($"����{sec}��");

        yield return new WaitForSeconds(sec);

        // walk
        anim.ResetTrigger("Idle");
        anim.SetTrigger("Walk");    //�b�Ӱʵe��event�̭��ϥ�npc�}����GoTarget()�C
    }
}
