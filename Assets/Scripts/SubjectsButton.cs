using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectsButton : MonoBehaviour
{
    MeshRenderer meshRender;
    public Texture[] text = new Texture[4];

    int cur = 0;
    
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
    }


   
     public void sub()
    {
        meshRender.material.SetTexture("_MainTex", text[cur%4]);
        cur++;
    }
    /*public void sub1()
    {
        meshRender.material.SetTexture("_MainTex", text[1]);
    }
    public void sub2()
    {
        meshRender.material.SetTexture("_MainTex", text[2]);
    }
    public void sub3()
    {
        meshRender.material.SetTexture("_MainTex", text[3]);
    } */
}
