using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenConversaction : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject robot_anim;
    [SerializeField] private GameObject walk_run_music;

    public void close()
    {
        player.GetComponent<controlpeople>().enabled = false;
        robot_anim.GetComponent<ChaMove>().enabled = false;
        robot_anim.GetComponent<Animator>().enabled = false;
        walk_run_music.SetActive(false);
    }    
    public void open()
    {
        player.GetComponent<controlpeople>().enabled = true;
        robot_anim.GetComponent<ChaMove>().enabled = true;
        robot_anim.GetComponent<Animator>().enabled = true;

        walk_run_music.SetActive(true);
    }
}
