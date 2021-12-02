using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose_SoundEffect : MonoBehaviour
{
    public GameObject Ob;
    public AudioSource choose_sound;
    private bool do_once=true;  //避免音效重複播放
    void Update()
    {
        if(Ob.transform.position== new Vector3(-1.039f, 1.5f, -0.299f)) {   //物件飛起來的時候(選物件)
            if (do_once) { choose_sound.Play(); } 
            do_once = false;
        } 
        else { do_once = true; }
    }
}
