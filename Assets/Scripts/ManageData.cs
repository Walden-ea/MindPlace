using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageData : MonoBehaviour
{
    [SerializeField]
    PageData pageData;

    bool setPageData()
    {
        var text = GetComponent<UnityEngine.UI.Text>();
        if (text!=null)
        {
            pageData.pageText = text.text;
            //цвет -- плейсхолдер....
            pageData.pageColor = Colors.White;
            return true;
        }
        return false;
    }

    

    private void OnDisable() {
        
    }

}
