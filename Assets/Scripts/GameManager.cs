using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;   
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
public TextMeshProUGUI CoinText;
public static GameManager gameManager;
public int Coins = 0;
public void Update() 
{
        CoinText.text = "Coins: " + Coins;
}
public void CoinCollected()
{
    Coins++;
}
}
