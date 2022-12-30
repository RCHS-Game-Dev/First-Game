using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{   
    public float MovementSpeed = 10f;
    public float JumpForce;
    public float JumpHeight = 15;
    public Transform GroundCheck;
    public Rigidbody2D rb;
    public LayerMask InteractiveEnvironment;
    public float UpGravityScale = 5;
    public float DownGravityScale = 15;

 
    void start()

    {
        rb= GetComponent<Rigidbody2D>();
        float JumpForce = Mathf.Sqrt(JumpHeight * (Physics2D.gravity.y * rb.gravityScale) * -2) * rb.mass;
    }

    bool Grounded()
    {
        return Physics2D.OverlapCircle(new Vector2(GroundCheck.transform.position.x, transform.position.y - 0.01f), transform.localScale.x / 2f , InteractiveEnvironment);
    }

    void FixedUpdate()
    {
    if (Input.GetButton("Jump") && Grounded())
    {
        rb.AddForce(Vector2.up * 500);
        Debug.Log("jumped");
    }
    }


    void Update()
    {
    float HorizontalInput = Input.GetAxis("Horizontal");
    Vector3 HorizontalMovement = new Vector2(transform.position.x + HorizontalInput * MovementSpeed * Time.deltaTime, transform.position.y);
    transform.position = HorizontalMovement;

    }
}