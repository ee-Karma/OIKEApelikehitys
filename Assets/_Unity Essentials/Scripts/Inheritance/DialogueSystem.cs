using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    
    public static DialogueSystem Instance { get; private set; }

    
    private List<(string name, string[] dialogue)> dialogues = new List<(string, string[])>();

    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    public void AddNewDialogue(string[] lines, string name)
    {
        dialogues.Add((name, lines));
        CreateDialog();
    }

    
    public void CreateDialog()
    {
        
        foreach (var dialogue in dialogues)
        {
            Debug.Log($"{dialogue.name}:");
            foreach (var line in dialogue.dialogue)
            {
                Debug.Log(line);
            }
        }
    }
}