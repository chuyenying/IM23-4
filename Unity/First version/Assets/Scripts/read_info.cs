using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class read_info : MonoBehaviour
{
    [SerializeField] private GameObject paper1, paper2, paper3, paper4, paper5, card,bg;
    [SerializeField] private Text info;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (SelectionManager.name == "便條紙第1個內容")
        {
            paper1.SetActive(true);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "便條紙第2個內容")
        {
            info.gameObject.SetActive(true);
            info.text = "第一次感覺到死亡原來那麼近 \n記得要在那邊快樂活著... \n\t\t\t\t\t\t\t大寶";
            paper1.SetActive(false);
            paper2.SetActive(true);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "便條紙第3個內容")
        {
            info.gameObject.SetActive(true);
            info.text = "曉鶴，一路走好。   \n\t\t\t\t\t\t\t筱涵";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(true);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "便條紙第4個內容")
        {
            info.gameObject.SetActive(true);
            info.text = "因為有你，我才有信心讀到那間大學\n我都打算放棄了是你改變了我。\n你對大家都那麼好為什麼死神要找上你...   \n\t\t\t\t\t\t\t宇熙";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(true);
            paper5.SetActive(false);
            card.SetActive(false);
        }
        else if (SelectionManager.name == "便條紙第5個內容")
        {
            info.gameObject.SetActive(true);
            info.text = "「上天總是把最善良的人帶走，你要快樂」\n「我們好想你」\n「你要在那邊過得開心」\n「謝謝你」\n「你怎麼先離開了」";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(true);
            card.SetActive(false);

        }
        else if (SelectionManager.name == "卡片")
        {
            info.gameObject.SetActive(true);
            info.text = "曉鶴， 對不起...\n你會在那裡實現你的夢想的\n下輩子我們還要當很好的朋友";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            card.SetActive(true);
        }
    }
}
