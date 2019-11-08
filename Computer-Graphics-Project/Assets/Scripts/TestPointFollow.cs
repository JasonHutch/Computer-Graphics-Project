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
        Vector3 temp = Input.mousePosition;
        temp.z = 0.0f; // Set this to be the distance you want the object to be placed in front of the camera.
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}