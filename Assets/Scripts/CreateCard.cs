﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CreateCard : MonoBehaviour
{
   [SerializeField] GameObject cardPrefab;
   [SerializeField] GameObject Window;

   [SerializeField]InputField FirstSideInput;
   [SerializeField]InputField SecondSideInput;
    void Start()
    {
       Window.SetActive(false);
    }

    public void SomeMethod()
    {
        GameObject newCard = Instantiate(cardPrefab, new Vector3(10.58f, 0, -2.593f), Quaternion.identity) as GameObject;
        GameObject textSideOne = GameObject.Find("FirstSideText");
        textSideOne.GetComponent<TextMeshPro>().text = FirstSideInput.text;
        GameObject textSideTwo = GameObject.Find("SecondSideText");
        textSideTwo.GetComponent<TextMeshPro>().text = SecondSideInput.text;        

    }

    public void CloseWindow()
    {
        Window.SetActive(false);
    }

    public void OnMouseDown() 
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Window.SetActive(true);
        }
    }




}