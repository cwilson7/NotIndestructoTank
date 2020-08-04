using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    int groundLayer = 8;
    float jumpHeight = 5f, runSpeed = 3f;
    public bool jumping = false, isGrounded = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Inputs();
    }

    void Inputs()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 inputVector = new Vector3(inputX * runSpeed, inputY * runSpeed, 0f);
        rb.velocity = inputVector;
    }
}
