using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public GameObject destination;
    [SerializeField] NavMeshAgent theAgent;
    /*
    void Update()
    {
        theAgent.SetDestination(destination.transform.position);
        Debug.Log(destination.transform.position);
    }
    */
    public void GoTarget()
    {
        theAgent.SetDestination(destination.transform.position);
    }
}
