using UnityEngine;

public class UFO : Interactable
{
    // Unity-editoriin n‰kyv‰ taulukko, johon voidaan lis‰t‰ dialogin rivit
    public string[] dialogueLines;
    public string ufoName = "UFO";

    // Ylikirjoitetaan Interact-metodi
    public override void Interact()
    {
        // Lis‰t‰‰n uusi dialogi DialogueSystemiin
        DialogueSystem.Instance.AddNewDialogue(dialogueLines, ufoName);
    }
}
