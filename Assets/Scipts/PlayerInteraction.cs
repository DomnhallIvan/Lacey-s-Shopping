using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool CanInteract;

    [Header("Interaction Settings")]
    [SerializeField] private LayerMask _interactLayerMask;  
    [SerializeField] private float interactRange = 2f;
    [SerializeField] private Transform carryPivot;  // Pivote donde se posiciona el objeto.

    [Header("Raycast")]
    [SerializeField] private Transform pivotRaycast;  // Punto de raycast.

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&CanInteract)
        {
            TryInteract();
        }
    }


    public void TryInteract()
    {
        Ray ray = new Ray(pivotRaycast.position, pivotRaycast.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactRange, _interactLayerMask))
        {
            if (hit.transform.TryGetComponent(out InteractionBehavior InteractBuddy) != false)
            {
                if (InteractBuddy != null)
                {
                    InteractBuddy.Interact(this);
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Ray ray = new Ray(pivotRaycast.position, pivotRaycast.forward);

        Gizmos.color = Physics.Raycast(ray, out _, interactRange, _interactLayerMask)
            ? Color.red
            : Color.green;

        Gizmos.DrawRay(ray.origin, ray.direction * interactRange);
    }




}
