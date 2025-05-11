using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UI_Player UIreference;
    public PlayerController playerRef;

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
    } 
}
