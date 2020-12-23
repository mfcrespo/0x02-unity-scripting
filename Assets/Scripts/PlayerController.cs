﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variable that can be edited in the Inspector to easily modify the Player‘s speed
    public float speed = 300f;

    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add speed force
        if ( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
    
        if ( Input.GetKey("a")  || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
    
        if ( Input.GetKey("s")  || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }        
    }
}
