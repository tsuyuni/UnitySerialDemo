using System.IO.Ports;

public class SerialManager
{
  private static SerialPort s_serialPort;

  public static void Open(string portName, int baudRate)
  {
    s_serialPort = new SerialPort(portName, baudRate);
    s_serialPort.Open();
  }

  public static void Write(string message)
  {
    s_serialPort.WriteLine(message);
  }
}
