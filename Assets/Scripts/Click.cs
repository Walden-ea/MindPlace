using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Click : MonoBehaviour
{
    public GameObject input;
    public GameObject canvas;
    public string line;

    public void Start()
    {
         canvas.SetActive(false);
    }
    public void method()
    {
        line = input.GetComponent<InputField>().text;
        canvas.SetActive(true);

    }

    public void close()
    {
         canvas.SetActive(false);
    }
}
