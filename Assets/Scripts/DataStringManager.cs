using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class DataStringManager : MonoBehaviour
{
    public UnityEngine.UI.Text text;
   string dataString;

    bool setPageData()
    {
        //var text = GetComponent<UnityEngine.UI.Text>();
        if (text!=null)
        {
            dataString = text.text;
            return true;
        }
        return false;
    }

    private void OnDisable() {
        
        setPageData();
        Debug.Log(dataString);
        BinaryFormatter bf = new BinaryFormatter(); 
        FileStream file = File.Create(Application.persistentDataPath + $"/{name}Save.dat"); 

        bf.Serialize(file, dataString);
        file.Close();

    }

    private void Awake() {      
        if (File.Exists(Application.persistentDataPath  + $"/{name}Save.dat"))
            { 
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + $"/{name}Save.dat", FileMode.Open);
            dataString = (string)bf.Deserialize(file);
            file.Close();
            text.text = dataString;
            
    }
    else {
        dataString = "пусто";
        text.text = "пусто";
    }
    Debug.Log(text.text);
    }

}
