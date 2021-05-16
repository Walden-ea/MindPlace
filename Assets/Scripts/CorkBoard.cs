using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorkBoard : MonoBehaviour
{
    private int stickerCount;
    List<Sticker> stickers;
    int count;
    [SerializeField] GameObject stickerPrefab;
    Transform position; 
    [SerializeField] Camera _camera;
    
    int i = 0;
    void Start()
    {
        count = -1;
        position = GetComponent<Transform>();
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown() {

        if (count < 4 &&(!CameraMovement.moving))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject s = Instantiate(stickerPrefab, new Vector3(hit.point.x, hit.point.y,-3.07f), Quaternion.identity);
                s.name = "sticker"+i;
                i++;
            }
        }
        else Debug.Log("enough for now");
    } 

    Vector3 GetStickerPosition()
    {
        count++;
        Debug.Log(position.position);
       // return position.position + new Vector3(-position.localScale.x/3+0.3f*count , position.localScale.y/10, -position.localScale.z);
       return position.position + new Vector3(0.3f*count,-3f,2.91f);
        
    }
    
}
