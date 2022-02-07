using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeskInteractive : MonoBehaviour
{
    [SerializeField] private GameObject bg;   //查看物件的背景
    //private bool IfUserNeedNPC = true;
    [SerializeField] private GameObject focus_people, focus_table, butt, firstperson_object, butt2;
    //focus_people為跟隨人的攝影機,focus_table拍桌面的攝影機,butt為button

    [SerializeField] private Text butt_t, t, butt_t2, t2, more_info,write_name;   
    //butt_t為button的文字, t為button旁邊的文字
   
    private bool E_use = false, LookAt = false, do_once = true,see_image=false;
    //紀錄是否按下了E鍵，如果按下了E鍵才可以按F退出桌面。LookAt紀錄是否正在看鉛筆盒
    //do_once避免進入桌面後道具越來越高。

    static public bool Amove = false;

    private Vector3 player_pos, ob_pos = new Vector3(-0.473f, 3.972f, 23.622f);
    //player_pos用來固定角色的位置，防止角色在聚焦桌子後亂跑，離開桌子後卻發現自己根本不在桌子旁邊
    //ob_pos是物體被選到的位置

    [SerializeField] private GameObject[] ObjectOnDesk = new GameObject[8];  
    //此陣列存放存放桌子上的物件
   
    private Vector3[] objectpos = new Vector3[8],objectrot = new Vector3[8];    
    //儲存一開始物件的位子跟旋轉角度
   
    private int index = 0;        
    //ObjectOnDesk的索引值

    private float turnspeed = 100f;


    //選物件的旋轉速度
    void Start()
    {
        focus_people.SetActive(true);
        focus_table.SetActive(false);   //一開始桌子跟鉛筆盒的相機都先關閉
        butt_and_text_close();          //上下button也全關閉
        butt_and_text_close2();
        bg.SetActive(false);
        write_name.gameObject.SetActive(false);
        more_info.gameObject.SetActive(false);

        for (int i = 0; i < ObjectOnDesk.Length; i++)
        {
            objectpos[i] = ObjectOnDesk[i].transform.position;  //儲存一開始物件的位置
            objectrot[i] = ObjectOnDesk[i].transform.rotation.eulerAngles;//儲存一開始物件的角度
        }
        //StartCoroutine(NPC_WaitFor30Sec());
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
            Choose_paper1();
            Choose_paper2();
            Choose_paper3();
            Choose_paper4();
            Choose_paper5();
            Choose_card();
            Choose_flower();
            if (!see_image) //避免玩家在查看(EX:卡片內容)的時候使用滾輪而出錯
            {
                if (Input.GetAxis("Mouse ScrollWheel") != 0)    //滾輪
                {
                    index = index + (int)(Input.GetAxis("Mouse ScrollWheel") * 10);
                    do_once = true;
                }

                if (LookAt == false)
                {

                    if (index > ObjectOnDesk.Length - 1)
                    {
                        index = ObjectOnDesk.Length - 1;
                        do_once = false;
                    }
                    if (index < 0)
                    {
                        index = 0;
                        do_once = false;
                    }
                    if (index == 0)
                    {
                        if (do_once)
                        {
                            ObjectOnDesk[index].transform.position = ob_pos;
                            do_once = false;
                        }
                        ObjectOnDesk[1].transform.position = objectpos[1];
                        ObjectOnDesk[1].transform.eulerAngles = objectrot[1];

                        //---------------------旋轉物件--------------------
                        if (Input.GetKey(KeyCode.W))
                        {
                            ObjectOnDesk[index].transform.Rotate(-Vector3.right * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.S))
                        {
                            ObjectOnDesk[index].transform.Rotate(Vector3.right * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.A))
                        {
                            ObjectOnDesk[index].transform.Rotate(Vector3.forward * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.D))
                        {
                            ObjectOnDesk[index].transform.Rotate(-Vector3.forward * turnspeed * Time.deltaTime);
                        }
                        //-----------------------------------------------
                    }

                    else if (index == ObjectOnDesk.Length - 1)

                    {
                        if (do_once)
                        {
                            ObjectOnDesk[index].transform.position = ob_pos;
                            do_once = false;
                        }


                        if (Input.GetKey(KeyCode.W))
                        {
                            ObjectOnDesk[index].transform.Rotate(-Vector3.right * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.S))
                        {
                            ObjectOnDesk[index].transform.Rotate(Vector3.right * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.A))
                        {
                            ObjectOnDesk[index].transform.Rotate(Vector3.forward * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.D))
                        {
                            ObjectOnDesk[index].transform.Rotate(-Vector3.forward * turnspeed * Time.deltaTime);
                        }


                        ObjectOnDesk[index - 1].transform.position = objectpos[index - 1];
                        ObjectOnDesk[index - 1].transform.eulerAngles = objectrot[index - 1];
                    }

                    else if (index > 0 && index < ObjectOnDesk.Length - 1)
                    {
                        if (do_once)
                        {
                            ObjectOnDesk[index].transform.position = ob_pos;
                            do_once = false;
                        }

                        if (Input.GetKey(KeyCode.W))
                        {
                            ObjectOnDesk[index].transform.Rotate(-Vector3.right * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.S))
                        {
                            ObjectOnDesk[index].transform.Rotate(Vector3.right * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.A))
                        {
                            ObjectOnDesk[index].transform.Rotate(Vector3.forward * turnspeed * Time.deltaTime);
                        }
                        if (Input.GetKey(KeyCode.D))
                        {
                            ObjectOnDesk[index].transform.Rotate(-Vector3.forward * turnspeed * Time.deltaTime);
                        }

                        ObjectOnDesk[index - 1].transform.position = objectpos[index - 1];
                        ObjectOnDesk[index - 1].transform.eulerAngles = objectrot[index - 1];


                        ObjectOnDesk[index + 1].transform.position = objectpos[index + 1];
                        ObjectOnDesk[index + 1].transform.eulerAngles = objectrot[index + 1];
                    }
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
                    ObjectOnDesk[i].transform.position = objectpos[i];
                    ObjectOnDesk[i].transform.eulerAngles = objectrot[i];
                }
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            t.text = "查看桌面";
            butt_t.text = "E";
            butt_and_text_open();

            if (Input.GetKey(KeyCode.E) && E_use == false)    //沒按過E鍵才可以開啟桌面
            {
                //IfUserNeedNPC = false;  //玩家查看桌面了，所以不需要A來引導
                firstperson_object.gameObject.SetActive(false); //打開桌面後，角色就暫時看不到
                player_pos = firstperson_object.gameObject.transform.position;  //把角色按下E當下的位置記錄起來。
                butt_and_text_close();                         //把BUTTON跟文字關閉
                People_SwitchTo_Table();
                E_use = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
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

    // *******************************
    void Choose_paper1()
    {
        if (index == 0)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                see_image = true;
                LookAt = true;
                bg.SetActive(true);                         //讀內容的背景
                more_info.text = "\t\t\t前一天才和你一起打球，\n\n\t\t\t你說輸的要請飲料，但我還沒請你怎麼可以先走了...";
                more_info.gameObject.SetActive(true);       //道具的內容
                write_name.text = "曉銘";
                write_name.gameObject.SetActive(true);      //卡片署名的TEXT
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開便條紙";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                bg.SetActive(false);
                more_info.gameObject.SetActive(false);
                write_name.gameObject.SetActive(false);
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                LookAt = false;
                see_image = false;    //玩家才可以重新使用滾輪選取物件
            }
        }
    }

    void Choose_paper2()
    {
        if (index == 1)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                see_image = true;
                LookAt = true;
                bg.SetActive(true);                         //讀內容的背景
                more_info.text = "\t\t\t\t上天總是把善良的人先帶走\n\n\t\t\t\t你要快樂\n\n\t\t\t\t我們好想你\n\n\t\t\t\t你要在那邊過得開心\n\n\t\t\t\t謝謝你\n\n\t\t\t\t你怎麼先離開了..";
                more_info.gameObject.SetActive(true);       //道具的內容
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開便條紙";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                bg.SetActive(false);
                more_info.gameObject.SetActive(false);
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                LookAt = false;
                see_image = false;    //玩家才可以重新使用滾輪選取物件
            }
        }
    }

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
                see_image = true;
                LookAt = true;
                bg.SetActive(true);                         //讀內容的背景
                more_info.text = "\n\n\t\t\t\t\t\t\t\t\t曉鶴,對不起... ";
                more_info.gameObject.SetActive(true);       //道具的內容
                write_name.text = "吳旻蘭";
                write_name.gameObject.SetActive(true);      //卡片署名的TEXT
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開卡片";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                bg.SetActive(false);
                more_info.gameObject.SetActive(false);
                write_name.gameObject.SetActive(false);
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看卡片";
                LookAt = false;
                see_image=false;    //玩家才可以重新使用滾輪選取物件
            }
        }
    }

    void Choose_paper3()
    {
        if (index == 3)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                see_image = true;
                LookAt = true;
                bg.SetActive(true);                         //讀內容的背景
                more_info.text = "\t\t\t\t因為有你，我才有信心讀到那間大學，\n\n\t\t\t\t我都打算放棄了是你改變了我。\n\n\t\t\t\t你對大家都那麼好為什麼死神要找上你...";
                more_info.gameObject.SetActive(true);       //道具的內容
                write_name.text = "宇熙";
                write_name.gameObject.SetActive(true);      //卡片署名的TEXT
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開便條紙";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                bg.SetActive(false);
                more_info.gameObject.SetActive(false);
                write_name.gameObject.SetActive(false);
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                LookAt = false;
                see_image = false;    //玩家才可以重新使用滾輪選取物件
            }
        }
    }

    void Choose_paper4()
    {
        if (index == 4)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                see_image = true;
                LookAt = true;
                bg.SetActive(true);                         //讀內容的背景
                more_info.text = "\t\t\t\t第一次感覺到死亡原來那麼近，\n\n\t\t\t\t記得要在那邊快樂活著...";
                more_info.gameObject.SetActive(true);       //道具的內容
                write_name.text = "大寶上";
                write_name.gameObject.SetActive(true);      //卡片署名的TEXT
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開便條紙";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                bg.SetActive(false);
                more_info.gameObject.SetActive(false);
                write_name.gameObject.SetActive(false);
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                LookAt = false;
                see_image = false;    //玩家才可以重新使用滾輪選取物件
            }
        }
    }

    void Choose_paper5()
    {
        if (index == 5)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                see_image = true;
                LookAt = true;
                bg.SetActive(true);                         //讀內容的背景
                more_info.text = "\n\n\t\t\t\t\t\t\t\t\t曉鶴，一路好走";
                more_info.gameObject.SetActive(true);       //道具的內容
                write_name.text = "筱涵";
                write_name.gameObject.SetActive(true);      //卡片署名的TEXT
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開便條紙";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                bg.SetActive(false);
                more_info.gameObject.SetActive(false);
                write_name.gameObject.SetActive(false);
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看便條紙";
                LookAt = false;
                see_image = false;    //玩家才可以重新使用滾輪選取物件
            }
        }
    }
    void Choose_flower()
    {
        if (index == 6)
        {
            if (LookAt == false)
            {
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看花瓶";
                butt_and_text_open2();
            }
            if (Input.GetMouseButtonDown(0))
            {
                see_image = true;
                LookAt = true;
                bg.SetActive(true);                         //讀內容的背景
                more_info.text = "天堂鳥\n\n鶴望蘭（學名：Strelitzia reginae），又稱天堂鳥或極樂鳥花，\n為鶴望蘭科鶴望蘭屬物種，\n是原產南非的一種單子葉植物。\n\n\n天堂鳥的花語:\n能飛向天堂的鳥，能把各種情感、思戀帶到天堂，\n為自由與幸福的化身。";
                more_info.gameObject.SetActive(true);       //道具的內容
                butt_t2.text = "滑鼠\n右鍵";
                t2.text = "離開花瓶";
            }
            if (Input.GetMouseButtonDown(1) && LookAt == true)
            {
                bg.SetActive(false);
                more_info.gameObject.SetActive(false);
                write_name.gameObject.SetActive(false);
                butt_t2.text = "滑鼠\n左鍵";
                t2.text = "查看花瓶";
                LookAt = false;
                see_image = false;    //玩家才可以重新使用滾輪選取物件
            }
        }
     }

    //IEnumerator NPC_WaitFor30Sec()
    //{
    //    yield return new WaitForSeconds(30);
    //    if (IfUserNeedNPC)
    //    {
    //        //觸發A同學劇情
    //        Amove = true;
    //        GameObject.Find("同學A").GetComponent<movetoplayer>().enabled = true;
    //        GameObject.Find("FirstPerson").GetComponent<controlpeople>().enabled = false;
    //    }

    //}
}

