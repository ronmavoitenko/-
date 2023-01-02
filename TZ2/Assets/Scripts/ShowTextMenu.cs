using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextMenu : MonoBehaviour
{
    public Text levelPrice;
    public Text levelshow;
    public Text HaveMoney;
    private int count=0;
    private int coins=0;
    private int coinsHave;
    void Start()
    {
        count = PlayerPrefs.GetInt("NumberOfCube");
        levelshow.text = count.ToString();
        coinsHave = PlayerPrefs.GetInt("Coins");
        HaveMoney.text = coinsHave.ToString();
        if(count <= 5)
        {
            coins = (count+1) * 250;
            levelPrice.text = coins.ToString();
        }
        else
        {
            levelPrice.text = "Max Level";
        }
    }

}
