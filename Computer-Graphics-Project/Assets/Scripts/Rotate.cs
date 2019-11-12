using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float jumpForce = 3.0f;
    public float speed;
    private float moveInputX;
    private float moveInputY;
    private Rigidbody2D rb;
    private float speedRotate = 50f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);

    }
}