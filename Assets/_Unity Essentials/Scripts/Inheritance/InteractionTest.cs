using UnityEngine;

public class InteractionTest : MonoBehaviour
{
    private void Update()
    {
        // Tarkistetaan, onko pelaaja napsauttanut hiirellä objektia
        if (Input.GetMouseButtonDown(0))  // Hiiren vasen painike
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Jos osutaan vuorovaikutteiseen objektiin, kutsutaan Interact-metodia
                Interactable interactableObject = hit.collider.GetComponent<Interactable>();
                if (interactableObject != null)
                {
                    interactableObject.Interact();  // Kutsutaan vuorovaikutuksen metodia
                }
            }
        }
    }
}