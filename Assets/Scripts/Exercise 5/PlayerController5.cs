using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController5 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isGrounded = true;
    private Animator animator;

    public GameManager4 gameManager4;

    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Death"))
        {
            float moveInput = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

            if (moveInput != 0)
            {
                transform.localScale = new Vector3(Mathf.Sign(moveInput), 1, 1);
            }

            if (moveInput > 0)
            {
                animator.SetBool("MoveRight", true);
                animator.SetBool("MoveLeft", false);
            }
            else if (moveInput < 0)
            {
                animator.SetBool("MoveRight", false);
                animator.SetBool("MoveLeft", true);
            }
            else
            {
                animator.SetBool("MoveRight", false);
                animator.SetBool("MoveLeft", false);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
    
    if (collision.gameObject.CompareTag("Enemy"))
        {
            
            if (!isDead) 
            {
                Debug.Log("Hit by Enemy!");
                animator.SetBool("Death", true);
                isDead = true;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = false;
        Debug.Log("Not Grounded!");
    }
    }

    
}