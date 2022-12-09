using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.Events;

public class StartConversation_EP2 : MonoBehaviour
{
    [SerializeField] private UnityEvent Open, Close;
    private void Start()
    {
        DialogueManager.StartConversation("第二章-妹妹上樓後對話");
        Cursor.lockState = CursorLockMode.Confined;
        Open.Invoke();
    }

    public void CloseConversaction()
    {
        Close.Invoke();
    }
}
