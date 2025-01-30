using UnityEngine;
using UnityEngine.InputSystem;

public class SettingsController : MonoBehaviour
{
    private void Update()
    {
        var Key1 = Keyboard.current.digit0Key.wasPressedThisFrame;
        var Key2 = Keyboard.current.digit2Key.wasPressedThisFrame;

        if (Key1)
        {
            SettingsManager.Instance.Brightness = 4.2f;

        }
        if (Key2)
        {
            SettingsManager.Instance.Volume = 5.0f;
        }
    }
}
