using UnityEngine;

public class Blacksmith : Interactable
{
    // Sep�n vuoropuhelu, jonka pelaaja kuulee, kun vuorovaikuttaa
    public string[] dialogueLines = {
        "Tervetuloa sep�n pajalle!",
        "Tarvitsetko apua ty�kaluissa tai aseissa?",
        "Voin valmistaa sinulle uuden miek�n, jos sinulla on tarpeeksi kultaa."
    };

    // Ylikirjoitettu Interact-metodi, joka kutsuu DialogueSystemia
    public override void Interact()
    {
        // Lis�� dialogi DialogueSystemiin ja antaa sen tulostaa se konsoliin
        DialogueSystem.Instance.AddNewDialogue(dialogueLines, "Sepp�");
    }
}