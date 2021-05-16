using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Изменяет цвет обьекта при нажатии на клавишу
/// </summary>
public class Illumination : MonoBehaviour
{

    
    public Color illumination;  // цвет выделения
    private Color self; 
    void Start()
    {
        self = gameObject.GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))   //если клавиша нажата
        {
            Debug.Log("Illumintation works");
            gameObject.GetComponent<Renderer>().material.color = illumination;
        }
        else   //если не нажата
        {
            gameObject.GetComponent<Renderer>().material.color = self;
        }

    }
}
