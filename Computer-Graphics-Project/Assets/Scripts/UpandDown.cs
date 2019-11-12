using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDown : MonoBehaviour
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
    float y = 15;
    bool up = true;
    void Update()
    {
        if (y > 55 && y <62)
            up = false;
        if (y < 15 && y > 8)
            up = true; 
         if (up)
            y = upsy(y);
        else
            y= down(y);
 

        
    }
    float upsy( float y)
    {
        y = transform.position.y + 1;
        Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = pos;
        return y;
    }
    float down(float y)
    {
        y = transform.position.y - 1;
        Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = pos;
        return y;
    }

}