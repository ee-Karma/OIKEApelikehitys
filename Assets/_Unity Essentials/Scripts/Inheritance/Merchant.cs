using UnityEngine;

public class Merchant : Interactable
{
    public string[] dialogueLines = {
        "Tervetuloa ostoksille!",
        "Meill� on parhaat hinnat kaupungissa.",
        "Mit� haluaisit ostaa?"
    };

    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(dialogueLines, "Kauppias");
    }
}
