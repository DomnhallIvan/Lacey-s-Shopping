using UnityEngine;
using UnityEngine.UI;

public class InteractionBehavior : MonoBehaviour
{
    [SerializeField] private Image InteractionImage;

    public virtual void Interact(PlayerInteraction player)
    {
        Debug.Log("PlayerInteract");
    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        InteractionImage.enabled = true;
        if (other.TryGetComponent(out PlayerInteraction playerInteract))
        {
            playerInteract.CanInteract = true;
        }
    }

    public virtual void OnTriggerExit2D(Collider2D other)
    {
        InteractionImage.enabled=false;
        if (other.TryGetComponent(out PlayerInteraction playerInteract))
        {
           playerInteract.CanInteract = false;
        }

    }

    


}
