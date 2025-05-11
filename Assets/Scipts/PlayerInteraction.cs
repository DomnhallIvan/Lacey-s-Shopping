using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool CanInteract;

    private GameObject reference; //Reference to the GameObject that the Player CanInteract with
    [SerializeField] private PlayerController characterController;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&CanInteract && reference != null)
        {
            TryInteract(reference);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out InteractionBehavior InteractBuddy))
            reference = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out InteractionBehavior InteractBuddy))
            reference = null;
    }

    public void TryInteract(GameObject hit)
    {      
            if (hit.transform.TryGetComponent(out InteractionBehavior InteractBuddy))
            {
                if (InteractBuddy != null)
                {
                    InteractBuddy.Interact(this);
                }
            }        
    }

    public PlayerController GetPlayerControler() { return characterController; }





}
