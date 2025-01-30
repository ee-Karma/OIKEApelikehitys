using UnityEngine;

public class Blacksmith : Interactable
{
    // Sepän vuoropuhelu, jonka pelaaja kuulee, kun vuorovaikuttaa
    public string[] dialogueLines = {
        "Tervetuloa sepän pajalle!",
        "Tarvitsetko apua työkaluissa tai aseissa?",
        "Voin valmistaa sinulle uuden miekän, jos sinulla on tarpeeksi kultaa."
    };

    // Ylikirjoitettu Interact-metodi, joka kutsuu DialogueSystemia
    public override void Interact()
    {
        // Lisää dialogi DialogueSystemiin ja antaa sen tulostaa se konsoliin
        DialogueSystem.Instance.AddNewDialogue(dialogueLines, "Seppä");
    }
}