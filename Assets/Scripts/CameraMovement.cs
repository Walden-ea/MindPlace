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

    void Update() {
        StartCoroutine(LerpFromTo(transform.position, destinationPoint, 1f) );
    }

    IEnumerator LerpFromTo(Vector3 pos1, Vector3 pos2, float duration) {
     for (float t=0f; t<duration; t += Time.deltaTime) {
    transform.position = Vector3.Lerp(pos1, pos2, t / duration);
    yield return 0;
    }
    transform.position = pos2;
    }



}
