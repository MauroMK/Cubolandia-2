using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;

    public float forwardForce = 2000f;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        playerRb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
