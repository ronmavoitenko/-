using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject settingsmenu;
    private string upr = "NumberOfCube";
    private string lvlcnt = "savedlavel";
    private int coins = 0;
    private int count = 0;
    private int levelContinue = 1;
    
    int scene;

    void Start() 
    {
        if(PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
        }
        count = PlayerPrefs.GetInt(upr);
        if(PlayerPrefs.HasKey(lvlcnt))
        {   
            levelContinue = PlayerPrefs.GetInt(lvlcnt);
        }
        else
        {
            levelContinue = 1;
        }
    }

    public void Play()
    {
            SceneManager.LoadScene(levelContinue);
    }

    public void Settings()
    {
        menu.SetActive(false);
        settingsmenu.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        scene = EndGame.LevelRestart;
        PlayerPrefs.SetInt(lvlcnt, scene);
        SceneManager.LoadScene(scene);
    }

    public void Nextlevel()
    {
        scene = NextLevel.nextLevel;
        PlayerPrefs.SetInt(lvlcnt, scene);
        SceneManager.LoadScene(scene);
    }

    public void CubeUpgrade()
    {   
        if(count == 0)
        {
            if(coins >= 250)
            {
                coins = coins-250;
                PlayerPrefs.SetInt("Coins", coins);
                PlayerPrefs.SetInt("NumberOfCube", count+1);
            }
            else
            {
                Debug.Log("You doesn't have enough money");
            }  
        }
        else if(count == 1)
        {
            if(coins >= 500)
            {
                coins = coins-500;
                PlayerPrefs.SetInt("Coins", coins);
                PlayerPrefs.SetInt("NumberOfCube", count+1);
            }
            else
            {
                Debug.Log("You doesn't have enough money");
            }
        }
        else if(count == 2)
        {
            if(coins >= 750)
            {
                coins = coins-750;
                PlayerPrefs.SetInt("Coins", coins);
                PlayerPrefs.SetInt("NumberOfCube", count+1);
            }
            else
            {
                Debug.Log("You doesn't have enough money");
            }
        }
        else if(count == 3)
        {
           if(coins >= 1000)
            {
                coins = coins-1000;
                PlayerPrefs.SetInt("Coins", coins);
                PlayerPrefs.SetInt("NumberOfCube", count+1);
            }
            else
            {
                Debug.Log("You doesn't have enough money");
            }
        }
        else if(count == 4)
        {
            if(coins >= 1250)
            {
                coins = coins-1250;
                PlayerPrefs.SetInt("Coins", coins);
                PlayerPrefs.SetInt("NumberOfCube", count+1);
            }
            else
            {
                Debug.Log("You doesn't have enough money");
            }
        }
        else if(count == 5)
        {
            if(coins >= 1500)
            {
                coins = coins-1500;
                PlayerPrefs.SetInt("Coins", coins);
                PlayerPrefs.SetInt("NumberOfCube", count+1);
            }
            else
            {
                Debug.Log("You doesn't have enough money");
            }
        }
        else if(count == 6)
        {
            Debug.Log("You can't buy, MAX level");
        }
    }

}
