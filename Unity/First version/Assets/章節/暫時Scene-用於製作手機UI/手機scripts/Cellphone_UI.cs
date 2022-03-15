using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cellphone_UI : MonoBehaviour
{
    [SerializeField] private InputField input;
    [SerializeField] private Animator password_wrong_anim;
    public void pressNum(string num)
    {
        input.text += num;
    }
    public void EraseNum()
    {
        input.text = input.text.Remove(input.text.Length-1);
    }
    public void checkPassword()
    {
        if (input.text == "0714")
        {
            password_wrong_anim.SetTrigger("open_Lock");
        }
        else
        {
            password_wrong_anim.SetTrigger("wrong_password");
        }
    }
}
