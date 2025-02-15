using UnityEngine;

public class StartupInitializer : MonoBehaviour
{
  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
  static void Initialize()
  {
    Debug.Log("Initializing...");
  }

  void Start()
  {

  }

  void Update()
  {

  }
}
