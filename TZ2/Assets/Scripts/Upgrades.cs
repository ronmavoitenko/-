using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject Cube;

    void Awake()
    {
        var clone = Instantiate(Cube);
        int count = PlayerPrefs.GetInt("NumberOfCube");
        Vector3 positionV = new Vector3(-80, 1, -0.47f);
        for(int i=0; i<count; i++)
        {
            //clone = Instantiate(Cube);//, position, Quaternion.identity);
            clone.transform.position = positionV;
        }
    }
}
