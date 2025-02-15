using System;

using UnityEngine;

public class GameController : MonoBehaviour
{
  void Update()
  {
    SerialManager.Write((Math.Floor(Time.time) % 2).ToString());
  }
}
