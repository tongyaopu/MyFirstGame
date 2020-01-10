 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // reference to a rigidbody called rb 
    public Rigidbody rb;

    // create variables so force could be adjusted
    public float forwardForce = 2000f;
    public float sidewardForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        // rb.useGravity = false;
        // rb.AddForce(0, 200, 500);
    }


    // Update is called once per frame
    // we use "Fixed"Update because dealing with physics
    void FixedUpdate()
    {

        // add a forward force on z axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // add a sideward force if key is pressed
        if (Input.GetKey("d")) {
            rb.AddForce(sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
