using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InstantiateOfBook : MonoBehaviour
{
    //Необходимо установить Physics Raycaster на основную камеру
    public GameObject bookMenu;
    public GameObject writer1;
    public GameObject writer2;
    public GameObject writer3;
    public GameObject writer4;
    public GameObject writer5;
    public GameObject writer6;
    public GameObject writer7;
    public GameObject writer8;
    public GameObject writer9;
    public GameObject writer10;
    public void OnMouseDown( )
    {
        bookMenu.SetActive(true);

        writer1.SetActive(true);
        writer2.SetActive(true);
        //writer3 = GameObject.Find("Writer3");
        writer3.SetActive(false);
        //writer4 = GameObject.Find("Writer4");
        writer4.SetActive(false);
        //writer5 = GameObject.Find("Writer5");
        writer5.SetActive(false);
        //writer6 = GameObject.Find("Writer6");
        writer6.SetActive(false);
        //writer7 = GameObject.Find("Writer7");
        writer7.SetActive(false);
        //writer8 = GameObject.Find("Writer8");
        writer8.SetActive(false);
        //writer9 = GameObject.Find("Writer9");
        writer9.SetActive(false);
        //writer10 = GameObject.Find("Writer10");
        writer10.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        bookMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
