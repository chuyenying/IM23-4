using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class read_info : MonoBehaviour
{
    [SerializeField] private GameObject paper1, paper2, paper3, paper4, paper5,paper6,paper7, card,bg,flower;
    [SerializeField] private GameObject Omamori, Chemical, candy,phone; //Omamori是御守
    [SerializeField] private Text info;
    // Start is called before the first frame update
    void Start()
    {
        paper1.SetActive(false);
        paper2.SetActive(false);
        paper3.SetActive(false);
        paper4.SetActive(false);
        paper5.SetActive(false);
        paper6.SetActive(false);
        paper7.SetActive(false);
        card.SetActive(false);
        flower.SetActive(false);
        Omamori.SetActive(false);
        Chemical.SetActive(false);
        candy.SetActive(false);
        phone.SetActive(false);
    }

    private void Update()
    {
        if (SelectionManager_bro.name == "便條紙1")
        {
            info.text = "前天才和你一起打球 \n你說輸的要請飲料...\n但我還沒請你怎麼可以先走了";
            paper1.SetActive(true);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "便條紙2")
        {
            info.gameObject.SetActive(true);
            info.text = "第一次感覺到死亡原來那麼近 \n記得要在那邊快樂活著... \n\t\t\t\t\t\t\t大寶";
            paper1.SetActive(false);
            paper2.SetActive(true);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "便條紙3")
        {
            info.gameObject.SetActive(true);
            info.text = "曉鶴，一路走好。   \n\t\t\t\t\t\t\t筱涵";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(true);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "便條紙4")
        {
            info.gameObject.SetActive(true);
            info.text = "因為有你，我才有信心讀到那間大學\n我都打算放棄了是你改變了我。\n你對大家都那麼好為什麼死神要找上你...   \n\t\t\t\t\t\t\t宇熙";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(true);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "便條紙5")
        {
            info.gameObject.SetActive(true);
            info.text = "「上天總是把最善良的人帶走，你要快樂」\n「我們好想你」\n「你要在那邊過得開心」\n「謝謝你」\n「你怎麼先離開了」";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(true);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "便條紙6")
        {
            info.gameObject.SetActive(true);
            info.text = "我很喜歡在人群中發光的你\n 但再也沒有機會和你說了\n";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper6.SetActive(true);
            paper7.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "便條紙7")
        {
            info.gameObject.SetActive(true);
            info.text = "希望下輩子的你\n可以真的很快樂";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper6.SetActive(false);
            paper7.SetActive(true);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "卡片")
        {
            info.gameObject.SetActive(true);
            info.text = "曉鶴， 對不起...\n你會在那裡實現你的夢想的\n下輩子我們還要當很好的朋友";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(true);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_bro.name == "花瓶")
        {
            info.gameObject.SetActive(true);
            info.text = "看起來是天堂鳥，花語是「來生幸福」\n又稱為鶴望蘭，為鶴望蘭科鶴望蘭屬物種\n是原產南非的一種單子葉植物。\n它們學名是為紀念英王喬治三世王妃夏洛特皇后而取的";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(true);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_MainRole.name == "御守")
        {
            info.gameObject.SetActive(true);
            info.text = "是曉鶴去日本回來送的紀念品";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(true);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_MainRole.name == "化學")
        {
            info.gameObject.SetActive(true);
            info.text = "最不可愛的科目...";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(true);
            candy.SetActive(false);
            phone.SetActive(false);
        }
        else if (SelectionManager_MainRole.name == "手機")
        {
            info.gameObject.SetActive(true);
            info.text = "按Tab可開啟手機。";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(false);
            phone.SetActive(true);
        }
        else if (SelectionManager_MainRole.name == "candy")
        {
            info.gameObject.SetActive(true);
            info.text = "葡萄口味的哈啾最好吃了。";
            paper1.SetActive(false);
            paper2.SetActive(false);
            paper3.SetActive(false);
            paper4.SetActive(false);
            paper5.SetActive(false);
            paper7.SetActive(false);
            paper6.SetActive(false);
            card.SetActive(false);
            flower.SetActive(false);
            Omamori.SetActive(false);
            Chemical.SetActive(false);
            candy.SetActive(true);
            phone.SetActive(false);
        }
    }
}
