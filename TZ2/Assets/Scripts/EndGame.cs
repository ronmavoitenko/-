using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public static int LevelRestart;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lets")
        {
            SceneManager.LoadScene(2);
        }
    }
}
