using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private Animator DoorAnim;

    public void OpenDoorAnim()
    {
        DoorAnim.SetTrigger("Open");
    }

    public void CloseDoorAnim()
    {
        DoorAnim.SetTrigger("Close");
    }
}
