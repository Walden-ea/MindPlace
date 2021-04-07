using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class Clock : MonoBehaviour
{



    [SerializeField] GameObject Canvas;
 public void OnMouseDown()
   {
        Canvas.SetActive(true);
   }

   public void CloseWindow()
   {
      Canvas.SetActive(false);
   }
}
