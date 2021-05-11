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

public class Calendar : MonoBehaviour
{
    public TextMeshPro MeshCalendar;
    public GameObject pointer;
    private GameObject usless;
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
    static private void add_space(int n, ref string s)// добавляет пробел к одно значному числу
    {
        if (0 <= n && n <= 9)
        {
            s = s + "  ";
        }

    }
     private string calendar(DateTime date)  //строим календарь
    {
        string ans = "";
        DateTime now = date;
        int nowmonth = date.Month;
        int nextmonth = date.AddMonths(1).Month;
        int dayinnowmonth = new DateTime(date.Year, date.AddMonths(1).Month, 1).AddDays(-1).Day;
        var cal = new GregorianCalendar();
        
        date = Get_date_start_week(Get_date_start_month(date));
        
        while (date.Month != nowmonth)
        {
            ans = ans + "     ";
            date = date.AddDays(1); num += 1; 
        }
        
        while (date.Month != nextmonth)
        {

            while (cal.GetDayOfWeek(date) != DayOfWeek.Sunday)
            {
                add_space(date.Day, ref ans);

                if (date.Day == now.Day) ans = ans + "<color=red>";
                ans = ans + "" + date.Day + " ";
                if (date.Day == now.Day)   // выделение указателем
                {
                    ans = ans + "</color>";
                    GameObject rrr = GameObject.Find($"GameObject {num}");
                    Vector3 tt = rrr.transform.position;
                    pointer.transform.position = tt;
                    print(num);

                }

                if (date.Day == dayinnowmonth) return ans;

                date = date.AddDays(1); num += 1;

            }
            add_space(date.Day, ref ans);

            if (date.Day == now.Day) ans = ans + "<color=red>";
            ans = ans + "" + date.Day + "\n";
            if (date.Day == now.Day)  // выделение указателем
            {  
                ans = ans + "</color>";
                GameObject rrr = GameObject.Find($"GameObject {num}");
                Vector3 tt = rrr.transform.position;
                pointer.transform.position = tt;
                print(num);
            }

            if (date.Day == dayinnowmonth) return ans;

            date = date.AddDays(1); num += 1;

        }
        
        return ans;

    }
    // Start is called before the first frame update
    void Start()
    {        
        DateTime date1 = DateTime.Now; 
       MeshCalendar.text = calendar(date1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
