using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk_run_music : MonoBehaviour
{
    [SerializeField] private AudioSource walk, run;
    private bool iswalk=true;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            iswalk = !iswalk;
        }
        if (iswalk)
        {
            if(controlpeople.move==new Vector3(0, 0, 0))
            {
                walk.Pause();
                run.Pause();
            }
            else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.D))
            {
                walk.UnPause();
                run.Pause();
            }
        }
        else
        {
            if (controlpeople.move == new Vector3(0, 0, 0))
            {
                walk.Pause();
                run.Pause();
            }
            else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.D))
            {
                run.UnPause();
                walk.Pause();
            }
        }
    }
}
