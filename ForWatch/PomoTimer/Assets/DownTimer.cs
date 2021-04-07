using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DownTimer : MonoBehaviour
{
    [SerializeField] float startTimer = 0f;
    [SerializeField] TextMeshProUGUI timerText01;

    float timer01 = 0f;
    bool start = false;

    void Start()
    {
       //start = false;
       // StopCoroutine(Timer01());
        StartCoroutine(Timer01());
    }

    private IEnumerator Timer01()
    {
        timer01 = startTimer;
        while (timer01 > 0)
        {     
            timer01 -= Time.deltaTime;
            FormatText01(); 
            yield return null;
        }
        
    }
    private void FormatText01()
    {
        int minutes = (int)(timer01 / 60) % 60;
        int seconds = (int)(timer01 % 60);


        timerText01.text = "";
        if ((minutes > 0) && (minutes < 10)) { timerText01.text += "0" + minutes + " : " ; }
        if ((minutes == 0) && (seconds >= 10)) { timerText01.text += "00 : " + seconds ; }
        if ((minutes == 0) && (seconds < 10)) { timerText01.text += "00 : " + "0" + seconds ; }
        if (minutes >= 10) { timerText01.text += minutes + " : " ; }
        if ((minutes != 0) && (seconds >= 10)) { timerText01.text += seconds; }
        if ((seconds >= 0) && (seconds < 10) && (minutes != 0)) { timerText01.text += "0" + seconds; }
    }

 public void Restarting_button()
    {
       // SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
         
         StopCoroutine(Timer01());
         StartCoroutine(Timer01());
    }
}
