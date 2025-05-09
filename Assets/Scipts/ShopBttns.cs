using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBttns : MonoBehaviour
{
    [SerializeField] private TopDownCharacterController _characterRef;


    public void SetPlayerSpeed()
    {
        _characterRef.speed = 3;
    }
}
