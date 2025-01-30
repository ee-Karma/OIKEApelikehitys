using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    
    
    public static AudioManager Instance{ get; private set; }

    private void Awake()
    {
        if (Instance != null & Instance != this)
        {
            Debug.LogError("Peliss� on liian monta AudioManager objektia");
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void StopSound()
    {
        print("Pys�ytt�� ��nen");
    }

    public void PlaySound(AudioClip clip) 
    { 
        print($"Soittaa ��nen: {clip}");
    
    }
    
}
