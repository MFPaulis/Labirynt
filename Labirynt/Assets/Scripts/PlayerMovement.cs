using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //float x = rb.position.x + moveSpeed * Time.deltaTime;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        
        if(movement.x == 1 || movement.x == -1 || movement.y == 1 || movement.y == -1)
        {
            animator.SetFloat("LastVertical", movement.y);
            animator.SetFloat("LastHorizontal", movement.x);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    /*
    void OnCollisionEnter2d (Collision collision)
    {
        if (collision.transform.CompareTag("Test") && collision.transform.tag == "Test")
        {

        }
    }
    */
}
