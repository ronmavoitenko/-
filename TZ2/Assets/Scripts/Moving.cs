using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    //public GameObject ob;
    private float l;
    private float r;
    public DynamicJoystick joystick;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float RLspeed;
    // Start is called before the first frame update
    void Start()
    {
        r=4.5f;
        l=-4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float way = joystick.Horizontal * RLspeed * Time.deltaTime;
        this.transform.Translate(way, 0, speed * Time.deltaTime);

        if(transform.position.z > 4.5) 
        {
            this.transform.Translate(r * Time.deltaTime*3, 0, 0);
        }
        else if(transform.position.z < -4.5)
        {
            transform.Translate(l * Time.deltaTime*3, 0, 0);
        }
    }
}
