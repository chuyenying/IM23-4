using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerToChildOb : MonoBehaviour
{
    [SerializeField] private GameObject HeavenFlower , RightHand , SunFlower , LeftHand;

    public void LetHeavenFlowerBeChildOb()  //���Ѱ��ܦ��k�⪺�l����A�o�˪�N�i�H��������ۥk�Ⲿ��
    {
        HeavenFlower.gameObject.transform.SetParent(RightHand.transform);
    }

    public void FirstSetHeavenFlower()  //�]���յۼ���Animation�|�������Ѱ󳾧��ܤ��l�������Y�A�M���l�S�n���վ�....
    {
        HeavenFlower.gameObject.transform.position = new Vector3(-0.864000022f, 3.95900011f, 23.0760002f);
        HeavenFlower.gameObject.transform.rotation = new Quaternion(0.382250458f, -0.505371988f, -0.730798364f, -0.253805995f);
        HeavenFlower.gameObject.transform.SetParent(null);
    }

    public void CancelSunFlowerChildOb()    //���F�o�Ӱʵe����������A�Ѱ󳾤��M�i�H�d�b��W�C
    {
        SunFlower.gameObject.transform.SetParent(null);
    }
}
