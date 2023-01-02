using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Upgrades : MonoBehaviour
{
    public GameObject Cube;
    private int count = 0;
    private GameObject clone;

    void Awake()
    {
        count = PlayerPrefs.GetInt("NumberOfCube");
        Vector3 positionV = new Vector3(-80, 1, -0.47f);
        
        for(int i=0; i<count; i++)
        {
            clone = Instantiate(Cube);
            clone.transform.position = positionV;
        }
    }
}
