using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCard : MonoBehaviour
{

    public float RotateSpeed = 30f;

    // Update is called once per frame
    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
    }
}
