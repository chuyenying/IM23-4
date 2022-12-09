using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.transform.position = new Vector3(-149.798996f, -13.507f, 7.75515556f);
        }
    }
}
