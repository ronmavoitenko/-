using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public static int nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level1")
        {
            nextLevel = 4;
        }
        else if(SceneManager.GetActiveScene().name == "Level2")
        {
            nextLevel = 5;
        }
        else if(SceneManager.GetActiveScene().name == "Level3")
        {
            nextLevel = 6;
        }
        else if(SceneManager.GetActiveScene().name == "Level4")
        {
            nextLevel = 7;
        }
        else if(SceneManager.GetActiveScene().name == "Level5")
        {
            nextLevel = 7;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LLets")
        {
            SceneManager.LoadScene(3);
        }
    }
}
