using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sticker : MonoBehaviour
{
    [SerializeField] GameObject inputfield;
    
    bool created = false;

    GameObject newcanv;

    private void OnMouseDown() {
       /* if(!created)
        {
            newcanv = Instantiate(inputfield, transform.position, transform.rotation);
            newcanv.transform.SetParent(GameObject.FindGameObjectWithTag("canvas").transform, false);
            newcanv.SetActive(true);
            created = true;
        }
        else
        {
            newcanv.SetActive(true);
        }*/

       CameraMovement.moving = true;
        
           }

    public void close()
    {
        newcanv.SetActive(false);
    }

}