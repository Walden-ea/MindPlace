using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class buttons : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
     public void Restart_button()
    {
       // SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
       
    }

    // Update is called once per frame
     public void pause_button()
    { 
        //text.text = "продолжить";
        if (Time.timeScale != 0)
        { 
            Time.timeScale = 0;
            //text.text = "продолжить";
        }
        else Time.timeScale = 1;
    }
}
