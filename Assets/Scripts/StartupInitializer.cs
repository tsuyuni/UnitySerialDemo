using UnityEngine;

public class StartupInitializer
{
  public static string PortName = "/dev/tty.usbserial-1130";
  public static int BaudRate = 9600;


  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
  private static void Initialize()
  {
    Debug.Log("Initializing...");

    SerialManager.Open(portName: PortName, baudRate: BaudRate);
  }
}
