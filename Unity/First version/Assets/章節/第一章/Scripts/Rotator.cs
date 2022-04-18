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
            if (rb.gameObject.name == "卡片" || rb.gameObject.name == "candy")
            {
                rb.transform.Rotate(0, 0, -x);
            }
            else if (rb.gameObject.name == "便條紙1" || rb.gameObject.name == "便條紙2" || rb.gameObject.name == "便條紙4" || rb.gameObject.name == "便條紙3" || rb.gameObject.name == "便條紙5")
            {
                rb.transform.Rotate(-x,0,0);
            }
            else if( rb.gameObject.name == "便條紙6" || rb.gameObject.name == "便條紙7" )
            {
                rb.transform.Rotate(0,-x, 0);
            }
            else if(rb.gameObject.name == "御守" || rb.gameObject.name == "花瓶" || rb.gameObject.name == "手機" )
            {
                rb.transform.Rotate(0, 0, x);
            }
            else if (rb.gameObject.name == "化學")
            {
                rb.transform.Rotate(0, x, 0);
            }
        }
    }
}
