using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderChangeSceneToEP2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SIS_NPC")
        {
            SceneManager.LoadScene("®a");
        }
    }
}
