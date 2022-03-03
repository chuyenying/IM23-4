﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    float xRotation = 0f;
    public GameObject PlayerBody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, 33, 50);

        PlayerBody.transform.localRotation = Quaternion.Euler(xRotation, 182.857f, 4.627f);
    }
}