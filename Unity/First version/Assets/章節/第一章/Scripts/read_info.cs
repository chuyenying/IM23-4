using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class read_info : MonoBehaviour
{
    [SerializeField] private GameObject paper1, paper2, paper3, paper4, paper5,paper6,paper7, card,bg,flower;
    [SerializeField] private GameObject Omamori, Chemical, candy,phone; //Omamori�O�s�u
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
        if (SelectionManager_bro.name == "�K����1")
        {
            info.text = "�e�Ѥ~�M�A�@�_���y \n�A���骺�n�ж���...\n�����٨S�ЧA���i�H�����F";
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
        else if (SelectionManager_bro.name == "�K����2")
        {
            info.gameObject.SetActive(true);
            info.text = "�Ĥ@���Pı�즺�`��Ө���� \n�O�o�n�b����ּ֬���... \n\t\t\t\t\t\t\t�j�_";
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
        else if (SelectionManager_bro.name == "�K����3")
        {
            info.gameObject.SetActive(true);
            info.text = "���b�A�@�����n�C   \n\t\t\t\t\t\t\t�N�[";
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
        else if (SelectionManager_bro.name == "�K����4")
        {
            info.gameObject.SetActive(true);
            info.text = "�]�����A�A�ڤ~���H��Ū�쨺���j��\n�ڳ�������F�O�A���ܤF�ڡC\n�A��j�a������n�����򦺯��n��W�A...   \n\t\t\t\t\t\t\t�t��";
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
        else if (SelectionManager_bro.name == "�K����5")
        {
            info.gameObject.SetActive(true);
            info.text = "�u�W���`�O��̵��}���H�a���A�A�n�ּ֡v\n�u�ڭ̦n�Q�A�v\n�u�A�n�b����L�o�}�ߡv\n�u���§A�v\n�u�A�������}�F�v";
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
        else if (SelectionManager_bro.name == "�K����6")
        {
            info.gameObject.SetActive(true);
            info.text = "�ګܳ��w�b�H�s���o�����A\n ���A�]�S�����|�M�A���F\n";
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
        else if (SelectionManager_bro.name == "�K����7")
        {
            info.gameObject.SetActive(true);
            info.text = "�Ʊ�U���l���A\n�i�H�u���ܧּ�";
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
        else if (SelectionManager_bro.name == "�d��")
        {
            info.gameObject.SetActive(true);
            info.text = "���b�A �藍�_...\n�A�|�b���̹�{�A���ڷQ��\n�U���l�ڭ��٭n��ܦn���B��";
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
        else if (SelectionManager_bro.name == "��~")
        {
            info.gameObject.SetActive(true);
            info.text = "�ݰ_�ӬO�Ѱ󳾡A��y�O�u�ӥͩ��֡v\n�S�٬��b�����A���b�������b�����ݪ���\n�O�첣�n�D���@�س�l���Ӫ��C\n���̾ǦW�O�������^����v�T�@���m�L���S�ӦZ�Ө���";
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
        else if (SelectionManager_MainRole.name == "�s�u")
        {
            info.gameObject.SetActive(true);
            info.text = "�O���b�h�饻�^�Ӱe�������~";
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
        else if (SelectionManager_MainRole.name == "�ƾ�")
        {
            info.gameObject.SetActive(true);
            info.text = "�̤��i�R�����...";
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
        else if (SelectionManager_MainRole.name == "���")
        {
            info.gameObject.SetActive(true);
            info.text = "��Tab�i�}�Ҥ���C";
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
            info.text = "����f��������̦n�Y�F�C";
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
