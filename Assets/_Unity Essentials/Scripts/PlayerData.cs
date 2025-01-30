using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance { get; private set; }
    private string name;
    private int level;
    private int health;


    private void Awake()
    {
        if (Instance == null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SaveData(string _name, int _level, int _health)
    {
        name = _name;
        level = _level;
        health = _health;

        print($"Talennettavat tiedot: nimi: {_name} taso: {_level} terveyspisteet: {_health} ");
    }

    public void LoadData()
    {
        print($"Ladattavat tiedot: {name} taso: {level} terveyspisteet: {health} ");
    }

    

}
