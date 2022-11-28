using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class OpenCellphoneAndStartConversaction  : MonoBehaviour
{
    void Start()
    {
        DialogueManager.StartConversation("結局二-手機");
        Debug.Log("TEST");
    }
}
