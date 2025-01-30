using UnityEngine;

public class Merchant : Interactable
{
    public string[] dialogueLines = {
        "Tervetuloa ostoksille!",
        "Meillä on parhaat hinnat kaupungissa.",
        "Mitä haluaisit ostaa?"
    };

    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(dialogueLines, "Kauppias");
    }
}
