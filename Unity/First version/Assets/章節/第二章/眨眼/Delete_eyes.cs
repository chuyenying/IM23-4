using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_eyes : MonoBehaviour
{
    [SerializeField] private GameObject eyes;
    [SerializeField] private GameObject walk_run_music;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Camera-�D����H��").GetComponent<followpeople>().enabled = false;
        GameObject.Find("�D��").GetComponent<controlpeople>().enabled = false;
        walk_run_music.SetActive(false);

        StartCoroutine(wait6sec());
    }

    IEnumerator wait6sec()
    {
        yield return new WaitForSeconds(6);
        Destroy(eyes);
        GameObject.Find("Camera-�D����H��").GetComponent<followpeople>().enabled = true;
        GameObject.Find("�D��").GetComponent<controlpeople>().enabled = true;
        walk_run_music.SetActive(true);

    }
}
