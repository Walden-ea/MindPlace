using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;
//using System.Threading;

public class ReminderSpawner : MonoBehaviour
{
    public string reminder = "";
    public GameObject reminderBoard;
    public float myTime = 10;
    public float current;

    void Start()
    {
        //reminderBoard.SetActive(false);
        //reminder = GetComponent<Text>().text;
        current = myTime * 10f;
    }
    
    void Update()
    {
        current = current - Time.deltaTime;
        if (current <= 0)
        {
            //Debug.Log("Прошло 10 секунд");
            //reminder = reminder + " 30 минут!";
            //GetComponent<Text>().text = reminder;
            reminderBoard.SetActive(true);
            current = myTime * 1000f;
        }
     
    }
   
}

