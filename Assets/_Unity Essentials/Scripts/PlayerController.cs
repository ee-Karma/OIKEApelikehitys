using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var nKey = Keyboard.current.nKey.wasPressedThisFrame;
        var lKey = Keyboard.current.lKey.wasPressedThisFrame;


        if (nKey)
        {
            PlayerData.Instance.SaveData("Markus", 15, 150);
        }
        if (lKey)
        {
            PlayerData.Instance.LoadData();
        }
    }
}
