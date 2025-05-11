using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    //Remplazar por un int del Player
    [SerializeField] private int coinvalue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            // Coin++;
            GameManager.instance.AddScoreCoins(coinvalue);
            ReturnToPool();

        }
    }


    private void ReturnToPool()
    {
        ObjectPool pool = FindObjectOfType<ObjectPool>();
        if (pool != null)
        {
            pool.ReturnToPool(gameObject);
        }
    }
}
