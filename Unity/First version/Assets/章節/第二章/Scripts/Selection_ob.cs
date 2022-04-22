using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class Selection_ob : MonoBehaviour
{
    public static string name;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private AudioSource selectob_music;
    private Transform _selection;
    private Ray ray;
    
    /// <summary>
    /// list裡面代表:
    /// [0] 日記本
    /// [1] 藥袋
    /// [2] 筆電
    /// [3] 天堂鳥
    /// [4] 小熊玩偶
    /// 
    /// 值代表:
    /// 0代表沒點過
    /// 1代表點過
    /// </summary>
    private List<int> important_ob = new List<int> { 0, 0, 0, 0, 0};
    public int ob_count = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            _selection = null;  //沒抓到物件的時候就會一直是null
        }
        try { ray = Camera.main.ScreenPointToRay(Input.mousePosition); }    //只有tag是MainCamera的相射線
        catch
        {
            //do nothing，不要跳紅色警告就好
        }
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))   //有碰撞到會回傳true,沒有則false
        {
            var selection = hit.transform;      //抓射線直射的物體
            var selectionRenderer = selection.GetComponent<Renderer>(); //抓被直射的物體的render
            var gb = selection.gameObject;
            if (selection.CompareTag(selectableTag))
            {
                if (selectionRenderer != null)
                {
                    name = gb.name;
                    if (Input.GetMouseButtonUp(0))
                    {
                        Debug.Log(name);
                        if (name == "藥袋")
                        {
                            important_ob[1] = 1;
                            ob_count++;
                        }                        
                        else if (name == "小熊")
                        {
                            important_ob[4] = 1;
                            ob_count++;
                        }
                        
                        selectob_music.Play();                  //播放音效
                    }
                }
                _selection = selection;
            }

        }
        /*
        if (Input.GetMouseButton(1) && read_info)
        {
            read_info = false;
        }
        */
    }
}
