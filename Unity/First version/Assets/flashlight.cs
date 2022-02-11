using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    private bool turnon = false;

    [SerializeField] private GameObject fl;//fl¬°flashlight
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
                turnon = !turnon;
                fl.SetActive(turnon);
        }
    }
}
