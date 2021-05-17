using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveSystem
{
    public static readonly string SAVE_FOLDER = Application.dataPath + "/saves/";

    public static void Init()
    {
        Directory.CreateDirectory(SAVE_FOLDER);
        
    }

    public static void Save(string saveString, string saveFileName)
    {
        Debug.Log(saveString+" saveSystem");
        File.WriteAllText(SAVE_FOLDER + saveFileName,saveString);
         Debug.Log(SAVE_FOLDER);
    }

    public static string Load(string saveFileName)
    {
        string savePath = SAVE_FOLDER +"/"+saveFileName;
        if (File.Exists(savePath))
        {
            string saveString = File.ReadAllText(savePath);
            return saveString;
        }
        else 
        {
            return null;
        }

        
    }
}
