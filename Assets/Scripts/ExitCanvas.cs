using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExitCanvas : MonoBehaviour
{
    public GameObject canvas;


    public void OnMouseDown()
    {
        canvas.SetActive(false);
    }
}