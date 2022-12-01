using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using UnityEngine.AI;


public class SisterRun : MonoBehaviour
{
    [SerializeField] private GameObject sis;
    [SerializeField] private GameObject sis_ChangeScenePos;
    [SerializeField] private GameObject sisdes;
    Vector3 Pos;
    [SerializeField] private GameObject player;
    public GameObject cam1, cam2;
    [SerializeField] private NavMeshAgent sis_agent;

    //public PlayableDirector SisTimeline;
    [SerializeField] private Animator sisanim;

    public void sisRunToChangeScene()
    {
        sis_ChangeScenePos.SetActive(true);
        sisdes.GetComponent<NPCdes>().enabled = false;
        sis.GetComponent<NPC>().enabled = false;
        
        cam1.SetActive(false);
        cam2.SetActive(true);

        player.gameObject.transform.SetParent(sis.transform);

        Pos = new Vector3(-6.51534128f, 2.7019999f, 10.0555086f);
        //sisdes.transform.position = Pos;

        sis_agent.speed = 1;
        sis_agent.SetDestination(Pos);

        sisanim.ResetTrigger("Walk");
        sisanim.ResetTrigger("Idle");
        sisanim.SetTrigger("holdhand");
        
        player.GetComponent<controlpeople>().enabled = false;
        player.gameObject.transform.localPosition = new Vector3(-1f, 0f, 0f);

    }
}
