using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seconds : MonoBehaviour
{
  public int secondTime; // проверка отчёта секунд в Inspector
  public float minutTime;// проверка отчёта минут в Inspector
  private float timersecond;

  public Text text;

    void Update()
    {
      timersecond += Time.deltaTime;
      if (timersecond >= 1) {
          secondTime += 1;
          timersecond = 0;
      }
      if (secondTime >= 60) {
          minutTime += 1;
          secondTime = 0;
      }
      if (minutTime >= 60) {
         minutTime = 0;
      }

      text.text = $"{minutTime} : {secondTime}";
    }

}
