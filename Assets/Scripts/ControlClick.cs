using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControlClick : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData)
    {
        //Instantiate(myBookWriter);
        myBookWriter.SetActive(true);
    }
    public GameObject myBookWriter;
    // Start is called before the first frame update
    void Start()
    {
        myBookWriter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("w"))
            //Instantiate(myBookWriter);
    }
}
