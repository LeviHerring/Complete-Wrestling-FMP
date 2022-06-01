using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class TestingInputSystem : MonoBehaviour
{

    public Transform groundCheck;
        public LayerMask groundLayer;
    private Rigidbody2D rigidBody;

    private float horizontal;
    private float speed = 10f;
    private float jumpingPower = 5f;
    private bool isFacingRight = true; 

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        rigidBody.velocity = new Vector2(horizontal * speed, rigidBody.velocity.y);
        
        if(!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip(); 
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpingPower);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer); 
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale; 
    }


    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x; 
    }
}
