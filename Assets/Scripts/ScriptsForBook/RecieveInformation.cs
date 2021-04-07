using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecieveInformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page6;
    public GameObject Page7;
    public GameObject Page8;
    public GameObject Page9;
    public GameObject Page10;
    public string line1 = "";
    public string line2 = "";
    public string line3 = "";
    public string line4 = "";
    public string line5 = "";
    public string line6 = "";
    public string line7 = "";
    public string line8 = "";
    public string line9 = "";
    public string line10 = "";

    public void GetInformation()
    {
        line1 = Page1.GetComponent<InputField>().text;
    }
}
