using TinyLittleStudio;
using UnityEngine;

public class Demo : MonoBehaviour
{
    private void Awake()
    {
        Core core = Manager.SetCore(new CoreDemo());
    }
}
