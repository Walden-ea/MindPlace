using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject Menu;

    public void Start()
    {
        Menu.SetActive(false);
        settingsPanel.SetActive(false);
        breakPanel.SetActive(false);
         stopwatch.SetActive(false);
    }
    public void SettingsPanel()
    {
        settingsPanel.SetActive(true);
        Menu.SetActive(false);

    }

    public GameObject breakPanel;
    public void BreakPanel()
    {
        breakPanel.SetActive(true);
        Menu.SetActive(false);

    }
    public void Exit()
    {
        settingsPanel.SetActive(false);
          Menu.SetActive(true);

    }
    public void Exit1()
    {
        breakPanel.SetActive(false);
          Menu.SetActive(true);

    }
    public GameObject stopwatch;
    public void StopWatch()
    {
        stopwatch.SetActive(true);
          Menu.SetActive(false);

    }
    public void Exit2()
    {
        stopwatch.SetActive(false);
          Menu.SetActive(true);

    }
}
