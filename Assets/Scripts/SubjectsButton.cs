using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectsButton : MonoBehaviour
{
    MeshRenderer meshRender;
    public Texture text;
    // Start is called before the first frame update
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
    }

   
     public void sub()
    {
        meshRender.material.SetTexture("_MainTex", text);
    }
}
