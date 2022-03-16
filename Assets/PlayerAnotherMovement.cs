using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnotherMovement : MonoBehaviour
{
    public float playerSpeed;
    Rigidbody2D rb;
    Vector2 movement;
    Animator animator;
    public float jumpForce;
    bool isGrounded = true;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        animator.SetFloat("isRun", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        PlayerJump();
    }

    private void PlayerJump()
    {
        rb.velocity = new Vector2(movement.x * playerSpeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            animator.SetBool("isJumping", true);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        if(collision.gameObject.tag == "Platform")
        {
            animator.SetBool("isJumping", true);
        }
    }
}
