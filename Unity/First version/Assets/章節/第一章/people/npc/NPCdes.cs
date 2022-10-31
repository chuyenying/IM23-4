using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.Events;

public class NPCdes : MonoBehaviour
{

    public int pivopoint;
    NavMeshHit hit;
    Vector3 point0, point1;
    public UnityEvent GoTarget;

    [SerializeField] private float x1, z1, x2, z2, TwoPointDistance, MaxDistance;

    private void Start()
    {
        GoTarget.Invoke();
        point1 = this.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerÄ²µo");
        if (other.tag == "NPC")
        {
            if (pivopoint == 0)
            {
                do
                {
                    point0 = new Vector3(Random.Range(x1, x2), 2.702f, Random.Range(z1, z2));
                    //Debug.Log(point0);
                } while (Vector3.Distance(point0, point1) < TwoPointDistance);

                NavMesh.SamplePosition(point0, out hit, MaxDistance, 1);
                this.gameObject.transform.position = new Vector3(hit.position.x, 2.702f, hit.position.z);
                GoTarget.Invoke();
                pivopoint = 1;
            }
            if (pivopoint == 1)
            {
                do
                {
                    point1 = new Vector3(Random.Range(x1, x2), 2.702f, Random.Range(z1, z2));
                } while (Vector3.Distance(point1, point0) < TwoPointDistance);

                NavMesh.SamplePosition(point1, out hit, MaxDistance, 1);
                this.gameObject.transform.position = new Vector3(hit.position.x, 2.702f, hit.position.z);
                GoTarget.Invoke();
                pivopoint = 0;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerÂ÷¶}");
        if (other.tag == "NPC")
        {
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerable WaitForSec()
    {
        float sec = Random.Range(2f, 5f);
        gameObject.GetComponent<NPC>().enabled = false;
        yield return new WaitForSeconds(sec);
        gameObject.GetComponent<NPC>().enabled = true;
        gameObject.GetComponent<NPC>().GoTarget();
    }
}
