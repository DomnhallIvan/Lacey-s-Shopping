using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerText; //CoinText

    public void SetScore(int value)
    {
        _playerText.text = value.ToString();
    }
}
