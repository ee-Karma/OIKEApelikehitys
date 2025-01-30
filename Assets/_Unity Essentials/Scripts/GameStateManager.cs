using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public enum GameState
    {
        MainMenu,
        Paused,
        Playing
    }
    public GameState currentState;
    public static GameStateManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null & Instance != this)
        {
            Debug.LogError("Pelissä on liian monta AudioManager objektia");
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        currentState = GameState.Playing;
    }

    public void ChangeState(GameState state)
    {
        print($"Uusi tila on: {state}");
    }
}
