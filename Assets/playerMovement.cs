using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce = 200f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //add foward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        //to move right and left
        if (Input.GetKey("d")){
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
    }
}
