using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemShopObj", menuName = "Scriptable Objects/ShopItemSO")]
public class SO_ItemShop : ScriptableObject
{
    //public Transform prefab;
    public string title;
    public Sprite ItemImage;
    public int price;
    public string AnimatorID;
}
