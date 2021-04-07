using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public void SettingsPanel()
    {
        settingsPanel.SetActive(true);

    }

    public GameObject breakPanel;
    public void BreakPanel()
    {
        breakPanel.SetActive(true);

    }
    public void Exit()
    {
        settingsPanel.SetActive(false);

    }
    public void Exit1()
    {
        breakPanel.SetActive(false);

    }
    public GameObject stopwatch;
    public void StopWatch()
    {
        stopwatch.SetActive(true);

    }
    public void Exit2()
    {
        stopwatch.SetActive(false);

    }
}
