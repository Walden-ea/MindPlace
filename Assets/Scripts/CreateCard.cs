using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreateCard : MonoBehaviour
{
   [SerializeField] GameObject cardPrefab;
   [SerializeField] GameObject Window;

   [SerializeField]InputField field;
    void Start()
    {
       Window.SetActive(false);
    }

    public void SomeMethod()
    {
        GameObject newCard = Instantiate(cardPrefab, new Vector3(2.0F, 0, 0), Quaternion.identity) as GameObject;
        GameObject textSideOne = GameObject.Find("FirstSideText");
        textSideOne.GetComponent<TextMeshPro>().text = field.text;
    }

    public void FillCard(GameObject card)
    {
        GameObject textSideOne = GameObject.Find("FirstSideText");
        textSideOne.GetComponent<Text>().text = field.text;
    }
    public void Awake()
    {
        Window.SetActive(true);
    }
    public void Show(string inputString)
    {

          //inputFieldSideOne.text = inputString;
          //Debug.Log(inputFieldSideOne.text);

    }
    void Update()
    {
        
    }

    void CreateNewCard()
    {
        
    }


}