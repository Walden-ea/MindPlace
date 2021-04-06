using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DownTimerPom : MonoBehaviour
{
    [SerializeField] float startTimer = 0f;
    [SerializeField] TextMeshProUGUI timerText01;

    float timer01 = 0f;
    void Start()
    {
        StartCoroutine(Timer01());
    }

    private IEnumerator Timer01()
    {
        timer01 = startTimer;
        do
        {
            timer01 -= Time.deltaTime;
            FormatText01();
            yield return null;
        }
        while (timer01 > 0);
    }
    private void FormatText01()
    {
        int minutes = (int)(timer01 / 60) % 60;
        int seconds = (int)(timer01 % 60);


        timerText01.text = "";
     
        if (minutes > 0) { timerText01.text += minutes + " : "; }
        if (seconds >= 10) { timerText01.text += seconds; }
        if ((seconds >= 0) && (seconds < 10)) { timerText01.text += "0" + seconds; }
    }
}
