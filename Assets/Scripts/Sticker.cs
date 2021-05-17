using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sticker : MonoBehaviour
{
    [SerializeField] GameObject inputfield;
    
    bool created = false;

    MeshRenderer meshRender;

    GameObject newcanv;

     public Texture[] text = new Texture[17];

      void Start()
    {
        var rand = Random.Range(0,17);
        //meshRender = GetComponent<MeshRenderer>();
       //meshRender.material.SetTexture("_MainTex", text[rand]);
       transform.Find("paper.007").GetComponent<MeshRenderer>().material.SetTexture("_MainTex", text[rand]);

    }


    private void OnMouseDown() {
        //Debug.Log(CameraMovement.isCloseUp);
        if (CameraMovement.isCloseUp)
        {
        /*if(!created)
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
        }
        else {
            CameraMovement.moving = true;
        }
        
     }

    public void close()
    {
        newcanv.SetActive(false);
    }

}