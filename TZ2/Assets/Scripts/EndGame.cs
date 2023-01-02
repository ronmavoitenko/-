using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public static int LevelRestart=0;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level1")
        {
            LevelRestart = 1;
        }
        else if(SceneManager.GetActiveScene().name == "Level2")
        {
            LevelRestart = 4;
        }
        else if(SceneManager.GetActiveScene().name == "Level3")
        {
            LevelRestart = 5;
        }
        else if(SceneManager.GetActiveScene().name == "Level4")
        {
            LevelRestart = 6;
        }
        else if(SceneManager.GetActiveScene().name == "Level5")
        {
            LevelRestart = 7;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lets")
        {
            SceneManager.LoadScene(2);
        }
    }
}
