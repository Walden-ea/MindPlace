using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject Window;
    public void Awake()
    {
        Window.SetActive(true);
    }
}
