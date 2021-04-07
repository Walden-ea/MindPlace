using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DownTimer : MonoBehaviour
{
    [SerializeField] float startTimer = 0f;
    [SerializeField] TextMeshProUGUI timerText01;

    [SerializeField] Text rT;

   [SerializeField] float timer01 = 0f;
    public bool start = false;
    IEnumerator timer;

    void Start()
    {
        
    }

    public IEnumerator Timer01()
    {
        Debug.Log("я начался");
        timer01 = startTimer;
        while (timer01 > 0)
        {     
            timer01 -= Time.deltaTime;
            FormatText01(); 
            
            yield return null;
        }
        start = false;       
    }
    public void FormatText01()
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
        timer01 = startTimer;

        if(!start)
        {    
            rT.text = "Начать сначала";
            timer = Timer01();

            StartCoroutine(timer);
            start = true;
        }
        else
        {
            StopCoroutine(timer);
            StartCoroutine(timer);
        }

    }
}
