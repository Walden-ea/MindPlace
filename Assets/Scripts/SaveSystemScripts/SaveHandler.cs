using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveHandler : MonoBehaviour {
    private static string userInput;
    public InputField inputField;

    public void recieveAndSaveStringInput(string input)
    {
        userInput = input;
        Debug.Log(userInput);
        Save();
    
    }
    private void Awake() {
        SaveSystem.Init();
        Debug.Log(userInput);
        Load();
    
    }

    private void Save() {
        // Save

        Debug.Log(userInput +"saveHandler");

         SaveObject saveObject = new SaveObject{
             userInputSave = userInput
         };


        string json = JsonUtility.ToJson(saveObject);
        Debug.Log(json +"saveHJson");
        SaveSystem.Save(json,"butt.txt");

        Debug.Log("Saved!");
    }

    private void Load() {
        // Load
        string saveString = SaveSystem.Load("butt.txt");
        if (saveString != null) 
        {
           Debug.Log("Loaded: " + saveString);
        

            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            userInput = saveObject.userInputSave;
            if (userInput != null)
            {
                inputField.text = userInput;
            }
            //Debug.Log(userInput);

        }
         else
         {
            Debug.Log("No save");
        }
    }


    private class SaveObject {
        public string userInputSave;
    }
}
