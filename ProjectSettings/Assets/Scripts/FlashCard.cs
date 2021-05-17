using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FlashCard : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] GameObject Window;
    [SerializeField]InputField field1;
    [SerializeField]InputField field2;

    void Start()
    {
        Window.SetActive(false);
    }

    public void Awake()
    {
        Window.SetActive(true);
    }

    public void CreateNewCard()
    {
        GameObject newCard = Instantiate(cardPrefab, new Vector3(2.0F, 0, 0), Quaternion.identity) as GameObject;
        GameObject textSideOne = newCard.transform.Find("FirstSideText").gameObject;
        textSideOne.GetComponent<TextMeshPro>().text = field1.text;
    }


  
}
