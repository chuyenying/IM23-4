using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCreater : MonoBehaviour
{
    public GameObject cloud;
    public GameObject Plane;
    // Start is called before the first frame update
    void Start()
    {
        //每秒執行一次造雲程式
        InvokeRepeating("CreatCloud", 1, 1);
    }

    public void CreatCloud()
    {
        int CloudNum;
        //隨機幾朵雲(0-2朵)
        CloudNum = Random.Range(0, 3);

        //開始生成
        for(int i = 0 ; i < CloudNum ; i++)
        {
            //宣告生成Y座標，設定隨機13到83間
            float y;
            y = Random.Range(13, 83);
            Instantiate(cloud, new Vector3(-9, y, Plane.transform.position.z), Quaternion.identity);
        }
    }

}
