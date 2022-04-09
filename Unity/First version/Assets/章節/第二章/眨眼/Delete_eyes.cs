using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_eyes : MonoBehaviour
{
    [SerializeField] private GameObject eyes;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Camera-跟人物").GetComponent<followpeople>().enabled = false;
        GameObject.Find("FirstPerson").GetComponent<flashlight>().enabled = false;
        GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = false;
        StartCoroutine(wait6sec());
    }

    IEnumerator wait6sec()
    {
        yield return new WaitForSeconds(6);
        Destroy(eyes);
        //GameObject.Find("Camera-跟人物").GetComponent<followpeople>().enabled = true;
        //GameObject.Find("FirstPerson").GetComponent<flashlight>().enabled = true;
        //GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = true;
    }
}
