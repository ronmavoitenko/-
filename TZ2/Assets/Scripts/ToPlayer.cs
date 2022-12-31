using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPlayer : MonoBehaviour
{
    GameObject Camera;
    static int number=0;
    
    void Start()
    {
        Camera = GameObject.Find("Cube");
    }

    void Update()
    {
        Camera.transform.position = new Vector3(transform.position.x, number+1, transform.position.z);
        this.transform.localPosition = new Vector3(0,-number, 0);
    }
    public void NumberDecrement()
    {
        number--;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "stack" && other.gameObject.GetComponent<Stack>().GetStack() == false)
        {
            number += 1;
            other.gameObject.GetComponent<Stack>().stack();
            other.gameObject.GetComponent<Stack>().IndexStack(number);
            other.gameObject.transform.parent = Camera.transform;
        }   
    }
}
