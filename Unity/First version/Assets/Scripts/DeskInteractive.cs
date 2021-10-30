using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeskInteractive : MonoBehaviour
{
    public GameObject focus_people, focus_table, focus_pencilbox, butt, firstperson_object, butt2;  //focus_people為跟隨人的攝影機,focus_table拍桌面的攝影機,butt為button
    public GameObject focus_card, cardpic, focus_mamori,focus_flower;
    public Text butt_t, t, butt_t2, t2;   //butt_t為button的文字, t為button旁邊的文字
    private bool E_use = false, LookAt = false;     //紀錄是否按下了E鍵，如果按下了E鍵才可以按F退出桌面。LookAt紀錄是否正在看鉛筆盒
    private Vector3 player_pos;    //用來固定角色的位置，防止角色在聚焦桌子後亂跑，離開桌子後卻發現自己根本不在桌子旁邊
    public GameObject[] ObjectOnDesk = new GameObject[8];  //此陣列存放存放桌子上的物件
    private int index = 0;        //ObjectOnDesk的索引值
    private Color[] ObjectOnDesk_Color = new Color[8];   //儲存物件原本的顏色
    void Start()
    {
        focus_people.SetActive(true);
        focus_table.SetActive(false);   //一開始桌子跟鉛筆盒的相機都先關閉
        focus_pencilbox.SetActive(false);
        cardpic.SetActive(false);
        focus_card.SetActive(false);
        focus_mamori.SetActive(false);
        focus_flower.SetActive(false);
        butt_and_text_close();          //上下button也全關閉
        butt_and_text_close2();

        for (int i = 0; i < ObjectOnDesk.Length; i++)
        {
            ObjectOnDesk_Color[i] = ObjectOnDesk[i].GetComponent<Renderer>().material.color;        //先把物件原先的顏色儲存起來
        }
    }
    void Update()
    {
        if (E_use == true)  //如果有按E
        {
            firstperson_object.gameObject.transform.position = player_pos;  //把剛剛存起來的位置給角色，讓角色無法移動
            butt_t.text = "F";
            if (LookAt == false)
            {
                t.text = "離開桌面";
                butt_and_text_open();
            }

            Choose_PB();
            Choose_card();
            Choose_mamori();
            Choose_flower();

           
            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                index = index + (int)(Input.GetAxis("Mouse ScrollWheel") * 10);
            }

            if (LookAt == false)
             {
                 if (index < 0)
                 {
                    index = 0;
                 }
                if (index == 0)
                {
                    ObjectOnDesk[index].GetComponent<Renderer>().material.color = Color.yellow;
                    ObjectOnDesk[1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[1];
                }

                if (index > ObjectOnDesk.Length - 1)
                {
                    index = ObjectOnDesk.Length - 1;
                }
                if(index ==ObjectOnDesk.Length - 1)
                
                {
                    ObjectOnDesk[index].GetComponent<Renderer>().material.color = Color.yellow;
                    ObjectOnDesk[index-1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[index-1];
                }
                if(index>0 &&index< ObjectOnDesk.Length - 1)
                {
                    ObjectOnDesk[index].GetComponent<Renderer>().material.color = Color.yellow;
                    ObjectOnDesk[index-1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[index-1];
                    ObjectOnDesk[index +1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[index +1];
                }
             }

            if (Input.GetKeyDown(KeyCode.F) && LookAt == false)    //沒有查看鉛筆盒的情況按F才可以離開桌面
            {
                index = 0;
                firstperson_object.gameObject.SetActive(true);
                Table_SwitchTo_People();
                E_use = false;
                butt_and_text_close();
                butt_and_text_close2();
                for (int i = 0; i < ObjectOnDesk.Length; i++)
                {
                    ObjectOnDesk[i].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[i];
                }
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

            if (Input.GetKey(KeyCode.E) && E_use == false)    //沒按過E鍵才可以開啟桌面
            {
                firstperson_object.gameObject.SetActive(false); //打開桌面後，角色就暫時看不到
                player_pos = firstperson_object.gameObject.transform.position;  //把角色按下E當下的位置記錄起來。
                butt_and_text_close();                         //把BUTTON跟文字關閉
                People_SwitchTo_Table();
                E_use = true;
                ObjectOnDesk[0].GetComponent<Renderer>().material.color = Color.yellow; //剛進到桌面的時候會自動先選鉛筆盒。
            }
        }
    }

    void OnCollisionExit(Collision other)
    {
        butt_and_text_close();
    }

    // **** 以下是兩個button及個別旁邊的文字的開啟關閉 ****
    void butt_and_text_open()
    {
        butt.gameObject.SetActive(true);
        t.gameObject.SetActive(true);
    }
    void butt_and_text_close()
    {
        butt.gameObject.SetActive(false);
        t.gameObject.SetActive(false);
    }
    void butt_and_text_open2()
    {
        butt2.gameObject.SetActive(true);
        t2.gameObject.SetActive(true);

    }
    void butt_and_text_close2()
    {
        butt2.gameObject.SetActive(false);
        t2.gameObject.SetActive(false);
    }

    // ----------------------------------------------------

    // **** 以下是相機的切換 ****
    void People_SwitchTo_Table()    //將跟隨人的相機關閉，並打開聚焦桌面的相機(用於查看桌面)
    {
        focus_people.SetActive(false);
        focus_table.SetActive(true);
    }

    void Table_SwitchTo_People()    //將聚焦桌子的相機關閉，打開聚焦人的(用於離開桌面)
    {
        focus_people.SetActive(true);
        focus_table.SetActive(false);
    }

    void Table_SwitchTo_PB()        //將聚焦桌面的相機關閉，打開聚焦鉛筆盒(用於從桌面按Enter選鉛筆盒)
    {
        focus_pencilbox.SetActive(true);
        focus_table.SetActive(false);
    }
    void PB_SwitchTo_Table()        //(用於離開鉛筆盒)
    {
        focus_pencilbox.SetActive(false);
        focus_table.SetActive(true);
    }
    void Table_SwitchTo_Card()
    {
        focus_table.SetActive(false);
        focus_card.SetActive(true);
        cardpic.SetActive(true);
    }
    void Card_SwitchTo_Table()
    {
        focus_card.SetActive(false);
        focus_table.SetActive(true);
        cardpic.SetActive(false);
    }
    void Table_SwitchTo_mamori()
    {
        focus_table.SetActive(false);
        focus_mamori.SetActive(true);
    }
    void Mamori_SwitchTo_Table()
    {
        focus_mamori.SetActive(false);
        focus_table.SetActive(true);
    }
    void Table_SwitchTo_flower()
    {
        focus_table.SetActive(false);
        focus_flower.SetActive(true);
    }
    void Flower_SwitchTo_Table()
    {
        focus_flower.SetActive(false);
        focus_table.SetActive(true);
    }

    //--------------------------------------------------------

    // **** 與選擇物件相關****
    void Choose_PB()     //跟鉛筆盒有關的
    {
        if (index == 0)

        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看鉛筆盒";
                butt_and_text_open2();
            }
            
            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[0].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[0];
                Table_SwitchTo_PB();
                butt_and_text_close();
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開鉛筆盒";
            }
            if (Input.GetMouseButtonDown(1) && LookAt==true)
            {
                ObjectOnDesk[0].GetComponent<Renderer>().material.color = Color.yellow;
                PB_SwitchTo_Table();
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看鉛筆盒";
                LookAt = false;
            }
        }
        
    }
    // ----------------------------------------------------------------

    //**** 選卡片
    void Choose_card()
    {
        if (index == 2)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看卡片";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[2].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[2];
                Table_SwitchTo_Card();
                butt_and_text_close();
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開卡片";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                ObjectOnDesk[2].GetComponent<Renderer>().material.color = Color.yellow;
                Card_SwitchTo_Table();
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看卡片";
                LookAt = false;
            }
        }
     
    }

    //****選御守
    void Choose_mamori()
    {
        if (index == 1)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看御守";
                butt_and_text_open2();
            }
            

            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[1].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[1];
                Table_SwitchTo_mamori();
                butt_and_text_close();
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開御守";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                ObjectOnDesk[1].GetComponent<Renderer>().material.color = Color.yellow;
                Mamori_SwitchTo_Table();
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看御守";
                LookAt = false;
            }
        }
    }
    void Choose_flower()
    {
        if (index == 3)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看天堂鳥";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                LookAt = true;
                ObjectOnDesk[3].GetComponent<Renderer>().material.color = ObjectOnDesk_Color[3];
                Table_SwitchTo_flower();
                butt_and_text_close();
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開天堂鳥";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                ObjectOnDesk[3].GetComponent<Renderer>().material.color = Color.yellow;
                Flower_SwitchTo_Table();
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看天堂鳥";
                LookAt = false;
            }
        }
    }
    
}