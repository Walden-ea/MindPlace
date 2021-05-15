using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class buttons : MonoBehaviour
{
    public Text pauseText;
    // Start is called before the first frame update

    // Update is called once per frame
     public void pause_button()
    { 
        if (Time.timeScale != 0)
        { 
            Time.timeScale = 0;
            pauseText.text = "продолжить";
        }
        else
        {
            Time.timeScale = 1;
            pauseText.text = "пауза";
        } 
        
    }
}
