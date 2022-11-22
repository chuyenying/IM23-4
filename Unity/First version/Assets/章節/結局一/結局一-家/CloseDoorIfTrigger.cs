using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorIfTrigger : MonoBehaviour
{
    [SerializeField] private Animator DoorAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DoorAnim.ResetTrigger("Open");
            DoorAnim.SetTrigger("Close");
            Destroy(this.gameObject);
        }
    }
}
