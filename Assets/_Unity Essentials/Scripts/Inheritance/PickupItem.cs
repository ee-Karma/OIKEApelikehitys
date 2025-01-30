using UnityEngine;

public class PickupItem : Interactable
{
    public override void Interact()
    {
        base.Interact();
        print("Ker‰‰ minut!");
        Destroy(gameObject, 2f);
    }
}
