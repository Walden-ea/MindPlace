using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CorkBoard : MonoBehaviour
{
    private int stickerCount;
    List<Sticker> stickers;
    int count;
    [SerializeField] GameObject stickerPrefab;
    Transform position; 
    
    void Start()
    {
        count = -1;
        position = GetComponent<Transform>();
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown() {

        if (count < 4 )
        {
            Instantiate(stickerPrefab,GetStickerPosition(),default(Quaternion));
        Debug.Log("created");
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
