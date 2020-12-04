using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
        GameObject newCard = Instantiate(cardPrefab, new Vector3(2.0F, 0, 0), Quaternion.identity) as GameObject;
        GameObject textSideOne = GameObject.Find("FirstSideText");
        textSideOne.GetComponent<TextMeshPro>().text = FirstSideInput.text;
        GameObject textSideTwo = GameObject.Find("SecondSideText");
        textSideTwo.GetComponent<TextMeshPro>().text = SecondSideInput.text;        

    }

    public void Awake()
    {
        Window.SetActive(true);
    }




}