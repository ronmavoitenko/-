using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject settingsmenu;
    
    int scene;

    public void Play()
    {
        SceneManager.LoadScene(1);
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
        SceneManager.LoadScene(scene);
    }

    public void Nextlevel()
    {
        scene = NextLevel.nextLevel;
        SceneManager.LoadScene(scene);
    }

}
