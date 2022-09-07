using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public Vector3 PlayerPosition ; //角色座標

    //[通用]
    public bool Take_Cellphone , Cellphone_Unlock;
    //Take_Cellphone 是否有拿手機(SelectionManager_MainRole (Script))
    //Cellphone_Unlock手機是否解鎖(PlayerPref.SetInt: "Cellphone_Unlock")。

    //[第一章主角桌子]
    public bool Take_MainRoleBook , Take_Omori , Take_Candy;
    //直接抓SelectionManager_MainRole (Script)的值

    //[第一章哥哥桌子]
    public bool Take_BrotherBook;
    //抓SelectionManager_bro(Script)的take_book

    //[第二章重要物品]
    public bool Take_Notebook , Take_Medicine, Take_Computer, Take_Flower , Take_Bear;
    //Selection_ob (Script)


    //[第二章重要物品數量]
    public int importantOb_count;

    public string Scene_Name;


}
