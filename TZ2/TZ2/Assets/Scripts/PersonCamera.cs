using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonCamera : MonoBehaviour
{
    public GameObject ob;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate() 
    {
        this.transform.position = Vector3.Lerp(this.transform.position, ob.transform.position + pos, Time.deltaTime);
    }
}
