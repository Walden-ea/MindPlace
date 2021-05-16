using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sticker : MonoBehaviour
{
    [SerializeField] GameObject inputfield;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        /*GameObject newcanv = Instantiate(inputfield, transform.position, transform.rotation);
        newcanv.transform.SetParent(GameObject.FindGameObjectWithTag("canvas").transform, false);
        newcanv.SetActive(true);*/

        CameraMovement.moving = true;
        Debug.Log("start moving");
    }

}