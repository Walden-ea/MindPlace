using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToThePreviousPage : MonoBehaviour
{
    public AddList addList;
    // Start is called before the first frame update
    void Start()
    {
        addList = gameObject.GetComponent<AddList>();
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
    //Additional Lists
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

    public GameObject ButtonPlus;

    public void MoveBack()
    {
        if (writer3.activeSelf)
        {
            writer3.SetActive(false);
            writer4.SetActive(false);
            if (addList.l12 == false)
            {
                writer1.SetActive(true);
                writer2.SetActive(true);
                ButtonPlus.SetActive(true);
            }
            else
            {
                writer1a.SetActive(true);
                writer2a.SetActive(true);
                ButtonPlus.SetActive(false);
            }
        }
        else if (writer5.activeSelf)
        {
            writer5.SetActive(false);
            writer6.SetActive(false);
            if (addList.l34 == false)
            {
                writer3.SetActive(true);
                writer4.SetActive(true);
                ButtonPlus.SetActive(true);
            }
            else
            {
                writer3a.SetActive(true);
                writer4a.SetActive(true);
                ButtonPlus.SetActive(false);
            }
        }
        else if (writer7.activeSelf)
        {
            writer7.SetActive(false);
            writer8.SetActive(false);
            if (addList.l56 == false)
            {
                writer5.SetActive(true);
                writer6.SetActive(true);
                ButtonPlus.SetActive(true);
            }
            else
            {
                writer5a.SetActive(true);
                writer6a.SetActive(true);
                ButtonPlus.SetActive(false);
            }
        }
        else if (writer9.activeSelf)
        {
            writer9.SetActive(false);
            writer10.SetActive(false);
            if (addList.l78 == false)
            {
                writer7.SetActive(true);
                writer8.SetActive(true);
                ButtonPlus.SetActive(true);
            }
            else
            {
                writer7a.SetActive(true);
                writer8a.SetActive(true);
                ButtonPlus.SetActive(false);
            }
        }
        else if (writer1a.activeSelf)
        {
            writer1a.SetActive(false);
            writer2a.SetActive(false);
            writer1.SetActive(true);
            writer2.SetActive(true);
        }
        else if (writer3a.activeSelf)
        {
            writer3a.SetActive(false);
            writer4a.SetActive(false);
            writer3.SetActive(true);
            writer4.SetActive(true);
        }
        else if (writer5a.activeSelf)
        {
            writer5a.SetActive(false);
            writer6a.SetActive(false);
            writer5.SetActive(true);
            writer6.SetActive(true);
        }
        else if (writer7a.activeSelf)
        {
            writer7a.SetActive(false);
            writer8a.SetActive(false);
            writer7.SetActive(true);
            writer8.SetActive(true);
        }
        else if (writer9a.activeSelf)
        {
            writer9a.SetActive(false);
            writer10a.SetActive(false);
            writer9.SetActive(true);
            writer10.SetActive(true);
        }
    }
}
