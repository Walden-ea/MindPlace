using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 destinationPoint = new Vector3(-1.765809f,4.952399f,5.671323f);
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
        float rotateX = Random.Range (0, 50);
        Debug.Log("should move");
        //transform.position = Vector3.Lerp (transform.position, destinationPoint, smoothing * Time.deltaTime);
        Vector3 lerp = new Vector3(20f, 180f, -1f);
        //transform.eulerAngles = lerp;
        transform.Rotate(lerp, 10.0f * Time.deltaTime);
        Debug.Log("MOVE ALREADY");
    }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

}