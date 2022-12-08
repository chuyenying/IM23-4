using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Delete_eyes : MonoBehaviour
{
    [SerializeField] private GameObject eyes;
    [SerializeField] private UnityEvent WhenUseEyes, AfterDeleteEyes;

    // Start is called before the first frame update
    void Start()
    {
        WhenUseEyes.Invoke();
        StartCoroutine(wait6sec());
    }

    IEnumerator wait6sec()
    {
        yield return new WaitForSeconds(6);
        Destroy(eyes);
        AfterDeleteEyes.Invoke();
    }
}
