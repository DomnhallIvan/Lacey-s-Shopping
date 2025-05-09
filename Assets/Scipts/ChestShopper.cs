using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestShopper : InteractionBehavior
{
    [SerializeField] private Canvas _shopCanvas;

    //WhenPlayerCloses the ShopMenu it should restart PlayerController speed.
    public override void Interact(PlayerInteraction player)
    {
        //OpenShopMenu LOL
        Debug.Log("OpenShopMenu LOL");
        player.GetPlayerControler().speed = 0;
        _shopCanvas.enabled = true;
        //StopPlayerMovement
    }

    

}
