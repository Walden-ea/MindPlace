﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class ClickOnObject : MonoBehaviour
{
    public GameObject canvas;

    public void Start()
    {
        canvas.SetActive(false);
    }
    // Update is called once per frame
    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            canvas.SetActive(true);
            print("Click");
        }
    }
}

