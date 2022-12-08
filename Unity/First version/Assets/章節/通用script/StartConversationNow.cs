using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.Events;
public class StartConversationNow : MonoBehaviour
{
    [SerializeField] private UnityEvent Open, Close;
    public void OpenConversation(string title)
    {
        DialogueManager.StartConversation(title);
        Cursor.lockState = CursorLockMode.Confined;
        Open.Invoke();
    }

    public void CloseConversaction()
    {
        DialogueManager.StopAllConversations();
        Cursor.lockState = CursorLockMode.Locked;
        Close.Invoke();

    }

}
