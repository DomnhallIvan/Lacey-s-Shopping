using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBttns : MonoBehaviour
{
    [SerializeField] private PlayerController _characterRef;

    //SetNewPlayerSpeed 3 Recommended
    public void SetPlayerSpeed(float newSpeed)
    {
        _characterRef.GetSpeed(newSpeed);
    }
}
