using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDrag()
    {
        dragging = true;
    }
    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))  //按下滑鼠左鍵後要放開時
        {
            dragging = false;
        }
    }

    private void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            if (rb.gameObject.name == "卡片")
            {
                rb.transform.Rotate(0, 0, -x);
            }
            else if ( rb.gameObject.name == "便條紙第2個內容" || rb.gameObject.name == "便條紙第4個內容" || rb.gameObject.name == "便條紙第5個內容" )
            {
                rb.transform.Rotate(0,-x,0);
            }
            else if(rb.gameObject.name == "便條紙第3個內容")
            {
                rb.transform.Rotate(-x,0, 0);
            }
            else if(rb.gameObject.name == "御守" || rb.gameObject.name == "花瓶")
            {
                rb.transform.Rotate(0, 0, x);
            }
        }
    }
}
