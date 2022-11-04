using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerToChildOb : MonoBehaviour
{
    [SerializeField] private GameObject HeavenFlower , RightHand , SunFlower , LeftHand;

    public void LetHeavenFlowerBeChildOb()  //讓天堂鳥變成右手的子物件，這樣花就可以平順的跟著右手移動
    {
        HeavenFlower.gameObject.transform.SetParent(RightHand.transform);
    }

    public void FirstSetHeavenFlower()  //因為試著播放Animation會直接讓天堂鳥改變父子物件的關係，然後位子又要重調整....
    {
        HeavenFlower.gameObject.transform.position = new Vector3(-0.864000022f, 3.95900011f, 23.0760002f);
        HeavenFlower.gameObject.transform.rotation = new Quaternion(0.382250458f, -0.505371988f, -0.730798364f, -0.253805995f);
        HeavenFlower.gameObject.transform.SetParent(null);
    }

    public void CancelSunFlowerChildOb()    //為了這個動畫播完結束後，天堂鳥仍然可以留在桌上。
    {
        SunFlower.gameObject.transform.SetParent(null);
    }
}
