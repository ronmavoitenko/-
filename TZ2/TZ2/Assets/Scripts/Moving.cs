using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public DynamicJoystick joystick;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float RLspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //gameObject.GetComponent<Rigidbody>().velocity = -transform.right * -(joystick.Direction.x * speed); 
        //float way = Input.GetAxis("Horizontal") * RLspeed * Time.deltaTime;
        float way = joystick.Horizontal * RLspeed * Time.deltaTime;
        this.transform.Translate(way, 0, speed *Time.deltaTime);
    }
}
