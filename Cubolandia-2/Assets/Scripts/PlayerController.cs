using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalForce= 1000f;
    public Rigidbody playerRB;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            playerRB.AddForce(horizontalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            playerRB.AddForce(-horizontalForce * Time.deltaTime, 0, 0);
        }

    }
}
