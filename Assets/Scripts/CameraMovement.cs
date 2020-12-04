using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    [SerializeField] GameObject Object;
    Vector3 destinationPoint = new Vector3(0,0,-0.7f);
    float smoothing = 0.5f;

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
        transform.position = Vector3.Lerp (transform.position, /*Object.transform.position - new Vector3(0,0,0.5f)*/ destinationPoint, 10f /*smoothing * Time.deltaTime */);
        Debug.Log(smoothing * Time.deltaTime );
        Debug.Log("MOVE ALREADY");
    }
}

    public void StopMovingAt(Vector3 vector, int wall)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
