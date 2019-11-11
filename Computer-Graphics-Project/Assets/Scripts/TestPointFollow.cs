using UnityEngine;
using System.Collections;
public class TestPointFollow : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 targetPosition;
    private bool isMoving;
    public GameObject clickAnimation;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        //Vector3 playerPos = Camera.main.ScreenToWorldPoint(rb.transform.position);
        
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        rb.transform.position += move * speed * Time.deltaTime * 5;
        Vector3 playerPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 1000));
        
    }
}