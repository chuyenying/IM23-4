using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ending1_ChangeScene : MonoBehaviour
{
    public void ChangeScene()
    {
        StartCoroutine("WaitForSevenSec");
    }

    IEnumerator WaitForSevenSec()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("結局一-家");
    }
}
