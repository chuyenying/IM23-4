using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHalf_OpenDoor : MonoBehaviour
{
    private int count;
    [SerializeField] private Animator selectHalf_door;
    [SerializeField] private AudioSource selectHalf_door_music;
    private bool play = false;
    private int choose_half = 3;
    void Update()
    {
        count = GameObject.Find("Selection_ob").GetComponent<Selection_ob>().ob_count;
        Debug.Log(count);
        if (count == choose_half && !play)
        {
            selectHalf_door_music.Play();
            selectHalf_door.SetTrigger("SelectOb_Half");
            play = !play;
        }
    }
}
