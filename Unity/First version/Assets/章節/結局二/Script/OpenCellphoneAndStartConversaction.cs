using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class OpenCellphoneAndStartConversaction  : MonoBehaviour
{
    void Start()
    {
        DialogueManager.StartConversation("�����G-���");
        Debug.Log("TEST");
    }
}
