using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherKid_GrabCellphoneAndBag : MonoBehaviour
{
    [SerializeField] GameObject RightHand, Cellphone , LeftHand , Bag;
    public void GrabCellphone()
    {
        Cellphone.gameObject.transform.SetParent(RightHand.transform);

    }

    public void GrabBag()
    {
        Bag.gameObject.transform.SetParent(LeftHand.transform);
        Bag.transform.localPosition = new Vector3(0, 0.301999986f, 0.524999976f);
        Bag.transform.localEulerAngles = new Vector3(301.03952f, 180, 180);
    }

}
