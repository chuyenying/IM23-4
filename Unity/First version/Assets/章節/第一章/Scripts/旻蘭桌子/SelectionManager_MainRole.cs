using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager_MainRole : MonoBehaviour
{
    public static string name;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private AudioSource selectob_music;
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private GameObject bg, focus_info, focus_table, F_button, left_click, right_click;
    [SerializeField] private Animator SelectOB_anim;
    private Transform _selection;
    public static bool read_info = false;
    public static bool take_phone=false, take_candy=true;
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        bg.SetActive(false);
        focus_info.SetActive(false);
        SelectOB_anim.gameObject.SetActive(false);
        left_click.SetActive(false);
        right_click.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            //selectionRenderer.material = defaultMaterial;
            //_selection.gameObject.layer = LayerMask.NameToLayer("Default");
            _selection = null;  //沒抓到物件的時候就會一直是null
        }
        try { ray = Camera.main.ScreenPointToRay(Input.mousePosition); }
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
                    //selectionRenderer.material = highlightMaterial; //把她高光
                    //gb.layer = LayerMask.NameToLayer("highlight");     // 使用shader用layer控制
                }
                if (Input.GetMouseButtonUp(0) && ! read_info)
                {
                    if (gb.name == "手機")
                    {
                        take_phone = true;
                        Destroy(gb);
                    }
                    else if(gb.name =="candy")
                    {
                        take_candy = true;
                        Destroy(gb);
                    }
                    selectob_music.Play();                  //播放音效
                    read_info = true;
                    focus_info.SetActive(true);
                    focus_table.SetActive(false);
                    bg.SetActive(true);
                    left_click.SetActive(false);
                    right_click.SetActive(true);
                    F_button.SetActive(false);
                    SelectOB_anim.gameObject.SetActive(true);
                }
                _selection = selection;
            }
        }
        if (Input.GetMouseButtonUp(1) && read_info)
        {
            read_info = false;
            focus_info.SetActive(false);
            focus_table.SetActive(true);
            bg.SetActive(false);
            left_click.SetActive(true);
            right_click.SetActive(false);
            F_button.SetActive(true);
            SelectOB_anim.gameObject.SetActive(false);
        }
    }
}
