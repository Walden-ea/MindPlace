using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToThePreviousPage : MonoBehaviour
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

    public void MoveBack()
    {
        if (writer3.activeSelf)
        {
            writer3.SetActive(false);
            writer4.SetActive(false);
            writer1.SetActive(true);
            writer2.SetActive(true);
        }
        else if (writer5.activeSelf)
        {
            writer5.SetActive(false);
            writer6.SetActive(false);
            writer3.SetActive(true);
            writer4.SetActive(true);
        }
        else if (writer7.activeSelf)
        {
            writer7.SetActive(false);
            writer8.SetActive(false);
            writer5.SetActive(true);
            writer6.SetActive(true);
        }
        else if (writer9.activeSelf)
        {
            writer9.SetActive(false);
            writer10.SetActive(false);
            writer7.SetActive(true);
            writer8.SetActive(true);
        }
    }
}
