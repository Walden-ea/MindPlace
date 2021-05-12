using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sticker : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        //CameraMovement.StartMoving();
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            CameraMovement.moving = true;
            Debug.Log("start moving");
        }
    }

}