using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;

    // void Start()
    // {
    //     Debug.Log("working");
    //     // rb.useGravity = false;
    //     rb.AddForce(0,200,500);
    // }

    // Update is called once per frame
    public float forwordForce = 2000f;
    public float slidewaysForce= 500f;
    void FixedUpdate()
    {
        // Add a forwordForce
        rb.AddForce(0,0,forwordForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(slidewaysForce*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-slidewaysForce*Time.deltaTime,0,0);
        }
    }
}
