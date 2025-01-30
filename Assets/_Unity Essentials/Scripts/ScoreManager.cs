using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance{ get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Pelissä on liikaa ScoreManager objekteja");
            Destroy(gameObject); return;
            
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public int score;
}
