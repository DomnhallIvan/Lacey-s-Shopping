using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestShopper : InteractionBehavior
{
    [SerializeField] private Canvas _shopCanvas;

    //WhenPlayerCloses the ShopMenu it should restart PlayerController speed from the Buttons.
    public override void Interact(PlayerInteraction player)
    {
        //OpenShopMenu LOL
        //StopPlayerMovement
        player.GetPlayerControler().GetSpeed(0);
        _shopCanvas.enabled = true;

    }

    

}
