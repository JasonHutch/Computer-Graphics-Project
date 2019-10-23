using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpForce = 3.0f;
    public float speed;
    private float moveInputX;
    private float moveInputY;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInputX = Input.GetAxisRaw("Mouse X");
        moveInputY = Input.GetAxisRaw("Mouse Y");

        rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}