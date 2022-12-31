using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    public Text coinsText;
    private int coins = 0;

    private void Start() 
    {
        if(PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
            coinsText.text = coins.ToString();
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Coin")
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coins", coins);
        }
    }
}
