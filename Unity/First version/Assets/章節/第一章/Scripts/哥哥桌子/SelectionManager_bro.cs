using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectionManager_bro : MonoBehaviour
{
    public static string name;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private AudioSource selectob_music;
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private GameObject bg,focus_info,focus_table,F_button, left_click, right_click;
    [SerializeField] private Animator SelectOB_anim;
    [SerializeField] private UnityEvent ChangeFlower;
    private Transform _selection;
    private bool read_info = false;
    public static bool take_book = false;
    private Ray ray;
    private bool Do_Once_ChangeFlower = true;
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
            _selection = null;  //�S��쪫�󪺮ɭԴN�|�@���Onull
        }
        try { ray = Camera.main.ScreenPointToRay(Input.mousePosition); }
        catch
        {
            //do nothing�A���n������ĵ�i�N�n
        }
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))   //���I����|�^��true,�S���hfalse
        {
            var selection = hit.transform;      //��g�u���g������
            var selectionRenderer = selection.GetComponent<Renderer>(); //��Q���g�����骺render
            var gb = selection.gameObject;
            if (selection.CompareTag(selectableTag))
            {
                if (selectionRenderer != null)
                {
                    name = gb.name;   
                    //selectionRenderer.material = highlightMaterial; //��o����
                    //gb.layer = LayerMask.NameToLayer("highlight");     // �ϥ�shader��layer����
                    if (Input.GetMouseButtonUp(0) && !read_info)
                    {
                        if (name == "�d��" && !take_book)
                        {
                            take_book = true;
                            int PlayerPrefscore = PlayerPrefs.GetInt("score2");
                            PlayerPrefscore += 3;
                            PlayerPrefs.SetInt("score2", PlayerPrefscore);
                            Debug.Log($"score2: {PlayerPrefs.GetInt("score2")}");
                        }
                        else if (name == "��~" && Do_Once_ChangeFlower)
                        {
                            ChangeFlower.Invoke();
                            name = "";
                            Do_Once_ChangeFlower = false;
                        }
                        selectob_music.Play();                  //���񭵮�
                        SelectOB_anim.gameObject.SetActive(true);    //����ʵe
                        read_info = true;                            
                        F_button.SetActive(false);
                        bg.SetActive(true);
                        focus_info.SetActive(true);
                        focus_table.SetActive(false);
                        left_click.SetActive(false);
                        right_click.SetActive(true);
                    }
                }
                _selection = selection;
            }
            
        }
        if (Input.GetMouseButton(1) && read_info)
        {
            read_info = false;
            SelectOB_anim.gameObject.SetActive(false);
            left_click.SetActive(true);
            right_click.SetActive(false);
        }
    }
}
