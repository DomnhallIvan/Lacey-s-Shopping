using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UI_Player UIreference;
    public PlayerController playerRef;
    public ShopBttns UIManagerRef;

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;            
        }
    }

    public void AddScoreCoins(int coinValue)
    {
        playerRef.scoreCoins += coinValue;
        UIreference.SetScore(playerRef.scoreCoins);
        UIManagerRef.CheckPurchaseable();
    }
    
    public float GetPlayerCoins()
    {
        return playerRef.scoreCoins;
    }

    public void SpendCoins(int coinValue)
    {
        playerRef.scoreCoins -= coinValue;
        UIreference.SetScore(playerRef.scoreCoins);
    }
}
