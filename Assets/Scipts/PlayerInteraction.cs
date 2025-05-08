using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool CanInteract;

    /*
    public void TryInteract()
    {
        Ray ray = new Ray(pivotRaycast.position, pivotRaycast.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactRange, interactableLayer))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact(this);  // Llama a la interacci�n.
            }
        }
    }*/


    
}
