using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LookAtMail : MonoBehaviour
{
    private bool Open = false , HintAlready = false;
    public UnityEvent OpenMail, CloseMail , Hint;

    public void AnimOverAndHintMail()
    {
        Hint.Invoke();  //���ܫ�E�}��mail
        HintAlready = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && HintAlready)
        {
            Open = !Open;
            if (Open)
            {
                OpenMail.Invoke();
            }
            else
            {
                CloseMail.Invoke();
            }
        }
    }
}
