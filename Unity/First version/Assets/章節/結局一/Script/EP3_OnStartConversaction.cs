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
        DialogueManager.StartConversation("第三章-家-開啟手機或睡覺");
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void LockCursorAndStopConversaction()
    {
        Cursor.lockState = CursorLockMode.Locked;
        DialogueManager.StopAllConversations();
    }
}
