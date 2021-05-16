using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DownTimer : MonoBehaviour
{
    [SerializeField] float startTimer = 0f;
    [SerializeField] Slider slider01;
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
            slider01.value = timer01 / startTimer;
            FormatText01();
            yield return null;
        }
        while (timer01 > 0);
    }
    private void FormatText01()
    {
        int days = (int)(timer01 / 86400) % 365;
        int hours = (int)(timer01 / 3600) % 24;
        int minutes = (int)(timer01 / 60) % 60;
        int seconds = (int)(timer01 % 60);

        timerText01.text = "";
        if (days > 0) { timerText01.text += days + "д"; }
        if (hours > 0) { timerText01.text += hours + "ч"; }
        if (minutes > 0) { timerText01.text += minutes + "м"; }
        if (seconds > 0) { timerText01.text += seconds + "с"; }
    }
}
