using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EP3ChangeSceneToFinal2 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("WaitForSevenSecToChangeSceneToFinal2");
    }
    IEnumerator WaitForSevenSecToChangeSceneToFinal2()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("結局二-教室");
    }
}
