using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaitSecToDoSomething : MonoBehaviour
{
    [SerializeField] private float sec;
    [SerializeField] private UnityEvent WaitToDo;

    private void Start()
    {
        StartCoroutine("WaitSecToDo");
    }
    IEnumerator WaitSecToDo()
    {
        yield return new WaitForSeconds(sec);
        WaitToDo.Invoke();
    }
}
