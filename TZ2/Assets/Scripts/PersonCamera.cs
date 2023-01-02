using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonCamera : MonoBehaviour
{
    public GameObject ob;
    public Vector3 pos;

    private void LateUpdate() 
    {
        this.transform.position = Vector3.Lerp(this.transform.position, ob.transform.position + pos, Time.deltaTime);
    }
}
