using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class choose_SoundEffect : MonoBehaviour
{
    [SerializeField] private GameObject Ob;
    [SerializeField] private AudioSource choose_sound;
    [SerializeField] private bool do_once=true;  //避免音效重複播放
    void Update()
    {
        if(Ob.transform.position== new Vector3(-0.473f, 3.972f, 23.622f)) {   //物件飛起來的時候(選物件)
            if (do_once) { choose_sound.Play(); } 
            do_once = false;
        } 
        else { do_once = true; }
    }
}
