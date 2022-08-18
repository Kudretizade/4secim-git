using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float dirX, dirZ;

    private void Start()
    {
        speed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        dirX = Input.GetAxis("Horizontal") * speed;
        dirZ = Input.GetAxis("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3 (dirX, rb.velocity.y, dirZ);
    }
}
