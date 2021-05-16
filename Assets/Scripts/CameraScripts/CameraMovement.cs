using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   // Vector3 destinationPoint = new Vector3(-1.765809f,4.952399f,5.671323f);
    //float smoothing = 1f;

   static public bool moving = false;

   public GameObject endMarker;
   public GameObject startMarker;
   private Vector3 _endMarker;
   Vector3 rotationDifference;

    static public bool isCloseUp = false;
    [SerializeField] GameObject exitButton;
    

   float speed;
   float rotationSpeed = 1.7f;
   

    public static void StartMoving()
    {
        moving = true;
    }

        public void slideBack()
    {
        if (isCloseUp)
        {
            moving = true;
        }

    }

    void Update()
    {
        if (moving&&(!isCloseUp))//Плавное "скольжение" из одной точки в другую
        {

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
            rotationDifference =new Vector3(0f,180f,0f) - transform.rotation.eulerAngles;
            if ((Mathf.Abs(rotationDifference.x-transform.position.x)>0.4f)||
            ((Mathf.Abs(rotationDifference.y-transform.position.y)>0.4f)||
            (Mathf.Abs(rotationDifference.z-transform.position.z)>0.4f)))
            transform.Rotate((rotationDifference)*rotationSpeed*Time.deltaTime);
            

            if (distance==0f)
            {
                Debug.Log("stopped moving");
                moving = false;
                isCloseUp = true;
                exitButton.SetActive(true);
                rotationDifference =startMarker.transform.rotation.eulerAngles - transform.rotation.eulerAngles;
            }
        } else if (isCloseUp&&moving)
        {

            Debug.Log(transform.position);
            Debug.Log(startMarker.transform.position);
            float distance = Vector3.Distance(transform.position,startMarker.transform.position);
            Debug.Log(distance);
            speed = distance*0.7f;
            speed = Mathf.Pow(speed,1.5f);
            if (speed<0.7f) 
            {
                speed = 0.7f;
            }
            transform.position = Vector3.MoveTowards(transform.position,
            startMarker.transform.position,
            1.7f*speed* Time.deltaTime);

            transform.rotation = startMarker.transform.rotation;

            if (distance==0f)
            {
                Debug.Log("stopped moving");
                moving = false;
                isCloseUp = false;
                exitButton.SetActive(false);
            }
           
        }
    }

    void Start()
    {
         exitButton.SetActive(false);
        _endMarker = endMarker.transform.position;
        _endMarker.x -=0f;
        exitButton.SetActive(false);

        //_startPosition.position = new Vector3(-5.76580858f,4.95239925f,5.67132282f);
    }

}
