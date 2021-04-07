using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{

    
    public Color Krug;  // цвет выделения
    private Color self;
    void Start()
    {
        self = gameObject.GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))   //если клавиша нажата
        {
            //Debug.Log("Space key is pressed.");
            gameObject.GetComponent<Renderer>().material.color = Krug;
        }
        else                            //если не нажата
        {
            //Debug.Log("Space key is  not pressed.");
            gameObject.GetComponent<Renderer>().material.color = self;
        }

    }
}
