using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidetoSide : MonoBehaviour
{
    public float jumpForce = 3.0f;
    private float moveInputX;
    private float moveInputY;
    private Rigidbody2D rb;
    private float speedRotate = 50f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    float speed = 1f;
    float delta = 3f;  //delta is the difference between min y to max y.
    float x = 145;
    bool up = true;
    void Update()
    {
        if (x > 270 && x < 280)
            up = false;
        if (x < 110 && x > 95)
            up = true;
        if (up)
            x = right(x);
        else
            x = left(x);



    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blue")
        {
            up = !up;
        }
    }
    float right(float x)
    {
        x = transform.position.x + .5f;
        Vector3 pos = new Vector3(x, transform.position.y, transform.position.z);
        transform.position = pos;
        return x;
    }
    float left(float x)
    {
        x = transform.position.x - .5f;
        Vector3 pos = new Vector3(x, transform.position.y, transform.position.z);
        transform.position = pos;
        return x;
    }

}