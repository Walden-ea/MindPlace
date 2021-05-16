using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddList : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    public GameObject writer1a;
    public GameObject writer2a;
    public GameObject writer3a;
    public GameObject writer4a;
    public GameObject writer5a;
    public GameObject writer6a;
    public GameObject writer7a;
    public GameObject writer8a;
    public GameObject writer9a;
    public GameObject writer10a;
    public bool l12 = false;
    public bool l34 = false;
    public bool l56 = false;
    public bool l78 = false;
    public bool l910 = false;

    public GameObject ButtonPlus;

    public void AddListAfter()
    {
        if ((writer1.activeSelf) && (l12 == false))
        {
            writer1.SetActive(false);
            writer2.SetActive(false);
            writer1a.SetActive(true);
            writer2a.SetActive(true);
            l12 = true;
            ButtonPlus.SetActive(false);
        }
        else if ((writer3.activeSelf) && (l34 == false))
        {
            writer3.SetActive(false);
            writer4.SetActive(false);
            writer3a.SetActive(true);
            writer4a.SetActive(true);
            l34 = true;
            ButtonPlus.SetActive(false);
        }
        else if ((writer5.activeSelf) && (l56 == false))
        {
            writer5.SetActive(false);
            writer6.SetActive(false);
            writer5a.SetActive(true);
            writer6a.SetActive(true);
            l56 = true;
            ButtonPlus.SetActive(false);
        }
        else if ((writer7.activeSelf) && (l78 == false))
        {
            writer7.SetActive(false);
            writer8.SetActive(false);
            writer7a.SetActive(true);
            writer8a.SetActive(true);
            l78 = true;
            ButtonPlus.SetActive(false);
        }
        else if ((writer9.activeSelf) && (l910 == false))
        {
            writer9.SetActive(false);
            writer10.SetActive(false);
            writer9a.SetActive(true);
            writer10a.SetActive(true);
            l910 = true;
            ButtonPlus.SetActive(false);
        }
    }

}
