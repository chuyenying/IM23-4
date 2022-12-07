using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class EP3_OnStartConversaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.StopAllConversations();
        DialogueManager.StartConversation("�ĤT��-�a-�}�Ҥ���κ�ı");
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void LockCursorAndStopConversaction()
    {
        Cursor.lockState = CursorLockMode.Locked;
        DialogueManager.StopAllConversations();
    }
}
