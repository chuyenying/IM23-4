using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //脫離父物件

        this.transform.parent = null;

        //每一偵子彈向左飛行

        this.transform.position += new Vector3(-0.1f, 0, 0);
    }
    //當子彈碰撞到其他物體時會執行

    private void OnTriggerEnter2D(Collider2D collision)

    {

        //如果碰到左邊牆壁，摧毀子彈

        if (collision.name == "wall1")

            Destroy(this.gameObject);

    }
}
