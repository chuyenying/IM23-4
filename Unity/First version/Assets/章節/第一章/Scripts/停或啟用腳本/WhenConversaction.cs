using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenConversaction : MonoBehaviour
{
    public void close()
    {
        GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = false;
        GameObject.Find("walk_run_music").SetActive(false);
    }    
    public void open()
    {
        GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = true;
        GameObject.Find("walk_run_music").SetActive(true);
    }
}
