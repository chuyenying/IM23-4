using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class SaveLoadSystem2 : MonoBehaviour
{
    [SerializeField] private GameObject FirstPerson;
    [SerializeField] private GameObject cellphone_LockPage, cellphone_MainPage;
    private void Awake()
    {
        Automatically_LoadScene();
    }
    public void Save()
    {
        PixelCrushers.SaveSystem.SaveToSlot(1);     // Dialogue System 的存檔

        PlayerData data = new PlayerData();

        data.PlayerPosition = FirstPerson.transform.position;
        data.Take_Cellphone = SelectionManager_MainRole.take_phone;

        if (PlayerPrefs.GetInt("Cellphone_Unlock") == 1)
        {
            data.Cellphone_Unlock = true;
        }
        else
        {
            data.Cellphone_Unlock = false;
        }

        data.importantOb_count = Selection_ob.ob_count;

        data.Take_MainRoleBook = SelectionManager_MainRole.take_book;
        data.Take_Omori = SelectionManager_MainRole.take_omori;
        data.Take_Candy = SelectionManager_MainRole.take_candy;

        data.Take_BrotherBook = SelectionManager_bro.take_book;

        data.Take_Notebook = Selection_ob.take_notebook;
        data.Take_Medicine = Selection_ob.take_medicine;
        data.Take_Computer = Selection_ob.take_computer;
        data.Take_Flower = Selection_ob.take_flower;
        data.Take_Bear = Selection_ob.take_bear;

        Scene scene = SceneManager.GetActiveScene();
        data.Scene_Name = scene.name;

        string json_data = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/PlayerData.sav", json_data);

    }

    public void Automatically_LoadScene()
    {
        if (PlayerPrefs.GetInt("Automatically_LoadScene") == 1)
        {
            PixelCrushers.SaveSystem.LoadFromSlot(1);   // DialogueSystem 讀檔案

            string json_data = File.ReadAllText(Application.dataPath + "/PlayerData.sav");

            PlayerData data = JsonUtility.FromJson<PlayerData>(json_data);

            FirstPerson.transform.position = data.PlayerPosition;
            cellphone_LockPage.SetActive(!data.Cellphone_Unlock);
            cellphone_MainPage.SetActive(data.Cellphone_Unlock);


            Selection_ob.ob_count = data.importantOb_count;

            SelectionManager_MainRole.take_book = data.Take_MainRoleBook;
            SelectionManager_MainRole.take_omori = data.Take_Omori;


            SelectionManager_MainRole.take_candy = data.Take_Candy;

            SelectionManager_bro.take_book = data.Take_BrotherBook;

            Selection_ob.take_notebook = data.Take_Notebook;
            Selection_ob.take_medicine = data.Take_Medicine;
            Selection_ob.take_computer = data.Take_Computer;
            Selection_ob.take_flower = data.Take_Flower;
            Selection_ob.take_bear = data.Take_Bear;

        }
        PlayerPrefs.SetInt("Automatically_LoadScene", 0);   //下次不會自動load。
    }

    public void ChangeScene()
    {
        string json_data = File.ReadAllText(Application.dataPath + "/PlayerData.sav");
        PlayerData data = JsonUtility.FromJson<PlayerData>(json_data);
        PlayerPrefs.SetInt("Automatically_LoadScene", 1);
        SceneManager.LoadScene(data.Scene_Name);
    }
}
