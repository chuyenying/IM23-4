using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cellphone_UI : MonoBehaviour
{
    [SerializeField] private GameObject MainScreen,Lock_Screen;
    [SerializeField] private GameObject Remove_Button;
    [SerializeField] private InputField input;
    [SerializeField] private Animator password_wrong_anim;
    [SerializeField] private AudioSource lock_wrong_sound, Unlock_sound;
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
            int PlayerPrefscore = PlayerPrefs.GetInt("score2");
            PlayerPrefscore += 5;
            PlayerPrefs.SetInt("score2", PlayerPrefscore);
            Debug.Log($"score2: {PlayerPrefs.GetInt("score2")}");

            password_wrong_anim.SetTrigger("open_Lock");
            StartCoroutine(wait());
        }
        else
        {
            input.text="";
            lock_wrong_sound.Play();
            password_wrong_anim.SetTrigger("wrong_password");
        }
    }
    public void Update()
    {
        if (input.text.Length != 0){Remove_Button.SetActive(true);}
        else{Remove_Button.SetActive(false);}
    }

    IEnumerator wait()
    {
        Unlock_sound.Play();
        yield return new WaitForSeconds(1.5f);
        
        Lock_Screen.SetActive(false);
        MainScreen.SetActive(true);
    }
}
