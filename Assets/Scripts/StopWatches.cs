using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class StopWatches : MonoBehaviour
{

    float timer;
    float hour;
    float minute;
    float second;

    bool start;
    [SerializeField] TextMeshProUGUI timerTxt;
    // Start is called before the first frame update
    void Start()
    {
        start = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
         StopWatchCalcul();
    }

    void StopWatchCalcul()
    {
        if(start)
        {
        timer += Time.deltaTime;
        hour = (int)(timer / 3600);
        minute = (int)((timer / 60)%60);
        second = (int)(timer % 60);
        timerTxt.text = hour.ToString("00") + " : " + minute.ToString("00") + " : " + second.ToString("00");
        }
    }
    public void startTimer()
    {
        start = true;
    }
    public void stopTimer()
    {
        start = false;
    }
    public void resets()
    {
        start = false;
        timer = 0;
        timerTxt.text = "00 : 00 : 00";
    }
}
