using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   // Vector3 destinationPoint = new Vector3(-1.765809f,4.952399f,5.671323f);
    //float smoothing = 1f;

   static public bool moving = false;

   public GameObject endMarker;
   private Vector3 _endMarker;
   //public Camera camera;

   float speed;
   float rotationSpeed = 1.7f;
   

    public static void StartMoving()
    {
        moving = true;
    }

    void Update()
    {
        if (moving)//Плавное "скольжение" из одной точки в другую
        {
            Debug.Log("should move");
            /*float rotateX = Random.Range (0, 50);
            Debug.Log("should move");
            //transform.position = Vector3.Lerp (transform.position, destinationPoint, smoothing * Time.deltaTime);
            Vector3 lerp = new Vector3(20f, 180f, -1f);
            //transform.eulerAngles = lerp;
            transform.Rotate(lerp, 10.0f * Time.deltaTime);
            Debug.Log("MOVE ALREADY");*/

            float distance = Vector3.Distance(transform.position,endMarker.transform.position);

            speed = distance*0.7f;
            speed = Mathf.Pow(speed,1.5f);
    

            if (speed<0.7f) 
            {
                speed = 0.7f;
            }

            transform.position = Vector3.MoveTowards(transform.position,
            _endMarker,
            1.7f*speed* Time.deltaTime);

           // transform.rotation = Quaternion.Slerp(transform.rotation,new Quaternion(0,1,0,0), timeCount);
            //timeCount += Time.deltaTime;

            //camera.transform.rotation = new Quaternion(0,1,0,0);

            Vector3 rotationDifference =new Vector3(0f,180f,0f) - transform.rotation.eulerAngles;
            if ((Mathf.Abs(rotationDifference.x-transform.position.x)>0.4f)||
            ((Mathf.Abs(rotationDifference.y-transform.position.y)>0.4f)||
            (Mathf.Abs(rotationDifference.z-transform.position.z)>0.4f)))
            transform.Rotate((rotationDifference)*rotationSpeed*Time.deltaTime);
            

            if (distance==0f)
            {
                Debug.Log("stopped moving");
                moving = false;
            }
        }
    }

    void Start()
    {
        
        _endMarker = endMarker.transform.position;
        _endMarker.x -=0f;
    }

}