using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimFatherKidOb : MonoBehaviour
{
    [SerializeField] private GameObject BAG;
    [SerializeField] private GameObject LeftHand;
    [SerializeField] private GameObject RightArm;
    public void HandTakesBag()
    {
        BAG.transform.SetParent(LeftHand.transform);
        BAG.transform.localPosition = new Vector3(-0.625f, 0.449999988f, 0.270000011f);
        BAG.transform.localEulerAngles = new Vector3(69.5283813f, 56.3868713f, 329.097382f);
    }

    public void ReleaseBagAndTurnToRightArm()
    {
        BAG.transform.SetParent(null);
        BAG.transform.SetParent(RightArm.transform);
        BAG.transform.localPosition = new Vector3(0.27700001f, 0.623000026f, -0.225999996f);
        BAG.transform.localEulerAngles = new Vector3(10.3062925f, 320.33667f, 203.333008f);
    }
}
