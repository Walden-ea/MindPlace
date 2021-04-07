using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Colors {
    White,
    Red,
    Yellow,
    Green
    }



[CreateAssetMenu(fileName = "New PageData", menuName = "Notebook Page Data", order = 51)]
public class PageData : ScriptableObject
{
    public Colors pageColor;
    public string pageText;
    

    string key;


    
    

    private void OnValidate() {
        if (key == "")
        {
        key = name;
        }

        string jsonData = JsonUtility.ToJson(this,true);
        PlayerPrefs.SetString(key,jsonData);
        PlayerPrefs.Save();
    }


    private void OnDisable() {
                if (key == "")
        {
        key = name;
        }

        string jsonData = JsonUtility.ToJson(this,true);
        PlayerPrefs.SetString(key,jsonData);
        PlayerPrefs.Save();
    }

}
