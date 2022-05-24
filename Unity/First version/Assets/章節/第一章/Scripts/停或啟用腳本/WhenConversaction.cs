using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenConversaction : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject walk_run_music;

    public void close()
    {
        player.GetComponent<controlpeople>().enabled = false;
        walk_run_music.SetActive(false);
    }    
    public void open()
    {
        player.GetComponent<controlpeople>().enabled = true;
        walk_run_music.SetActive(true);
    }
}
