using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMovement : MonoBehaviour
{
    public Rigidbody RV;
    public float speed = 5f;
    public float jumpForce = 5f;
    public float jumpRaycastDistance = 1.1f; // Original ground check method

    // Start is called before the first frame update
    void Start()
    {
        if (RV == null)
        {
            RV = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput * speed, RV.velocity.y, 0);

        RV.velocity = new Vector3(movement.x, RV.velocity.y, RV.velocity.z);

        if (Input.GetButtonDown("Jump") && CanJump())
        {
            Jump();
        }
    }

    private void Jump()
    {
        RV.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private bool CanJump()
    {
        return Physics.Raycast(this.transform.position, Vector3.down, jumpRaycastDistance);
    }
}
