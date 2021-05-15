using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;
using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Collections.Specialized;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class calendar_button : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI button;
    private int num = 1; // переменная отвечает за то, куда тп указатель
    static private DateTime Get_date_start_week(DateTime date) // получение даты начала недели
    {
        int dayofweeknum = (int)date.DayOfWeek - 1;
        if (dayofweeknum == -1)
            dayofweeknum = 6;

        return date.AddDays(-dayofweeknum); ;
    }
    static private DateTime Get_date_start_month(DateTime date) // получение даты начала Месяца
    {
        return new DateTime(date.Year, date.Month, 1);
    }
    private void calendar(DateTime date)  //строим календарь
    {
        DateTime now = date;
        int nowmonth = date.Month;
        var cal = new GregorianCalendar(); 
        int dayinnowmonth = new DateTime(date.Year, date.AddMonths(1).Month, 1).AddDays(-1).Day;

        date = Get_date_start_week(Get_date_start_month(date));

        while (date.Month != nowmonth)
        {
            date = date.AddDays(1); num += 1;
        }


        button.text = "" + (number + 1 - num);
        if ((number - num) + 1 <= 0)
            button.text = "";
        if ((number - num) + 1 > dayinnowmonth)
            button.text = "";


    }
    // Start is called before the first frame update
    void Start()
    {
        DateTime date1 = DateTime.Now;
        calendar(date1);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
