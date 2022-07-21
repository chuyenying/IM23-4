using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //雲向左
        this.transform.position += new Vector3(0.1f,0 , 0);
        if(PlaneControll.HeartNum == 0)
        {
            Destroy(this.gameObject);
        }
    }

    //碰到東西
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //被子彈打到
        if(collision.name == "Bullet(Clone)")
        {
            Score.score = Score.score + 1;
            CloudDisappear();
        }
        //碰到左邊牆壁
        else if (collision.name == "wall2")
        {
            //雲消失
            Destroy(this.gameObject);
        }
    }

    //雲消失
    public void CloudDisappear()
    {
        //雲消失
        Destroy(this.gameObject);
    }
}
