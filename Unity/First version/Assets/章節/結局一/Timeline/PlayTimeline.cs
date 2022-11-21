using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayTimeline : MonoBehaviour
{
    [SerializeField] private PlayableDirector One,Two;

    public void ChooseOne()
    {
        One.Play();
        Debug.Log("One");
    }

    public void ChooseTwo()
    {
        Two.Play();
        Debug.Log("Two");
    }
}
