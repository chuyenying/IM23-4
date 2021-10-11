using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeskInteractive : MonoBehaviour
{
    public GameObject people,focus_table,butt,firstperson_object;  //people為跟隨人的攝影機,focus_table拍桌面的攝影機,butt為button
    public Text butt_t,t;   //butt_t為button的文字, t為button旁邊的文字
    private bool E_use = false;     //紀錄是否按下了E鍵，如果按下了E鍵才可以按F退出桌面
    private Vector3 player_pos;    //用來固定角色的位置，防止角色在聚焦桌子後亂跑，離開桌子後卻發現自己根本不在桌子旁邊
    public GameObject[] ObjectOnDesk = new GameObject [8];  //此陣列存放存放桌子上的物件
    private int index=0;
    private Color OriginColor,OriginIndexZero;
    void Start()
    {
        focus_table.SetActive(false);
        butt_and_text_close();
    }
    void Update()
    {
        if (E_use == true)
        {
            firstperson_object.gameObject.transform.position = player_pos;
            t.text = "離開桌面";
            butt_t.text = "F";
            butt_and_text_open();

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                index++;
                ObjectOnDesk[index - 1].GetComponent<Renderer>().material.color = OriginIndexZero;
                OriginColor = ObjectOnDesk[index].GetComponent<Renderer>().material.color;
                ObjectOnDesk[index].GetComponent<Renderer>().material.color = Color.yellow;
            }
            if (Input.GetKey(KeyCode.F))
            {
                focus_table.SetActive(false);
                people.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                E_use = false;
                butt_and_text_close();
            }   
        }
    }
    void OnCollisionStay(Collision other) 
    {
        if (other.gameObject.CompareTag("Player"))
         {
            t.text = "查看桌面";
            butt_t.text = "E";
            butt_and_text_open();

            if (Input.GetKey(KeyCode.E) && E_use==false)    //沒按過E鍵才可以開啟桌面
            {
                player_pos = firstperson_object.gameObject.transform.position;
                butt_and_text_close();
                focus_table.SetActive(true);
                people.SetActive(false);
                Cursor.lockState = CursorLockMode.Confined;
                E_use = true;
                OriginIndexZero = ObjectOnDesk[0].GetComponent<Renderer>().material.color;
                ObjectOnDesk[0].GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
    }

    void OnCollisionExit(Collision other)
    {
        butt_and_text_close();
    }

    void butt_and_text_open()
    {
        butt.gameObject.SetActive(true);
        butt_t.gameObject.SetActive(true);
        t.gameObject.SetActive(true);

    }
    void butt_and_text_close()
    {
        butt.gameObject.SetActive(false);
        butt_t.gameObject.SetActive(false);
        t.gameObject.SetActive(false);
    }
}
