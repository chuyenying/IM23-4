using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControll : MonoBehaviour
{
    public GameObject Bullet;
    public static int HeartNum = 3;
    public GameObject Heart01;
    public GameObject Heart02;
    public GameObject Heart03;
    public GameObject canvasPrefab;

    void Update()
    {
        //上鍵或W
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))

        {
            this.transform.position += new Vector3(0, 0.1f, 0);
        }

        //下鍵或S
        if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
        }

        //空白鍵或A
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //在飛機的位置生成Bullet物件，Bullet物件也就是子彈物件
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
    }

    //當玩家碰撞到其他物體時執行
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //如果碰到雲，扣一顆愛心
        if (collision.name == "cloud(Clone)")
        {
            Destroy(collision.gameObject);
            //血量-1
            HeartNum = HeartNum - 1;
            if (HeartNum == 2) //還有兩顆心
            {
                Heart01.SetActive(false);
            }
            else if (HeartNum == 1) //還有一顆心
            {
                Heart02.SetActive(false);
            }
            else if (HeartNum <= 0) //沒有心
            {
                Heart03.SetActive(false);
                Time.timeScale = 0f;
                Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);

            }

        }

    }
}
