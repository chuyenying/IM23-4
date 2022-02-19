using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

[CreateAssetMenu(fileName = "SceneSwitch")]
public class SceneSwitch : ScriptableObject
{
    public GameObject myobject;

    void Update()
    {
        Rigidbody rb = myobject.GetComponent<Rigidbody>();
        myobject.SetActive(true);

        SceneManager.LoadScene(3);
    }
}
