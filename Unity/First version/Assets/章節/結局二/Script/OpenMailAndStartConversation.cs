using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.Events;
public class OpenMailAndStartConversation : MonoBehaviour
{
    public UnityEvent PlayTimeline_WithBrotherGoHome;
    public void  RunAnim()
    {
        PlayTimeline_WithBrotherGoHome.Invoke();
    }
}
