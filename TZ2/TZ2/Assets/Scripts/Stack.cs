using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    bool IfStack;
    int i;
    public ToPlayer toPlayer;
    // Start is called before the first frame update
    void Start()
    {
        IfStack = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IfStack == true)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0,-i, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lets")
        {
            toPlayer.NumberDecrement();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetStack()
    {
        return IfStack;
    }
    public void stack()
    {
        IfStack = true;
    }
    public void IndexStack(int i)
    {
        this.i = i;
    }
}