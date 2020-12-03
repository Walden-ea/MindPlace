using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 destinationPoint = new Vector3(0,0,-0.7f);
    float smoothing = 1f;

   static public bool moving = false;

    public static void StartMoving()
    {
        moving = true;
    }
void Update()
{
    if (moving)//Плавное "скольжение" из одной точки в другую
    {
        Debug.Log("should move");
        transform.position = Vector3.Lerp (transform.position, destinationPoint, smoothing * Time.deltaTime);
        Debug.Log("MOVE ALREADY");
    }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
