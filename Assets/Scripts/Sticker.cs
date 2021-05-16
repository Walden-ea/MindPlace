using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sticker : MonoBehaviour
{
    [SerializeField] GameObject inputfield;
    

    private void OnMouseDown() {
        /*GameObject newcanv = Instantiate(inputfield, transform.position, transform.rotation);
        newcanv.transform.SetParent(GameObject.FindGameObjectWithTag("canvas").transform, false);
        newcanv.SetActive(true);*/

        CameraMovement.moving = true;
        Debug.Log("start moving");
    }

}