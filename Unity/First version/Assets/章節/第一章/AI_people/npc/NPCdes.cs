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

    Vector3 NewPos, OldPos, FirstRandomPos; //新舊點

    [SerializeField] NavMeshAgent theAgent;     //對應的NPC

    [SerializeField] private float x1, z1, x2, z2, TwoPointDistance, MaxDistance;

    [SerializeField] private string NPCTag;

    private void Start()
    {
        anim = theAgent.gameObject.GetComponent<Animator>();

        FirstRandomPos = new Vector3(Random.Range(x1, x2), 2.702f, Random.Range(z1, z2));
        NavMesh.SamplePosition(FirstRandomPos, out hit, MaxDistance, 1);
        this.gameObject.transform.position = new Vector3(hit.position.x, 2.702f, hit.position.z);

        OldPos = FirstRandomPos;
        anim.SetTrigger("Walk");    //在該動畫的event裡面使用npc腳本的GoTarget()。

    }

    private void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            theAgent.speed = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == NPCTag)
        {
            //Idle 
            anim.ResetTrigger("Walk");
            anim.SetTrigger("Idle");
            //theAgent.speed = 0;

            //確保新生成的點不會離舊的點太近
            do
            {
                NewPos = new Vector3(Random.Range(x1, x2), 2.702f, Random.Range(z1, z2));
            } while (Vector3.Distance(NewPos, OldPos) < TwoPointDistance);

            NavMesh.SamplePosition(NewPos, out hit, MaxDistance, 1);    //尋找在藍色區域內離NewPos最近的點
            this.gameObject.transform.position = new Vector3(hit.position.x, 2.702f, hit.position.z); //將這個位置給巡路方塊
            OldPos = NewPos;
            StartCoroutine("AfterGoingTakeARest");
        }
    }
    IEnumerator AfterGoingTakeARest()
    {        
        float sec = Random.Range(5f, 10f);

        yield return new WaitForSeconds(sec);

        // walk
        anim.ResetTrigger("Idle");
        anim.SetTrigger("Walk");    //在該動畫的event裡面使用npc腳本的GoTarget()。只有在播走路動的時候人物才會走動
    }
}
