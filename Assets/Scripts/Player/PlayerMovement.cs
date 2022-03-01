using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float circleRadius = 0.5f;
    public Transform groundCheck;
    public LayerMask WhatIsGround;
    public float moveSpeed = 0f;
    public float jumpForce = 10f;
    public bool isGrounded;
    private float moveInput;
    public Animator animator;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, circleRadius, WhatIsGround);
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update() {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))&& isGrounded) {
            rb.velocity = Vector2.up * jumpForce;
        }
        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) {
            moveSpeed = 10f;
            animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
        }
        
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
            moveSpeed = 0f;
            animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
        }
    }
}
