using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ShopBttns : MonoBehaviour
{
    [SerializeField] private PlayerAnimation _animationRef;
    public SO_ItemShop[] shopItemsSO;
    public ShopTemplate[] shopOptions;
    public Button[] myPurchaseBtns;
    private void Start()
    {
        LoadPanels();
        CheckPurchaseable();
    }

    //SetNewPlayerSpeed 3 Recommended
    public void SetPlayerSpeed(float newSpeed)
    {
        GameManager.instance.playerRef.ChangeSpeed(newSpeed);
    }   

   

    public void CheckPurchaseable()
    {
        for(int i=0; i<shopItemsSO.Length; i++)
        {
            float playerMoney = GameManager.instance.GetPlayerCoins();
            if (playerMoney >= shopItemsSO[i].price)
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable=false;
        }
    }

   public void LoadPanels()
    {
        for (int i=0; i<shopItemsSO.Length; i++)
        {
            shopOptions[i].titleText.text= shopItemsSO[i].title;
            shopOptions[i].ItemImage.sprite = shopItemsSO[i].ItemImage;
            shopOptions[i].priceText.text = "BUY: $"+shopItemsSO[i].price.ToString();
        }
    }

    public void PurchaseItem(int btnNum)
    {
        float playerMoney = GameManager.instance.GetPlayerCoins();
        int shopItemPrice = shopItemsSO[btnNum].price;
        string animID = shopItemsSO[btnNum].AnimatorID;
        if (playerMoney >= shopItemPrice)
        {
            GameManager.instance.SpendCoins(shopItemPrice);
            _animationRef.SetBooleanHead(animID);
            CheckPurchaseable();
        }
    }

    public void PurchaseItemBody(int btnNum)
    {
        float playerMoney = GameManager.instance.GetPlayerCoins();
        int shopItemPrice = shopItemsSO[btnNum].price;
        string animID = shopItemsSO[btnNum].AnimatorID;
        if (playerMoney >= shopItemPrice)
        {
            GameManager.instance.SpendCoins(shopItemPrice);
            _animationRef.SetBooleanBody(animID);
            CheckPurchaseable();
        }
    }

    public void PurchaseItemEyes(int btnNum)
    {
        float playerMoney = GameManager.instance.GetPlayerCoins();
        int shopItemPrice = shopItemsSO[btnNum].price;
        string animID = shopItemsSO[btnNum].AnimatorID;
        if (playerMoney >= shopItemPrice)
        {
            GameManager.instance.SpendCoins(shopItemPrice);
            _animationRef.SetBooleanEyes(animID);
            CheckPurchaseable();
        }
    }

    //It adds money to the player. Resetting the animation happens in the button with another Function from PlayerAnimator
    public void Selling(int btnNum)
    {
        int shopItemPrice = shopItemsSO[btnNum].price;
        GameManager.instance.AddScoreCoins(shopItemPrice);
        CheckPurchaseable();
    }

    //Scrapped
    public void CheckPriceHead(int price, string headBool)
    {
        float playerMoney = GameManager.instance.GetPlayerCoins();
        if (playerMoney >= price)
        {
            GameManager.instance.SpendCoins(price);
            _animationRef.SetBooleanHead(headBool);
        }
        else
        {
           // Debug.Log("Not Enough Money!");
        }
    }

    public void BuySuperHead() => CheckPriceHead(5, "HeadSuper");
}
