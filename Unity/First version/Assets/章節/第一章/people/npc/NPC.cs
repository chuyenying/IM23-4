using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public GameObject destination;
    [SerializeField] NavMeshAgent theAgent;

    public void GoTarget()
    {
        theAgent.speed = 1;
        theAgent.SetDestination(destination.transform.position);
    }

}
