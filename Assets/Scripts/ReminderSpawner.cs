using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//using System.Threading;

public class ReminderSpawner : MonoBehaviour
{
    public string reminder;
    public string reminder1;
    private string timePassed;
    public GameObject reminderBoard;
    public Text timeText;
    public int myTime = 10;
    public float current;
    public int newTime = 30;

    void Start()
    {
        reminderBoard.SetActive(false);
        current = myTime + 35;
        reminder = "Вы находитесь за компьютером уже ";
        reminder1 = reminder;
        timePassed = "30";
    }
    
    void Update()
    {
        current = current - Time.deltaTime;
        if ((current <= 35) & (current > 30))
        {
            reminder = reminder1 + ' ' + timePassed + " минут!";
            timeText.text = reminder;
            reminderBoard.SetActive(true);
            current = 30;
        }

        if (current <= 0)
        {
            reminderBoard.SetActive(false);
            current = myTime + 35;
            newTime += 30;
            timePassed = newTime.ToString();
        }
     
    }
   
}

