using UnityEngine;
using UnityEngine.InputSystem;
public class AudioController : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.yKey.wasPressedThisFrame)
        {
            AudioManager.Instance.StopSound();

        }
        if(Keyboard.current.uKey.wasPressedThisFrame )
        {
            AudioManager.Instance.PlaySound(clip);
        }
    }
}
