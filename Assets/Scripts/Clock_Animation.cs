using System;
using UnityEngine;

public class Clock_Animation : MonoBehaviour
{
  public Transform hours,  minutes, seconds;
  private const float
  hoursToDegrees = 360f/12f,
  minutesToDegrees = 360f/60f,
  secondsToDegrees = 360f/60f;
  public bool analog;

  void Update()
  {
    if (analog) {
      TimeSpan timespan = DateTime.Now.TimeOfDay;
      hours.localRotation =
      Quaternion.Euler(0f,(float)timespan.TotalHours * -hoursToDegrees, 0f);
      minutes.localRotation =
      Quaternion.Euler(0f,(float)timespan.TotalMinutes * -minutesToDegrees, 0f);
      seconds.localRotation =
      Quaternion.Euler(0f,(float)timespan.TotalSeconds * secondsToDegrees, 0f);
    } else {
      DateTime time = DateTime.Now;
      hours.localRotation = Quaternion.Euler(0f, time.Hour * -hoursToDegrees, 0f);
      minutes.localRotation = Quaternion.Euler(0f,  time.Minute * -minutesToDegrees, 0f);
      seconds.localRotation = Quaternion.Euler(0f, time.Second * -secondsToDegrees, 0f);
    }
  }


  public void onClick() {

  }
}
