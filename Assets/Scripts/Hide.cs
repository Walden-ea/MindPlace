using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
   public GameObject canvas;
    void Start()
    {
        canvas.SetActive(false);
    }
}
