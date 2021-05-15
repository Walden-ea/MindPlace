using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Threading;

public class ListRotation : MonoBehaviour
{
    public GameObject firstPage;
    public GameObject list1;
    public GameObject list2;
    public GameObject list3;
    public GameObject list4;
    int a = 0;
    public float counter = 0f;
    public float wait = 2000f;
    //float k = 0f;
    List<GameObject> allPages = new List<GameObject>();

    IEnumerator Rotate()
    {
        for (int i = 0; i < 50; i++)
        {
            float degree = i * 180 / 50;
            Quaternion rot = Quaternion.Euler(0, 0, degree);
            Vector3 pos = allPages[a].transform.position + new Vector3(0, 0.00004f*a, 0);
            allPages[a].transform.rotation = rot;
            allPages[a].transform.position = pos;
            yield return null;
        }
        if (a < 4)
        {
            a += 1;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //List<GameObject> allPages = new List<GameObject>();
        allPages.Add(firstPage);
        allPages.Add(list1);
        allPages.Add(list2);
        allPages.Add(list3);
        allPages.Add(list4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            StartCoroutine("Rotate");
        }
    }
}
