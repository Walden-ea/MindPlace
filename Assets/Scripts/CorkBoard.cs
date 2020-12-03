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
    
    void Start()
    {
        count = -1;
        position = GetComponent<Transform>();
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown() {

        if (count < 2)
        {
            Instantiate(stickerPrefab,GetStickerPosition(),default(Quaternion));
        Debug.Log("created");
        }
        else Debug.Log("enough for now");
    } 

    Vector3 GetStickerPosition()
    {
        count++;
        return position.position + new Vector3(-position.localScale.x/3+0.3f*count , position.localScale.y/10, -position.localScale.z);
        
    }
    
}
