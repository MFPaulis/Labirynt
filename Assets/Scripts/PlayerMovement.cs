using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    //Transform something;
    /*
    void Awake ()
    {
        rb = something.gameObject.GetComponent<Rigidbody2D>();
    }
    */
    

    // Update is called once per frame
    void Update()
    {
        /*
        Vector2 newPos;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            float x = rb.position.x + moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

        }
        */
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
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
