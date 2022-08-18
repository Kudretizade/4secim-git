using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;

    private void Start()
    {
        moveSpeed = 5f;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        dirZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
