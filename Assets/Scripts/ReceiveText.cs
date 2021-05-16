using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Windows.Forms;

public class ReceiveText : MonoBehaviour
{
    public GameObject list;
    public InputField page;
    public GameObject window;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Recieve()
    {
        list.GetComponent<Text>().text = page.text;
        window.SetActive(false);
        //Cursor.Position = new Point(100, 200);
    }
}
