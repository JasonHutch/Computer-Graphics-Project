using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diagonal : MonoBehaviour
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
    float y = -35;
    float x = 122;
    bool up = false;
    void Update()
    {
        if (y > -10 && y < 5)
            up = false;
        if (y < -65 && y > -75)
            up = true;
        if (up)
            y = upsy(y,x);
        else
            y = down(y,x);



    }
    float upsy(float y, float x)
    {
        y = transform.position.y + .5f;
        x = transform.position.x + .5f;
        Vector3 pos = new Vector3(x, y, transform.position.z);
        transform.position = pos;
        return y;
    }
    float down(float y, float x)
    {
        y = transform.position.y - .5f;
        x = transform.position.x - .5f;
        Vector3 pos = new Vector3(x, y, transform.position.z);
        transform.position = pos;
        return y;
    }

}