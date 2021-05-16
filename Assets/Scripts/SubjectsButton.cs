using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectsButton : MonoBehaviour
{
    MeshRenderer meshRender;
    public Texture[] text = new Texture[4];
     public int c = 0;
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
    }

   
     public void sub()
    {
      
    meshRender.material.SetTexture("_MainTex", text[c%4]);
        c++;
    }
   /* public void sub1()
    {
        meshRender.material.SetTexture("_MainTex1", text[1]);
    }
    public void sub2()
    {
        meshRender.material.SetTexture("_MainTex2", text[2]);
    }
    public void sub3()
    {
        meshRender.material.SetTexture("_MainTex3", text[3]);
    }*/
}
